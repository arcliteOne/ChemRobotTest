using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chem_robot_test.CustomControls
{
    public partial class LiquidDataPanel : UserControl
    {


        public delegate void Method();
        public event Method LiquidAdded;
        public event Method LiquidRemoved;

        public Robot.liquid liquid;
        int currentId = 0;

        public LiquidDataPanel()
        {
            InitializeComponent();
        }

        private void addLiquidButton_Click(object sender, EventArgs e)
        {
            if (liquidNameBox.Text != "")
            {
                liquid.name = liquidNameBox.Text;
                liquidNameBox.Text = null;
                liquid.description = liquidDescriptionBox.Text;
                liquidDescriptionBox.Text = null;
                if (liquid.color == Color.Transparent)
                {
                    Random randonGen = new Random();
                    Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));

                    liquid.color = randomColor;
                }
                LiquidAdded();
                liquid.clear();
            }




        }

        public void edit(object sender, EventArgs e)
        {
            Button tmp = sender as Button;
            liquid = (Robot.liquid)tmp.Tag;
            showData();
            Show();

           

        }
        private void showData()
        {
            liquidNameBox.Text = liquid.name;
            liquidDescriptionBox.Text = liquid.description;
            colorBox.BackColor = liquid.color;
            //liquid.color = Color.Transparent;
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            liquid.color = colorDialog1.Color;
            colorBox.BackColor = liquid.color;
            Console.WriteLine("Color = " + liquid.color.ToString());
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            liquidNameBox.Text = null;
            liquidDescriptionBox.Text = null;
            liquid.color = Color.Transparent;
            Hide();
        }

        public void createNewLiquid()
        {
            Show();
            Random randonGen = new Random();
            Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));
            liquidNameBox.Text = null;
            liquidDescriptionBox.Text = null;
            liquid.color = randomColor;
            liquid.id = currentId;
            currentId++;
            colorBox.BackColor = liquid.color;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            LiquidRemoved();
        }
    }
}
