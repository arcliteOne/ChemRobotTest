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
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;


namespace chem_robot_test
{


    public partial class Form1 : Form
    {
        Robot robot;
        SerialPort port = new SerialPort();
        PictureBox[] zones = new PictureBox[10];
        int selected_zone = -1;
        List<string> moduleNames = new List<string>();
        //List<Dictionary<int, string>>
        //ModulesMenu menu = new ModulesMenu();


        public Form1()
        {
            InitializeComponent();
            robot = new Robot();
            zones = new PictureBox[] { Zone_1, Zone_2, Zone_3, Zone_4, Zone_5, Zone_6, Zone_7, Zone_8, Zone_9, Zone_10 };
            //splitContainer1.Panel1Collapsed = true;
            foreach (PictureBox pic in zones)
            {
                pic.ContextMenuStrip = workplaceMenu;//Zone_1.ContextMenuStrip = workplaceMenu;
            }


            Bitmap workzoneImage = new Bitmap(640, 256);
            robot.loadItems("C:/Users/semen/OneDrive/Pictures/chem_images/modules/");
            itemsMenu.Hide();
            itemsMenu.Location = new Point(45, 42);
            
            loadItems();
            //robot.saveModulesToFiles("C:/Users/semen/OneDrive/Pictures/chem_images/modules/");
            setupZoneImages();
            itemsMenu.BringToFront();
            liquidDataPanel.LiquidAdded += addLiquid;
            liquidDataPanel.LiquidRemoved += removeLiquid;

        }


        private void setupZoneImages()
        {
            foreach(PictureBox pic in zones)
            {
                pic.MouseEnter += showOverlayImage;
                pic.MouseLeave += hideOverlayImage;
                pic.MouseClick += showModuleTypes;
            }
        }

        private void loadItems()
        {
            itemsMenu.itemsTree.NodeMouseHover += itemsTree_MouseHover;
            itemsMenu.ModuleSelected += setModule;
            TreeNode tips = new TreeNode("Носики");
            foreach (Robot.Module m in robot.TipModules)
            {
                //TreeNode tmp = new TreeNode(m.moduleName);
                TreeNode node = tips.Nodes.Add(m.name);
                node.Tag = m;
                node.ToolTipText = m.description;
                //itemsMenu.itemsTree.Nodes.Add(tmp);
            }
            itemsMenu.itemsTree.Nodes.Add(tips);

            TreeNode tubes = new TreeNode("Ёмкости");
            foreach (Robot.Module m in robot.TubeModules)
            {
                TreeNode node = tubes.Nodes.Add(m.id.ToString(), m.name);
                node.Tag = m;
                node.ToolTipText = m.description;
            }
            itemsMenu.itemsTree.Nodes.Add(tubes);

            TreeNode plates = new TreeNode("Пробирки");
            foreach (Robot.Module m in robot.WellPlateModules)
            {
                TreeNode node = plates.Nodes.Add(m.id.ToString(), m.name);
                node.ToolTipText = m.description;
                node.Tag = m;
            }
            itemsMenu.itemsTree.Nodes.Add(plates);

            TreeNode drops = new TreeNode("Сброс");
            foreach (Robot.Module m in robot.DropModules)
            {
                TreeNode node = drops.Nodes.Add(m.id.ToString(), m.name);
                node.ToolTipText = m.description;
                node.Tag = m;
            }
            itemsMenu.itemsTree.Nodes.Add(drops);

            //itemsMenu.itemsTree.NodeMouseDoubleClick += itemsTree_NodeMouseDoubleClick;
            //itemsMenu.itemsTree.clo
            foreach (TreeNode tn in itemsMenu.itemsTree.Nodes)
            {



                TreeNode node = new TreeNode(tn.Text, tn.ImageIndex, tn.SelectedImageIndex);
                node.Tag = tn.Tag;
                //editorTreeView.Nodes.Add(node);
                foreach(TreeNode t in tn.Nodes)
                {
                    TreeNode second_node = new TreeNode(t.Text, t.ImageIndex, t.SelectedImageIndex);
                    second_node.Tag = t.Tag;
                    node.Nodes.Add(second_node);
                   
                }
                editorTreeView.Nodes.Add(node);
                //parent.Nodes.Add(newTn);
                //CopyChildren(newTn, tn);
            }

            //itemsMenuForEditor =  itemsMenu;// = &itemsMenu;
            //itemsMenu.itemsTree.Nodes.CopyTo(itemsMenuForEditor.itemsTree, 0);
            //itemsMenu.itemsTree.Nodes.CopyTo
        }

        public void showModulesList(object sender, EventArgs e)
        {

        }




        ~Form1(){
            Console.WriteLine("FINISH");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            robot.port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            //ItemsPanel.Visible = false;

        }

        private void select_item(int zone_num)
        {

        }

