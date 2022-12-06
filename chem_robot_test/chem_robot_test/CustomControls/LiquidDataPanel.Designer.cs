namespace chem_robot_test.CustomControls
{
    partial class LiquidDataPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.liquidNameBox = new System.Windows.Forms.TextBox();
            this.liquidDescriptionBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addLiquidButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorButton = new System.Windows.Forms.Button();
            this.colorBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Подробности";
            // 
            // liquidNameBox
            // 
            this.liquidNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.liquidNameBox.Location = new System.Drawing.Point(11, 94);
            this.liquidNameBox.Name = "liquidNameBox";
            this.liquidNameBox.Size = new System.Drawing.Size(197, 31);
            this.liquidNameBox.TabIndex = 1;
            // 
            // liquidDescriptionBox
            // 
            this.liquidDescriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.liquidDescriptionBox.Location = new System.Drawing.Point(238, 94);
            this.liquidDescriptionBox.Name = "liquidDescriptionBox";
            this.liquidDescriptionBox.Size = new System.Drawing.Size(200, 31);
            this.liquidDescriptionBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Описание:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(268, 243);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addLiquidButton
            // 
            this.addLiquidButton.Location = new System.Drawing.Point(363, 243);
            this.addLiquidButton.Name = "addLiquidButton";
            this.addLiquidButton.Size = new System.Drawing.Size(75, 23);
            this.addLiquidButton.TabIndex = 6;
            this.addLiquidButton.Text = "Сохранить";
            this.addLiquidButton.UseVisualStyleBackColor = true;
            this.addLiquidButton.Click += new System.EventHandler(this.addLiquidButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(14, 243);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(46, 131);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(102, 23);
            this.colorButton.TabIndex = 8;
            this.colorButton.Text = "Выбрать цвет";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(14, 131);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(26, 23);
            this.colorBox.TabIndex = 9;
            this.colorBox.TabStop = false;
            // 
            // LiquidDataPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addLiquidButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.liquidDescriptionBox);
            this.Controls.Add(this.liquidNameBox);
            this.Controls.Add(this.label1);
            this.Name = "LiquidDataPanel";
            this.Size = new System.Drawing.Size(460, 308);
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox liquidNameBox;
        private System.Windows.Forms.TextBox liquidDescriptionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addLiquidButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.PictureBox colorBox;
    }
}
