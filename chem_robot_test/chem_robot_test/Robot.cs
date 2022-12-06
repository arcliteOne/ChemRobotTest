using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
//using System.Text.Json;
//using System.Text.Json.Serialization;
using Newtonsoft.Json;
using KGySoft.Drawing;




public class Robot
{
	public SerialPort port = new SerialPort();
	public Point3D current_position = new Point3D(0, 0, 0);
	private bool alive = true;
	public Bitmap[] zone_images = new Bitmap[10];
	//public Zone[] zones = new Zone[10];
	public Zone[] zones;// = new List<Zone>();

	public List<Module> modules = new List<Module>();
	public List<Module2> modules1 = new List<Module2>();
	public List<Module> TipModules = new List<Module>();
	public List<Module> TubeModules = new List<Module>();
	public List<Module> WellPlateModules = new List<Module>();
	public List<Module> DropModules = new List<Module>();
	public List<liquid> liquids = new List<liquid>();

	public int okCounter = 0;
	public int waitCounter = 0;
	public string received = "";

	enum GRBL_STATE : int
	{
		M_INIT = 0, //  0 machine is initializing
		M_RESET,    //  1 machine is ready for use
		M_ALARM,    //  2 machine is in alarm state (soft shut down)
		M_IDLE,     //  3 program stop or no more blocks (M0, M1, M60)
		M_END,      //  4 program end via M2, M30
		M_RUNNING,  //  5 motion is running
		M_HOLD,     //  6 motion is holding
		M_PROBE,    //  7 probe cycle active
		M_CYCLING,  //  8 machine is running (cycling)
		M_HOMING,   //  9 machine is homing
		M_JOGGING,  // 10 machine is jogging
		M_ERROR     // 11 machine is in hard alarm state (shut down)
	};




	public struct liquid {
		public string name;
		public string description;
		public Color color;
		public int id;
		public void clear()
		{
			name = null;
			description = null;
			color = Color.Transparent;
			id = 0;
		}
	
	
	
	}




	public class Module
	{

		public string name { get; set; }
		public string type { get; set; }
		public PointF size { get; set; }
		public Bitmap Image;
		public PointF zeroCoord { get; set; }
		public float min_h { get; set; }
		public float max_h { get; set; }
		public string description { get; set; }
		public Point gridElements { get; set; }
		public PointF gridStep { get; set; }
		public float diameter { get; set; }
		public float numberOfElements { get; set; }
		public bool ready { get; set; }
		public int id { get; set; }
		public List<Point3D> points = new List<Point3D>();
		public List<Point> imagePoints = new List<Point>();
		public float ppm { get; set; } //pixels per mm for D



		public Module()
		{
			//ppm = 7;

			zeroCoord = new PointF();

			gridElements = new Point();
			gridStep = new PointF();

			ready = false;
		}

	

		public Module(Module2 m)
		{
			type = m.type;
			name = m.moduleName;
			zeroCoord = m.zeroCoord;
			min_h = m.min_h;
			max_h = m.max_h;
			description = m.description;
			gridElements = m.gridElements;
			gridStep = m.gridStep;
			diameter = m.diameter;
			numberOfElements = m.numberOfElements;
			ready = m.ready;
			id = m.id;
			ppm = m.ppm;

			fillPoints(new PointF(0, 0));
		}


		public Module(string pathToFile)
		{
		}
		public void fillPoints(PointF zero)
		{
			points.Clear();
			for (int i = 0; i < gridElements.Y; i++)
			{
				for (int q = 0; q < gridElements.X; q++)
				{
					float x = zeroCoord.X + gridStep.X * q;
					float y = zeroCoord.Y + gridStep.Y * i;
					float z = min_h;

					Point tmpImgPoint = new Point((int)(x * ppm), (int)(y * ppm));
					imagePoints.Add(tmpImgPoint);

					x += zero.X;
					y += zero.Y;

					
					Point3D tmp_point = new Point3D(x, y, z);

					points.Add(tmp_point);

				}
			}
		}