        private void ports_refresh_timer_Tick(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            string current_port = "";
            if (comboBox1.SelectedIndex != -1) { 
            current_port = comboBox1.SelectedItem.ToString();
            }
            comboBox1.Items.Clear();
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
            if(comboBox1.Items.IndexOf(current_port) != -1)
            {
                comboBox1.SelectedItem = current_port;
            }
            if (robot.port.IsOpen)
            {
                send.BackColor = Color.GreenYellow;
                
            }
            else
            {
                send.BackColor = Color.Transparent;
            }


            if (robot.port.IsOpen)
            {

                string tmp = robot.port.ReadExisting();
                //string tmp = robot.port.ReadLine();
                

                if (tmp.Length != 0)
                {
                    Console.WriteLine(tmp);
                }
            }

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() != "")
            {
                robot.connect_nonblock(comboBox1.SelectedItem.ToString());
            }
        }




        private void send_Click(object sender, EventArgs e)
        {

 
                
            

            if (robot.send(SendBox.Text))
            {

                SendBox.Clear();
            }
        }
        private void print_data(object sender, SerialDataReceivedEventHandler e)
        {
            string tmp = robot.port.ReadExisting().ToString();
            ReceiveBox.AppendText(tmp);
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            
            string tmp = robot.port.ReadExisting().ToString();
            ReceiveBox.Invoke(new Action(() => ReceiveBox.AppendText(tmp)));
            robot.updateStatus(tmp);
 

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            robot.go_home();
        }

        private void rateBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void flipButton_Click(object sender, EventArgs e)
        {

            new Thread(() =>
            {
                robot.printZones();
            }).Start();
            
  
        }




