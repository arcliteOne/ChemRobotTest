namespace chem_robot_test
{
    partial class TestControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.itemsTree = new System.Windows.Forms.TreeView();
            this.okButton = new System.Windows.Forms.Button();
            this.toolTipPanel = new System.Windows.Forms.Panel();
            this.ModuleNameTextBox = new System.Windows.Forms.RichTextBox();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.moduleImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolTipPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moduleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.toolTipPanel);
            this.splitContainer1.Panel2MinSize = 390;
            this.splitContainer1.Size = new System.Drawing.Size(852, 383);
            this.splitContainer1.SplitterDistance = 418;
            this.splitContainer1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.itemsTree);
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 376);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список доступных модулей";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(334, 341);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // itemsTree
            // 
            this.itemsTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemsTree.Location = new System.Drawing.Point(21, 44);
            this.itemsTree.Name = "itemsTree";
            this.itemsTree.Size = new System.Drawing.Size(388, 291);
            this.itemsTree.TabIndex = 3;
            this.itemsTree.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.itemsTree_NodeMouseHover);
            this.itemsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.itemsTree_AfterSelect);
            this.itemsTree.MouseLeave += new System.EventHandler(this.updateToolTip);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(253, 341);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // toolTipPanel
            // 
            this.toolTipPanel.BackColor = System.Drawing.Color.White;
            this.toolTipPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolTipPanel.Controls.Add(this.ModuleNameTextBox);
            this.toolTipPanel.Controls.Add(this.descriptionTextBox);
            this.toolTipPanel.Controls.Add(this.moduleImage);
            this.toolTipPanel.Location = new System.Drawing.Point(3, 47);
            this.toolTipPanel.Name = "toolTipPanel";
            this.toolTipPanel.Size = new System.Drawing.Size(330, 211);
            this.toolTipPanel.TabIndex = 0;
            // 
            // ModuleNameTextBox
            // 
            this.ModuleNameTextBox.BackColor = System.Drawing.Color.White;
            this.ModuleNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModuleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModuleNameTextBox.Location = new System.Drawing.Point(4, 3);
            this.ModuleNameTextBox.Name = "ModuleNameTextBox";
            this.ModuleNameTextBox.Size = new System.Drawing.Size(273, 80);
            this.ModuleNameTextBox.TabIndex = 6;
            this.ModuleNameTextBox.Text = "";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.White;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Location = new System.Drawing.Point(194, 89);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(124, 117);
            this.descriptionTextBox.TabIndex = 1;
            this.descriptionTextBox.Text = "";
            // 
            // moduleImage
            // 
            this.moduleImage.Location = new System.Drawing.Point(4, 89);
            this.moduleImage.Name = "moduleImage";
            this.moduleImage.Size = new System.Drawing.Size(184, 119);
            this.moduleImage.TabIndex = 0;
            this.moduleImage.TabStop = false;
            // 
            // TestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.splitContainer1);
            this.Name = "TestControl";
            this.Size = new System.Drawing.Size(880, 505);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolTipPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moduleImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.TreeView itemsTree;
        public System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Panel toolTipPanel;
        private System.Windows.Forms.RichTextBox ModuleNameTextBox;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox moduleImage;
    }
}