		public void drawImageFromData()
		{
			
			Image = new Bitmap(900, 600);
			ppm = (Image.Size.Width / size.X); 
			Graphics fig;
			fig = Graphics.FromImage(Image);
			Pen myPen = new Pen(Brushes.LightGray);

			myPen.Width = 5.0f;

			fig.DrawRoundedRectangle(myPen, new Rectangle(0, 0, 900, 600), 100);

			for (int i = 0; i < gridElements.X; i++)
			{
				for (int q = 0; q < gridElements.Y; q++)
				{
					Rectangle position = new Rectangle();
					position.X = (int)((zeroCoord.X - diameter / 2.0) * ppm);
					position.Y = (int)((zeroCoord.Y - diameter / 2.0) * ppm);
					position.Width = (int)(diameter * ppm);
					position.Height = (int)(diameter * ppm);
					position.X += (int)(i * gridStep.X * ppm);
					position.Y += (int)(q * gridStep.Y * ppm);
					fig.DrawEllipse(myPen, position);
				}
			}

			//Image = image;

			//return image;
		}



	};



	public struct Module2 {

		public string type { get; set; }
		public string moduleName { get; set; }
		public Bitmap moduleImage { get; set; }
		public PointF zeroCoord;
		public float min_h { get; set; }
		public float max_h { get; set; }
		public string description { get; set; }
		public Point gridElements;
		public PointF gridStep;
		public float diameter { get; set; }
		public float numberOfElements { get; set; }
		public bool ready { get; set; }
		public int id { get; set; }
		public List<Point3D> points;
		public Label label;
		public int ppm; //pixels per mm for D
		

		public Module2(string path, string data, string header)
		{
			ppm = 7;
			string[] info = data.Split(new string[] { ";" }, StringSplitOptions.None);
			id = Convert.ToInt32(info[0]);
			type = info[1];
			string image_name = path + info[10];
			label = new Label();
			label.Text = image_name;
			moduleImage = new Bitmap(image_name);
			moduleName = info[2];
			description = info[3];
			zeroCoord = new PointF(0, 0);
			gridElements = new Point(0,0);
			string[] tmp_array = info[7].Split(new string[] { "," }, StringSplitOptions.None);
			gridElements.X = int.Parse(tmp_array[0]);
			gridElements.Y = int.Parse(tmp_array[1]);


			string[] tmp_array_2 = info[4].Split(new string[] { "," }, StringSplitOptions.None);
			zeroCoord.X = float.Parse(tmp_array_2[0]);
			zeroCoord.Y = float.Parse(tmp_array_2[1]);

			gridStep = new PointF();
			string[] tmp_array_3 = info[8].Split(new string[] { "," }, StringSplitOptions.None);
			gridStep.X = float.Parse(tmp_array_3[0]);
			gridStep.Y = float.Parse(tmp_array_3[1]);


			min_h = float.Parse(info[5]);
			max_h = float.Parse(info[6]);
			
			//gridStep = new PointF(0, 0);
			diameter = float.Parse(info[9]);
			numberOfElements = 0;
			points = new List<Point3D>();
			for(int i = 0; i < gridElements.Y; i++)
			{
				for(int q = 0; q < gridElements.X; q++)
				{
					float x = zeroCoord.X + gridStep.X * q;
					float y = zeroCoord.Y + gridStep.Y * i;
					float z = min_h;
					Point3D tmp_point = new Point3D(x, y, z);
					points.Add(tmp_point);
				}
			}
			
			switch (type)
			{
				case "source":
					ready = true;
					break;
				case "tablet":
					ready = false;
					break;
				case "fallZone":
					ready = true;
					break;
				default:
					ready = true;
					break;
			}
		}

		public void fillPoints(PointF zero)
		{
			points.Clear();
			for (int i = 0; i < gridElements.Y; i++)
			{
				for (int q = 0; q < gridElements.X; q++)
				{
					float x = zero.X + zeroCoord.X + gridStep.X * q;
					float y = zero.Y + zeroCoord.Y + gridStep.Y * i;
					float z = min_h;
					Point3D tmp_point = new Point3D(x, y, z);
					points.Add(tmp_point);
				}
			}
		}

	};




	//public struct Module2 {
	//	public string type { get; set; }
	//	public string Name { get; set; }
	//	public Bitmap Image { get; set; }
	//	public PointF zeroCoord;
	//	public float min_h { get; set; }
	//	public float max_h { get; set; }
	//	public string description { get; set; }
	//	public Point gridElements;
	//	public PointF gridStep;
	//	public float diameter { get; set; }
	//	public float numberOfElements { get; set; }
	//	public bool ready { get; set; }
	//	public int id { get; set; }
	//	public List<Point3D> points;
	//	public List<Point> imagePoints;
	//	public Label label;
	//	public int ppm; //pixels per mm for D



	//};



