namespace chem_robot_test
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ports_refresh_timer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.workplaceMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выбратьЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настроитьЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flipButton = new System.Windows.Forms.Button();
            this.ReceiveBox = new System.Windows.Forms.RichTextBox();
            this.send = new System.Windows.Forms.Button();
            this.SendBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.liquidsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addLiquidButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Zone_1 = new System.Windows.Forms.PictureBox();
            this.Zone_10 = new System.Windows.Forms.PictureBox();
            this.Zone_9 = new System.Windows.Forms.PictureBox();
            this.Zone_8 = new System.Windows.Forms.PictureBox();
            this.Zone_2 = new System.Windows.Forms.PictureBox();
            this.Zone_7 = new System.Windows.Forms.PictureBox();
            this.Zone_6 = new System.Windows.Forms.PictureBox();
            this.Zone_5 = new System.Windows.Forms.PictureBox();
            this.Zone_3 = new System.Windows.Forms.PictureBox();
            this.Zone_4 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.editorTreeView = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.liquidDataPanel = new chem_robot_test.CustomControls.LiquidDataPanel();
            this.itemsMenu = new chem_robot_test.TestControl();
            this.moduleEditor1 = new chem_robot_test.CustomControls.ModuleEditor();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workplaceMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_4)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ports_refresh_timer
            // 
            this.ports_refresh_timer.Enabled = true;
            this.ports_refresh_timer.Interval = 1000;
            this.ports_refresh_timer.Tick += new System.EventHandler(this.ports_refresh_timer_Tick);
            // 
            // workplaceMenu
            // 
            this.workplaceMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьЭлементToolStripMenuItem,
            this.настроитьЭлементToolStripMenuItem,
            this.удалитьЭлементToolStripMenuItem});
            this.workplaceMenu.Name = "workplaceMenu";
            this.workplaceMenu.Size = new System.Drawing.Size(182, 70);
            // 
            // выбратьЭлементToolStripMenuItem
            // 
            this.выбратьЭлементToolStripMenuItem.Name = "выбратьЭлементToolStripMenuItem";
            this.выбратьЭлементToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.выбратьЭлементToolStripMenuItem.Text = "Выбрать элемент";
            this.выбратьЭлементToolStripMenuItem.Click += new System.EventHandler(this.выбратьЭлементToolStripMenuItem_Click);
            // 
            // настроитьЭлементToolStripMenuItem
            // 
            this.настроитьЭлементToolStripMenuItem.Name = "настроитьЭлементToolStripMenuItem";
            this.настроитьЭлементToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.настроитьЭлементToolStripMenuItem.Text = "Настроить элемент";
            // 
            // удалитьЭлементToolStripMenuItem
            // 
            this.удалитьЭлементToolStripMenuItem.Name = "удалитьЭлементToolStripMenuItem";
            this.удалитьЭлементToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.удалитьЭлементToolStripMenuItem.Text = "Удалить элемент";
            this.удалитьЭлементToolStripMenuItem.Click += new System.EventHandler(this.удалитьЭлементToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1495, 854);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1487, 828);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Подключение";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(616, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(977, 710);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.33977F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.66023F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flipButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReceiveBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.send, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SendBox, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(79, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.08743F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.91257F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 373);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // flipButton
            // 
            this.flipButton.Location = new System.Drawing.Point(279, 3);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(123, 66);
            this.flipButton.TabIndex = 7;
            this.flipButton.Text = "make  a spin";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.flipButton_Click);
            // 
            // ReceiveBox
            // 
            this.ReceiveBox.Location = new System.Drawing.Point(3, 153);
            this.ReceiveBox.Name = "ReceiveBox";
            this.ReceiveBox.Size = new System.Drawing.Size(206, 206);
            this.ReceiveBox.TabIndex = 4;
            this.ReceiveBox.Text = "";
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.SystemColors.Control;
            this.send.Cursor = System.Windows.Forms.Cursors.Default;
            this.send.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.send.Location = new System.Drawing.Point(279, 75);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(123, 54);
            this.send.TabIndex = 1;
            this.send.Text = "SEND";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // SendBox
            // 
            this.SendBox.Location = new System.Drawing.Point(3, 75);
            this.SendBox.Name = "SendBox";
            this.SendBox.Size = new System.Drawing.Size(121, 20);
            this.SendBox.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1487, 828);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Жидкости";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.liquidsPanel);
            this.splitContainer2.Panel1.Controls.Add(this.addLiquidButton);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.liquidDataPanel);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Size = new System.Drawing.Size(1481, 822);
            this.splitContainer2.SplitterDistance = 300;
            this.splitContainer2.TabIndex = 0;
            // 
            // liquidsPanel
            // 
            this.liquidsPanel.AutoScroll = true;
            this.liquidsPanel.ColumnCount = 2;
            this.liquidsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.liquidsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.liquidsPanel.Location = new System.Drawing.Point(11, 70);
            this.liquidsPanel.Name = "liquidsPanel";
            this.liquidsPanel.RowCount = 1;
            this.liquidsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.liquidsPanel.Size = new System.Drawing.Size(200, 549);
            this.liquidsPanel.TabIndex = 3;
            // 
            // addLiquidButton
            // 
            this.addLiquidButton.BackColor = System.Drawing.SystemColors.Control;
            this.addLiquidButton.Location = new System.Drawing.Point(11, 41);
            this.addLiquidButton.Name = "addLiquidButton";
            this.addLiquidButton.Size = new System.Drawing.Size(120, 23);
            this.addLiquidButton.TabIndex = 1;
            this.addLiquidButton.Text = "Новая жидкость";
            this.addLiquidButton.UseVisualStyleBackColor = false;
            this.addLiquidButton.Click += new System.EventHandler(this.addLiquidButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Жидкости:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 211);
            this.label2.TabIndex = 1;
            this.label2.Text = "Какой-то тупой текст о том, что для того, чтобы добавить новую жидкость, надо наж" +
    "ать на кнопку \"Новая жидкость\".";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Controls.Add(this.itemsMenu);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1487, 828);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Настройка модулей";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImage = global::chem_robot_test.Properties.Resources.workZone;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.80695F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.19305F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel2.Controls.Add(this.Zone_1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Zone_10, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.Zone_9, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.Zone_8, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.Zone_2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Zone_7, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Zone_6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Zone_5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.Zone_3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Zone_4, 2, 0);
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(723, 416);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(645, 258);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // Zone_1
            // 
            this.Zone_1.BackColor = System.Drawing.Color.Transparent;
            this.Zone_1.Location = new System.Drawing.Point(0, 0);
            this.Zone_1.Margin = new System.Windows.Forms.Padding(0);
            this.Zone_1.Name = "Zone_1";
            this.Zone_1.Size = new System.Drawing.Size(127, 128);
            this.Zone_1.TabIndex = 0;
            this.Zone_1.TabStop = false;
            this.Zone_1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.showModuleTypes);
            this.Zone_1.MouseEnter += new System.EventHandler(this.showOverlayImage);
            this.Zone_1.MouseLeave += new System.EventHandler(this.hideOverlayImage);
            // 
            // Zone_10
            // 
            this.Zone_10.BackColor = System.Drawing.Color.Transparent;
            this.Zone_10.Location = new System.Drawing.Point(515, 129);
            this.Zone_10.Margin = new System.Windows.Forms.Padding(0);
            this.Zone_10.Name = "Zone_10";
            this.Zone_10.Size = new System.Drawing.Size(128, 128);
            this.Zone_10.TabIndex = 9;
            this.Zone_10.TabStop = false;
            this.Zone_10.MouseEnter += new System.EventHandler(this.showOverlayImage);
            this.Zone_10.MouseLeave += new System.EventHandler(this.hideOverlayImage);
            // 
            // Zone_9
            // 
            this.Zone_9.BackColor = System.Drawing.Color.Transparent;
            this.Zone_9.Location = new System.Drawing.Point(386, 129);
            this.Zone_9.Margin = new System.Windows.Forms.Padding(0);
            this.Zone_9.Name = "Zone_9";
            this.Zone_9.Size = new System.Drawing.Size(128, 128);
            this.Zone_9.TabIndex = 8;
            this.Zone_9.TabStop = false;
            this.Zone_9.MouseEnter += new System.EventHandler(this.showOverlayImage);
            this.Zone_9.MouseLeave += new System.EventHandler(this.hideOverlayImage);
            // 
            // Zone_8
            // 
            this.Zone_8.BackColor = System.Drawing.Color.Transparent;
            this.Zone_8.Location = new System.Drawing.Point(256, 129);
            this.Zone_8.Margin = new System.Windows.Forms.Padding(0);
            this.Zone_8.Name = "Zone_8";
            this.Zone_8.Size = new System.Drawing.Size(128, 128);
            this.Zone_8.TabIndex = 7;
            this.Zone_8.TabStop = false;
            this.Zone_8.MouseEnter += new System.EventHandler(this.showOverlayImage);
            this.Zone_8.MouseLeave += new System.EventHandler(this.hideOverlayImage);
            // 
            // Zone_2
            // 
            this.Zone_2.BackColor = System.Drawing.Color.Transparent;
            this.Zone_2.Location = new System.Drawing.Point(128, 0);
            this.Zone_2.Margin = new System.Windows.Forms.Padding(0);
            this.Zone_2.Name = "Zone_2";
            this.Zone_2.Size = new System.Drawing.Size(128, 128);
            this.Zone_2.TabIndex = 1;
            this.Zone_2.TabStop = false;
            this.Zone_2.MouseEnter += new System.EventHandler(this.showOverlayImage);
            this.Zone_2.MouseLeave += new System.EventHandler(this.hideOverlayImage);
            // 
            // Zone_7
            // 
            this.Zone_7.BackColor = System.Drawing.Color.Transparent;
            this.Zone_7.Location = new System.Drawing.Point(128, 129);
            this.Zone_7.Margin = new System.Windows.Forms.Padding(0);
            this.Zone_7.Name = "Zone_7";
            this.Zone_7.Size = new System.Drawing.Size(128, 128);
            this.Zone_7.TabIndex = 6;
            this.Zone_7.TabStop = false;
            this.Zone_7.MouseEnter += new System.EventHandler(this.showOverlayImage);
            this.Zone_7.MouseLeave += new System.EventHandler(this.hideOverlayImage);
            // 
            // Zone_6
            // 
            this.Zone_6.BackColor = System.Drawing.Color.Transparent;
            this.Zone_6.Location = new System.Drawing.Point(0, 129);
            this.Zone_6.Margin = new System.Windows.Forms.Padding(0);
            this.Zone_6.Name = "Zone_6";
            this.Zone_6.Size = new System.Drawing.Size(128, 128);
            this.Zone_6.TabIndex = 5;
            this.Zone_6.TabStop = false;
            this.Zone_6.MouseEnter += new System.EventHandler(this.showOverlayImage);
            this.Zone_6.MouseLeave += new System.EventHandler(this.hideOverlayImage);
            // 
            // Zone_5
            // 
            this.Zone_5.BackColor = System.Drawing.Color.Transparent;
            this.Zone_5.Location = new System.Drawing.Point(515, 0);
            this.Zone_5.Margin = new System.Windows.Forms.Padding(0);
            this.Zone_5.Name = "Zone_5";
            this.Zone_5.Size = new System.Drawing.Size(128, 128);
            this.Zone_5.TabIndex = 4;
            this.Zone_5.TabStop = false;
            this.Zone_5.MouseEnter += new System.EventHandler(this.showOverlayImage);
            this.Zone_5.MouseLeave += new System.EventHandler(this.hideOverlayImage);
            // 
            // Zone_3
            // 
            this.Zone_3.BackColor = System.Drawing.Color.Transparent;
            this.Zone_3.Location = new System.Drawing.Point(386, 0);
            this.Zone_3.Margin = new System.Windows.Forms.Padding(0);
            this.Zone_3.Name = "Zone_3";
            this.Zone_3.Size = new System.Drawing.Size(128, 128);
            this.Zone_3.TabIndex = 2;
            this.Zone_3.TabStop = false;
            this.Zone_3.MouseEnter += new System.EventHandler(this.showOverlayImage);
            this.Zone_3.MouseLeave += new System.EventHandler(this.hideOverlayImage);
            // 
            // Zone_4
            // 
            this.Zone_4.BackColor = System.Drawing.Color.Transparent;
            this.Zone_4.Location = new System.Drawing.Point(256, 0);
            this.Zone_4.Margin = new System.Windows.Forms.Padding(0);
            this.Zone_4.Name = "Zone_4";
            this.Zone_4.Size = new System.Drawing.Size(128, 128);
            this.Zone_4.TabIndex = 3;
            this.Zone_4.TabStop = false;
            this.Zone_4.MouseEnter += new System.EventHandler(this.showOverlayImage);
            this.Zone_4.MouseLeave += new System.EventHandler(this.hideOverlayImage);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.ReshowDelay = 100;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1487, 828);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Редактор модулей";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.editorTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.moduleEditor1);
            this.splitContainer1.Size = new System.Drawing.Size(1481, 822);
            this.splitContainer1.SplitterDistance = 493;
            this.splitContainer1.TabIndex = 0;
            // 
            // editorTreeView
            // 
            this.editorTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editorTreeView.Location = new System.Drawing.Point(4, 3);
            this.editorTreeView.Name = "editorTreeView";
            this.editorTreeView.Size = new System.Drawing.Size(487, 435);
            this.editorTreeView.TabIndex = 0;
            this.editorTreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.editorTreeView_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Новый модуль";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // liquidDataPanel
            // 
            this.liquidDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liquidDataPanel.Location = new System.Drawing.Point(0, 0);
            this.liquidDataPanel.Margin = new System.Windows.Forms.Padding(48, 44, 48, 44);
            this.liquidDataPanel.Name = "liquidDataPanel";
            this.liquidDataPanel.Size = new System.Drawing.Size(1175, 820);
            this.liquidDataPanel.TabIndex = 0;
            this.liquidDataPanel.Visible = false;
            // 
            // itemsMenu
            // 
            this.itemsMenu.BackColor = System.Drawing.Color.Transparent;
            this.itemsMenu.Location = new System.Drawing.Point(32696, 32581);
            this.itemsMenu.Margin = new System.Windows.Forms.Padding(384, 313, 384, 313);
            this.itemsMenu.Name = "itemsMenu";
            this.itemsMenu.Size = new System.Drawing.Size(65535, 43946);
            this.itemsMenu.TabIndex = 25;
            // 
            // moduleEditor1
            // 
            this.moduleEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleEditor1.Location = new System.Drawing.Point(0, 0);
            this.moduleEditor1.Name = "moduleEditor1";
            this.moduleEditor1.Size = new System.Drawing.Size(984, 822);
            this.moduleEditor1.TabIndex = 0;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(chem_robot_test.Form1);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1652, 847);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.workplaceMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Zone_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_4)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer ports_refresh_timer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip workplaceMenu;
        private System.Windows.Forms.ToolStripMenuItem выбратьЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настроитьЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЭлементToolStripMenuItem;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.RichTextBox ReceiveBox;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox SendBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox Zone_1;
        private System.Windows.Forms.PictureBox Zone_10;
        private System.Windows.Forms.PictureBox Zone_9;
        private System.Windows.Forms.PictureBox Zone_8;
        private System.Windows.Forms.PictureBox Zone_2;
        private System.Windows.Forms.PictureBox Zone_7;
        private System.Windows.Forms.PictureBox Zone_6;
        private System.Windows.Forms.PictureBox Zone_5;
        private System.Windows.Forms.PictureBox Zone_3;
        private System.Windows.Forms.PictureBox Zone_4;
        private System.Windows.Forms.ToolTip toolTip1;
        private TestControl itemsMenu;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private CustomControls.LiquidDataPanel liquidDataPanel;
        private System.Windows.Forms.Button addLiquidButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel liquidsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView editorTreeView;
        private CustomControls.ModuleEditor moduleEditor1;
    }
}