        private void выбратьЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //splitContainer1.Panel1Collapsed = false;
            selected_zone = Array.IndexOf(zones, ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl);
            Console.WriteLine(selected_zone);
           




        }



        private void selectItemCancelButton_Click(object sender, EventArgs e)
        {
            
            //splitContainer1.Panel1Collapsed = true;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void удалитьЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected_zone = Array.IndexOf(zones, ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl);
            Console.WriteLine(selected_zone);
            robot.zones[selected_zone].active = false;
            refreshWorkzonImage();
            

        }
        private void refreshWorkzonImage()
        {
            for(int i = 0; i < zones.Length; i++)
            {
                if (robot.zones[i].active)
                {
                    zones[i].Image = robot.zones[i].module.Image;
                    zones[i].SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    zones[i].Image = null;
                }
            }
        }

        private void touchAllButton_Click(object sender, EventArgs e)
        {
            robot.touchAll(robot.zones[selected_zone].module);
            //splitContainer1.Panel1Collapsed = true;
        }

        private void selectItemCancelButton_Click_1(object sender, EventArgs e)
        {
            //splitContainer1.Panel1Collapsed = true;
           // TipsContainer.col
        }

        public void showModuleTypes(object sender, MouseEventArgs e)
        {


            itemsMenu.Show();


            ////TubeCombobox.Font = new System.Drawing.Font(TubeCombobox.Text, 14);
            //int current_zone = Array.IndexOf(zones, (sender as PictureBox));
            //PictureBox currentBox = (sender as PictureBox);
            //Point newLocation = new Point(900 , 300);
            //Console.WriteLine(currentBox.Location.ToString());
            //Console.WriteLine(Form1.MousePosition.ToString());


            //if (robot.zones[current_zone].active == false)
            //{
            //    //splitContainer1.Panel1Collapsed = false;
            //    selected_zone = current_zone;
                
            //    ItemsPanel.Location = newLocation;// (sender as PictureBox).Location;
            //    ItemsPanel.Visible = true;
            //    (sender as PictureBox).Image = chem_robot_test.Properties.Resources.add;
            //    //(sender as PictureBox).Image.
            //    //ItemsPanel.Site = (sender as PictureBox).Site;
            //    //ItemsPanel.Location = new Point(750, 200);// (sender as PictureBox).Location;
            //}
            //else { }

        }

        private void showOverlayImage(object sender, EventArgs e)
        {
            PictureBox tmp = sender as PictureBox;
            selected_zone = Array.IndexOf(zones, tmp);
            int current_zone = Array.IndexOf(zones, (sender as PictureBox));

            if (robot.zones[current_zone].active == false)
            {
                (sender as PictureBox).Image = chem_robot_test.Properties.Resources.add;

            }
            else { }
        }
        private void hideOverlayImage(object sender, EventArgs e)
        {
            int current_zone = Array.IndexOf(zones, (sender as PictureBox));

            if (robot.zones[current_zone].active == false)
            {
                (sender as PictureBox).Image = null;

            }

        }



    



        private void itemsTree_MouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Node.ToolTipText))
            {
                //toolTip1.Show(e.Node.ToolTipText, itemsMenu.itemsTree);
                //toolTip1.SetToolTip(itemsMenu.itemsTree, e.Node.ToolTipText);
            }
        }

        private void itemsTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                TreeView tree = sender as TreeView;
                //int id = Convert.ToInt32(itemsTree.SelectedNode.Tag.ToString());
                if (tree.SelectedNode.Tag != null)
                {
                    int id = ((Robot.Module)tree.SelectedNode.Tag).id;
                    Console.WriteLine("Selected id: " + id);
                }
            }
            catch
            {
                Console.WriteLine("Something went wrong");
            }
        }

        private void setModule()
        {
            itemsMenu.Hide();
       
            robot.zones[selected_zone].module = itemsMenu.selectedModule;
            robot.zones[selected_zone].module.fillPoints(robot.zones[selected_zone].zero_coord);
            robot.zones[selected_zone].active = true;

            refreshWorkzonImage();
           // robot.zones[selected_zone].module = robot.modules.Where(g => g.id == moduleId).First();

        }
        public void addLiquid()
        {
            int index = robot.liquids.FindIndex(L => L.id == liquidDataPanel.liquid.id);
            //int index = robot.liquids.IndexOf(liquidDataPanel.liquid.id );
            if (index != -1)
            {
                robot.liquids[index] = liquidDataPanel.liquid;
            }
            else
            {
                robot.liquids.Add(liquidDataPanel.liquid);
            }
                updateLiquids();
            liquidDataPanel.Hide();
        }
        public void removeLiquid()
        {
            int index = robot.liquids.FindIndex(L => L.id == liquidDataPanel.liquid.id);
            if (index != -1)
            {
                robot.liquids.RemoveAt(index);
            }
            updateLiquids();
            liquidDataPanel.Hide();
        }




        private void updateLiquids()
        {
            //liquidsPanel.RowCount = 0;
            liquidsPanel.Controls.Clear();
            liquidsPanel.RowCount = robot.liquids.Count + 1;
            TableLayoutRowStyleCollection styles =
            this.liquidsPanel.RowStyles;
            for (int i = 0; i < robot.liquids.Count; i++)
            {

                //Label tmp = new Label();
                Button tmp = new Button();
                tmp.Click += liquidDataPanel.edit;
                tmp.Tag = robot.liquids[i];
                tmp.Text = robot.liquids[i].name;
                tmp.TextAlign = ContentAlignment.MiddleCenter;
                tmp.AutoSize = false;
                tmp.Dock = DockStyle.Fill;
                liquidsPanel.Controls.Add(tmp, 0, i);
                //liquidsPanel.Controls.Add(new Label() { Text = robot.liquids[i].name}, 0, i) ;
                liquidsPanel.Controls.Add(new PictureBox() { BackColor = robot.liquids[i].color }, 1, i);
                //panel.Controls.Add(new Label() { Text = "Address" }, 1, 0);
                //panel.Controls.Add(new Label() { Text = "Address" }, 1, 0);


            }
            foreach (RowStyle style in styles)
            {


                    // Set the row height to 50 pixels.  
                    style.SizeType = SizeType.Absolute;
                    style.Height = 50;
                
            }



            //TableLayoutPanel panel = new TableLayoutPanel();
            //panel.ColumnCount = 3;
            //panel.RowCount = 1;
            //panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            //panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            //panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            //panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            //panel.Controls.Add(new Label() { Text = "Address" }, 1, 0);
            //panel.Controls.Add(new Label() { Text = "Contact No" }, 2, 0);
            //panel.Controls.Add(new Label() { Text = "Email ID" }, 3, 0);

        }

        private void addLiquidButton_Click(object sender, EventArgs e)
        {
            robot.printModule(robot.modules[0]);
            liquidDataPanel.createNewLiquid();

            Bitmap tmp = robot.drawImageFromData(robot.modules[0]);
            pictureBox1.Image = tmp;

            //liquidsPanel.RowCount = liquidsPanel.RowCount += 1;
            
            //liquidsPanel.Controls.Add(new Label() { Text = liquidsPanel.RowCount.ToString() }, 0, liquidsPanel.RowCount - 1);


            //liquidsPanel.RowCount = liquidsPanel.RowCount += 1;
            //liquidDataPanel.Controls.Add(new Label() { Text = liquidsPanel.RowCount.ToString() });
        }

        private void editorTreeView_MouseClick(object sender, MouseEventArgs e)
        {
            
            TreeView tree = sender as TreeView;
            if (tree.SelectedNode != null)
            {
                if (tree.SelectedNode.Tag != null)
                {
                    Robot.Module tmp_module = (Robot.Module)tree.SelectedNode.Tag;
                    moduleEditor1.showModuledata(tmp_module);
                }
            }
        }
    }

}