	public struct Zone
	{
		public Module module;
		public bool active;
		public PointF zero_coord;
		public float size;

	}



	void connect(string new_port_name)
	{
		if (port.IsOpen)
		{
			port.Close();
		}
		try
		{
			port.PortName = new_port_name;
			port.BaudRate = 250000;
			port.DataBits = 8;
			port.Parity = Parity.None;
			port.StopBits = StopBits.One;
			port.Handshake = Handshake.RequestToSend;
			port.ReadBufferSize = 8192;
			port.DtrEnable = true;
			port.RtsEnable = true;
			Console.WriteLine(port.Handshake.GetTypeCode().ToString());
			
			port.Open();
			//send("M")
			Console.WriteLine("Port: " + new_port_name + " is open");
		}
		catch
		{
			Console.WriteLine("Some problems witth port: " + new_port_name);
		}
	}
	public void connect_nonblock(string new_port_name)
	{

		new Thread(() =>
		{
			connect(new_port_name);
		}).Start();

	}
	public bool send(string message)
	{
		if (port.IsOpen)
		{
			okCounter = 0;
			port.WriteLine(message);

			return true;
		}
		return false;
	}
	public void ReadSerial()
	{

		while(alive)
		{
			
			if (port.IsOpen)
			{

				string tmp = port.ReadExisting();
				if (tmp.Length != 0)
				{
					Console.WriteLine(tmp);
				}

			}
			Thread.Sleep(5);
		}
		
	}

	public void go_home()
	{
		if (port.IsOpen)
		{
			send("G28");
		}
	}

	public void go_to_position(Point3D target_position, int speed = 20000)
	{
		string message = "G1 X" + target_position.X.ToString("0.00",
				   System.Globalization.CultureInfo.GetCultureInfo("en-US")) + " Y" + target_position.Y.ToString("0.00",
				   System.Globalization.CultureInfo.GetCultureInfo("en-US")) + " Z" + target_position.Z.ToString("0.00",
				   System.Globalization.CultureInfo.GetCultureInfo("en-US")) + " F" + speed.ToString();
		Console.WriteLine(message);
		send(message);
	}

	public Robot()
	{
	

	}
	~Robot()
	{

	}



	public void printSquare(Point3D zero, float size)
	{
		List<Point3D> points = new List<Point3D>();
		okCounter = 0;
		
		points.Add(new Point3D(zero.X, zero.Y, zero.Z + 10));
		points.Add(new Point3D(zero.X, zero.Y, zero.Z));
		points.Add(new Point3D(zero.X + size, zero.Y, zero.Z));
		points.Add(new Point3D(zero.X + size, zero.Y + size, zero.Z));
		points.Add(new Point3D(zero.X, zero.Y + size, zero.Z));
		points.Add(new Point3D(zero.X, zero.Y, zero.Z));
		points.Add(new Point3D(zero.X, zero.Y, zero.Z + 10));
		waitCounter = points.Count;
		received = "";
		foreach (Point3D point in points)
		{
			go_to_position(point, 5000);
		}
		int waiter = 0;
		while(waitCounter !=0 && waiter < 10 * 10)
		{
			waiter++;
			Thread.Sleep(100);
			Console.WriteLine("Wait");
		}


	}


	public void touchAll(Module m)
	{
		List<Point3D> points = new List<Point3D>();
		okCounter = 0;

		



		//waitCounter = points.Count;
		received = "";
		foreach (Point3D point in m.points)
		{
			Point3D tmp_point1 = new Point3D(point.X, point.Y, m.max_h);
			//mp_point1 = point.;
			//tmp_point1.Z = m.max_h;
			waitCounter = 3;
			go_to_position(tmp_point1, 5000);
			go_to_position(point, 5000);
			go_to_position(tmp_point1, 5000);
			int waiter = 0;
			
			while (waitCounter != 0 && waiter < 10 * 10)
			{
				waiter++;
				Thread.Sleep(10);
				//Console.WriteLine("Wait");
			}
		}
		


	}


	public void printZones()
	{
		foreach(Zone zone in zones)
		{
			float zeroH = 5.5f;
			Point3D zeroPoint = new Point3D(zone.zero_coord.X, zone.zero_coord.Y, zeroH);
			printSquare(zeroPoint, zone.size);


		}
	}

	//public bool load_items(string path_to_settings)
	//{

