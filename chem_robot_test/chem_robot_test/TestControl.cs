using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chem_robot_test
{
    public partial class TestControl : UserControl
    {
        public Robot.Module selectedModule;
        public delegate void Method();
        public event Method ModuleSelected;
        public TestControl()
        {
            InitializeComponent();
            splitContainer1.Panel2Collapsed = true;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            itemsTree.HotTracking = true;
        }

        private void itemsTree_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {

            TreeNode node = e.Node;

            if (node.Tag != null)
            {
                showToolTip((Robot.Module)node.Tag);
            }
 
        }

  



        public void showToolTip(Robot.Module module)
        {
            splitContainer1.Panel2Collapsed = false;
            ModuleNameTextBox.Text = module.name;
            descriptionTextBox.Text = module.description;
            moduleImage.Image = module.Image;
            moduleImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void hideToolTip(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
        }
        public void updateToolTip(object sender, EventArgs e)
        {
            if(itemsTree.SelectedNode == null || itemsTree.SelectedNode.Tag == null)
            {
                splitContainer1.Panel2Collapsed = true;
            }
            else
            {
                showToolTip((Robot.Module)itemsTree.SelectedNode.Tag);
            }
            
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            if (itemsTree.SelectedNode != null && itemsTree.SelectedNode.Tag != null)
            {
                itemsTree.CollapseAll();
                ModuleSelected();
                itemsTree.SelectedNode = null;
                splitContainer1.Panel2Collapsed = true;
            }
        }

        private void itemsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                selectedModule = (Robot.Module)e.Node.Tag;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            itemsTree.CollapseAll();
            itemsTree.SelectedNode = null;
            splitContainer1.Panel2Collapsed = true;
        }
    }
}
