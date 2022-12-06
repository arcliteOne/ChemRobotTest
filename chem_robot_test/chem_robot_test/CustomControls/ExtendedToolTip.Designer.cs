namespace chem_robot_test.CustomControls
{
    partial class ExtendedToolTip
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
            this.moduleImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.moduleName = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.moduleImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // moduleImage
            // 
            this.moduleImage.Location = new System.Drawing.Point(3, 69);
            this.moduleImage.Name = "moduleImage";
            this.moduleImage.Size = new System.Drawing.Size(168, 116);
            this.moduleImage.TabIndex = 0;
            this.moduleImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.moduleName);
            this.panel1.Controls.Add(this.moduleImage);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 195);
            this.panel1.TabIndex = 1;
            // 
            // moduleName
            // 
            this.moduleName.AutoSize = true;
            this.moduleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moduleName.Location = new System.Drawing.Point(3, 12);
            this.moduleName.Name = "moduleName";
            this.moduleName.Size = new System.Drawing.Size(188, 25);
            this.moduleName.TabIndex = 1;
            this.moduleName.Text = "Название модуля";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Location = new System.Drawing.Point(177, 69);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(147, 116);
            this.descriptionTextBox.TabIndex = 3;
            this.descriptionTextBox.Text = "";
            // 
            // ExtendedToolTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ExtendedToolTip";
            this.Size = new System.Drawing.Size(327, 195);
            ((System.ComponentModel.ISupportInitialize)(this.moduleImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox moduleImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Label moduleName;
    }
}