	//	List<string> lines = new List<string>();
	//	string[] tmp_lines = File.ReadAllLines(path_to_settings + "zones.csv", Encoding.GetEncoding(1251));
	//	if (load_file(path_to_settings + "items.csv", ref lines))
	//	{
	//		for (int i = 1; i < lines.Count; i++)
	//		{
	//			string path = "C:/Users/semen/OneDrive/Pictures/chem_images/";
	//			Module2 a = new Module2(path, lines[i], lines[0]);
	//			switch (a.type){
	//				case "nose_tablet":
	//					TipModules.Add(a);
	//					break;
	//				case "Source":
	//					TubeModules.Add(a);
	//					break;
	//				case "probe_tablet":
	//					WellPlateModules.Add(a);
	//					break;
	//				case "drop_container":
	//					DropModules.Add(a);
	//					break;
	//				default:
	//					Console.WriteLine("Module: " + a.moduleName);
	//					Console.WriteLine("Unknown type of module: " + a.type);
	//					break;


	//		}
	//			modules.Add(a);

	//		}
	//		load_zones(path_to_settings);
	//		return true;
	//	}
	//	else
	//	{
	//		return false;
	//	}



	//}

	public bool load_zones(string path_to_settings)
	{
		List<string> lines = new List<string>();
		if (load_file(path_to_settings + "zones.csv", ref lines))
		{
			zones = new Zone[lines.Count - 1];

			for (int i = 1; i < lines.Count; i++)
			{
				Zone tmp_zone = new Zone();
				string[] tmp_array = lines[i].Split(new string[] { ";" }, StringSplitOptions.None);
				string[] tmp_array_2 = tmp_array[1].Split(new string[] { "," }, StringSplitOptions.None);
				tmp_zone.zero_coord.X = float.Parse(tmp_array_2[0]);
				tmp_zone.zero_coord.Y = float.Parse(tmp_array_2[1]);
				tmp_zone.size = float.Parse(tmp_array[2]);

				tmp_zone.active = false;
				zones[i - 1] = tmp_zone;
				//zones.Add(tmp_zone);

			}
			return true;
		}
		else
		{
			return false;
		}
	}

	public void updateStatus(String new_data)
	{
		received += new_data;



		int index = received.IndexOf("ok\n");

		while (index != -1)
		{
	
			waitCounter -= 1;
			okCounter++;
			received = received.Remove(index, "ok\n".Length);
			index = received.IndexOf("ok\n");
		}

		index = received.IndexOf("echo: busy: processing\n");
		while (index != -1)
		{
			received = received.Remove(index, "echo: busy: processing\n".Length);
			index = received.IndexOf("echo: busy: processing\n");
		}

		//bool done = false;
		int code;
		while((code = getCode()) != -1)
		{
			int start_index = received.IndexOf("S_XYZ:");
			
			Console.WriteLine("Code: " + code.ToString());
			Thread.Sleep(50);
		}






	}



	private int getCode()
	{
		int index = received.IndexOf("S_XYZ:");
		if (index != -1)
		{
			int start_index = index;
			string sub = received.Substring(index + "S_XYZ:".Length, received.Length - (index + "S_XYZ:".Length));
			index = sub.IndexOf("\n");
			if (index != -1)
			{
				sub = sub.Substring(0, index);
				int code = Convert.ToInt32(sub);
				//Console.WriteLine("Code is: " + code.ToString());
				int len = "S_XYZ:".Length + code.ToString().Length + 1;
				received = received.Remove(start_index, len);

				return code;
			}
		}
		else
		{
			return -1;
		}
		return -1;
	}



	public bool load_file(string path_to_file, ref List<string> lines)
	{
		lines.Clear();
		Console.WriteLine("Reading file: " + path_to_file);
		try
		{
			string[] tmp_lines = File.ReadAllLines(path_to_file, Encoding.GetEncoding(1251));
			if(tmp_lines.Length > 0)
			{

				lines.AddRange(tmp_lines);
				Console.WriteLine("done");
				return true;
			}
			else
			{
				Console.WriteLine("File (" + path_to_file + ") is empty.");
				return false;
			}
			
		}
		catch
		{
			Console.WriteLine("Some problems with file: " + path_to_file);
			return false;
		}

	}

	public bool sendSafely(string message)
	{
		if (port.IsOpen)
		{
			okCounter = 0;
			port.WriteLine(message);

			bool good = false;
			string r = "";
			while (!good)
			{
				r = port.ReadExisting();
				int error = r.IndexOf("echo:Unknown command:");
				if (error == -1)
				{

				}
				return false;
			}
		}
		return true;

	}

