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
    public partial class ModuleEditor : UserControl
    {

        public Robot.Module module;

        public ModuleEditor()
        {
            InitializeComponent();



            sizesPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            hightPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            rowsColsPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            diameterPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            depthPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            spacePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            offsetPicture.SizeMode = PictureBoxSizeMode.StretchImage;



            sizesPicture.Image = chem_robot_test.Properties.Resources.expl_sizes;
            hightPicture.Image = chem_robot_test.Properties.Resources.expl_hight;
            rowsColsPicture.Image = chem_robot_test.Properties.Resources.expl_rows_cols;
            diameterPicture.Image = chem_robot_test.Properties.Resources.expl_diam;
            depthPicture.Image = chem_robot_test.Properties.Resources.expl_depth;
            spacePicture.Image = chem_robot_test.Properties.Resources.expl_dist;
            offsetPicture.Image = chem_robot_test.Properties.Resources.expl_offset;

           //     Image = chem_robot_test.Properties.Resources.add;





        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            module = new Robot.Module();
            module.size = new PointF((float)lenghtBox.Value, (float)widthBox.Value);
            module.diameter = (float)diameterBox.Value;
            module.gridElements = new Point((int)colsBox.Value, (int)rowsBox.Value);
            module.gridStep = new PointF((float)xSpaceBox.Value, (float)ySpaceBox.Value);
            module.zeroCoord = new PointF((float)xOffsetBox.Value, (float)yOffsetBox.Value);
            module.max_h = (float)heightBox.Value;
            module.min_h = (float)depthBox.Value;
            module.fillPoints(new PointF(0, 0));
            module.drawImageFromData();
            imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox.Image = module.Image;


        }


        public void showModuledata(Robot.Module m)
        {
            module = m;
            lenghtBox.Value = (decimal)m.size.X;
            widthBox.Value = (decimal)m.size.Y;
            diameterBox.Value = (decimal)m.diameter;
            colsBox.Value = m.gridElements.X;
            rowsBox.Value = m.gridElements.Y;
            xSpaceBox.Value = (decimal)m.gridStep.X;
            ySpaceBox.Value = (decimal)m.gridStep.Y;
            xOffsetBox.Value = (decimal)m.zeroCoord.X;
            yOffsetBox.Value = (decimal)m.zeroCoord.Y;
            imageBox.Image = m.Image;
            nameBox.Text = m.name;
            descriptionBox.Text = m.description;



        }






    }
}