	public Bitmap drawImageFromData(Module module)
	{
		Bitmap image = new Bitmap(900, 600);
		//Image image = new Image(128, 128);
		Graphics fig;

		
		fig = Graphics.FromImage(image);
		Pen p = new Pen(Color.Green);
		Pen myPen = new Pen(Brushes.LightGray);

		myPen.Width = 5.0f;

		// Set the LineJoin property
		//myPen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
		

		// Draw the rectangle
		//fig.DrawRectangle(myPen, new Rectangle(0, 0, 900, 600));
		fig.DrawRoundedRectangle(myPen, new Rectangle(0, 0, 900, 600), 100);





		for(int i = 0; i < module.gridElements.X; i++)
		{
			for (int q = 0; q < module.gridElements.Y; q++)
			{
				float ppm = module.ppm;
				Rectangle position = new Rectangle();
				position.X = (int)(module.zeroCoord.X * module.ppm);
				position.Y = (int)(module.zeroCoord.Y * module.ppm);
				position.Width = (int)(module.diameter * module.ppm);
				position.Height = (int)(module.diameter * module.ppm);
				position.X += (int)(i * module.gridStep.X * ppm);
				position.Y += (int)(q * module.gridStep.Y * ppm);
				fig.DrawEllipse(myPen, position);
			}
		}




		return image;
	}





	public class module_params
	{
		public int id { get; set; }
		public string type { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public string  image_name{ get; set; }
		public float min_h  { get; set; }
		public float max_h { get; set; }
		public float diameter { get; set; }
		public string zeroCoord { get; set; }
		public string gridElements { get; set; }
		public string gridStep { get; set; }


	}


	public Module loadModule(string pathToFile)
	{

		try
		{
			string output = File.ReadAllText(pathToFile);
			Console.WriteLine(output);
			Module test = JsonConvert.DeserializeObject<Module>(output);
			if (test.type == "nose_tablet" || test.type == "probe_tablet")
			{
				test.fillPoints(new PointF(0, 0));
				test.drawImageFromData();
			}
			//File.WriteAllText(pathToFile + "/" + module.name + ".json", output);
			return test;
		}
		catch
		{
			Console.WriteLine("Some error with file:" + pathToFile);
		}
		Module test1 = new Module();
		return test1;
	}


	public void saveModuleToJson(Module module, string pathToFile)
	{

		string output = JsonConvert.SerializeObject(module);
		Console.WriteLine(output);
		Module test =  JsonConvert.DeserializeObject<Module>(output);
		File.WriteAllText(pathToFile + "/" + module.name + ".json",output);

	}


	public void printModule(Module module)
	{
		Module test = module;



		string jsonString = JsonConvert.SerializeObject(test);
		File.WriteAllText(@"D:\Downloads\test.json", jsonString);
		Console.WriteLine(jsonString);

		Module test2 = JsonConvert.DeserializeObject<Module>(jsonString);
		int u = 0;


		//Robot.Module testModule;
		//JsonSerializer serializer = new JsonSerializer();
		//testModule = (Module)serializer.Deserialize(file, typeof(Movie));
		//testModule =  JsonConvert.DeserializeObject<List<Item>>(json);
	}



	public void saveModulesToFiles(string pathToFolder)
	{


		for(int i = 0; i < modules.Count; i++)
		{
			Module tmp = modules[i];
			Console.WriteLine(pathToFolder + tmp.name + ".json");
			saveModuleToJson(tmp, pathToFolder);

		}


	}



	public bool loadItems(string pathToFolder)
	{
		string[] files = System.IO.Directory.GetFiles(pathToFolder, "*.json");

		try
		{

			foreach (string file in files)
			{
				Module tmp = loadModule(file);// new Module(file);
				modules.Add(tmp);



				switch (tmp.type)
				{
					case "nose_tablet":
						TipModules.Add(tmp);
						break;
					case "Source":
						TubeModules.Add(tmp);
						break;
					case "probe_tablet":
						WellPlateModules.Add(tmp);
						break;
					case "drop_container":
						DropModules.Add(tmp);
						break;
					default:
						Console.WriteLine("Module: " + tmp.name);
						Console.WriteLine("Unknown type of module: " + tmp.type);
						break;


				}




			}
			load_zones(pathToFolder);

			return true;
		}
		catch
		{
			Console.WriteLine("Some errors while reading files from: " + pathToFolder);
			return false;
		}


	}



}
