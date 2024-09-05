namespace Hshop_Terminal_v1._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.receiveBox = new System.Windows.Forms.RichTextBox();
            this.sendBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.appendBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.newDeviceBtn = new System.Windows.Forms.Button();
            this.devicesBox = new System.Windows.Forms.ComboBox();
            this.imagesBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.excuteBtn = new System.Windows.Forms.Button();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.connectBtn = new System.Windows.Forms.Button();
            this.cStopBox = new System.Windows.Forms.ComboBox();
            this.cParityBox = new System.Windows.Forms.ComboBox();
            this.cDataBox = new System.Windows.Forms.ComboBox();
            this.cBaudBox = new System.Windows.Forms.ComboBox();
            this.cComBox = new System.Windows.Forms.ComboBox();
            this.stopbitBox = new System.Windows.Forms.Label();
            this.parityBox = new System.Windows.Forms.Label();
            this.databitBox = new System.Windows.Forms.Label();
            this.baudBox = new System.Windows.Forms.Label();
            this.comBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cBoxBaud1 = new System.Windows.Forms.ComboBox();
            this.cBoxBaud2 = new System.Windows.Forms.ComboBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.receiveBox2 = new System.Windows.Forms.RichTextBox();
            this.receiveBox1 = new System.Windows.Forms.RichTextBox();
            this.autoSendBtn = new System.Windows.Forms.Button();
            this.cComBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.p2Connect = new System.Windows.Forms.Button();
            this.cComBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sendBox2 = new System.Windows.Forms.TextBox();
            this.sendBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(12, 6);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1098, 784);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.receiveBox);
            this.tabPage1.Controls.Add(this.sendBox);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1090, 745);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // receiveBox
            // 
            this.receiveBox.BackColor = System.Drawing.Color.White;
            this.receiveBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiveBox.Location = new System.Drawing.Point(3, 55);
            this.receiveBox.Name = "receiveBox";
            this.receiveBox.ReadOnly = true;
            this.receiveBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.receiveBox.Size = new System.Drawing.Size(766, 684);
            this.receiveBox.TabIndex = 33;
            this.receiveBox.Text = "";
            // 
            // sendBox
            // 
            this.sendBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBox.Location = new System.Drawing.Point(3, 8);
            this.sendBox.Multiline = true;
            this.sendBox.Name = "sendBox";
            this.sendBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sendBox.Size = new System.Drawing.Size(766, 33);
            this.sendBox.TabIndex = 32;
            this.sendBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendBox_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.appendBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.newDeviceBtn);
            this.panel1.Controls.Add(this.devicesBox);
            this.panel1.Controls.Add(this.imagesBtn);
            this.panel1.Controls.Add(this.uploadBtn);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.excuteBtn);
            this.panel1.Controls.Add(this.noteBox);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.connectBtn);
            this.panel1.Controls.Add(this.cStopBox);
            this.panel1.Controls.Add(this.cParityBox);
            this.panel1.Controls.Add(this.cDataBox);
            this.panel1.Controls.Add(this.cBaudBox);
            this.panel1.Controls.Add(this.cComBox);
            this.panel1.Controls.Add(this.stopbitBox);
            this.panel1.Controls.Add(this.parityBox);
            this.panel1.Controls.Add(this.databitBox);
            this.panel1.Controls.Add(this.baudBox);
            this.panel1.Controls.Add(this.comBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(775, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 739);
            this.panel1.TabIndex = 0;
            // 
            // appendBox
            // 
            this.appendBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appendBox.FormattingEnabled = true;
            this.appendBox.Items.AddRange(new object[] {
            "None",
            "CR",
            "LF",
            "CR-LF"});
            this.appendBox.Location = new System.Drawing.Point(182, 336);
            this.appendBox.Name = "appendBox";
            this.appendBox.Size = new System.Drawing.Size(121, 28);
            this.appendBox.TabIndex = 55;
            this.appendBox.Text = "None";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Append";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(72, 130);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(61, 25);
            this.deleteBtn.TabIndex = 53;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // newDeviceBtn
            // 
            this.newDeviceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.newDeviceBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.newDeviceBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.newDeviceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDeviceBtn.ForeColor = System.Drawing.Color.Black;
            this.newDeviceBtn.Location = new System.Drawing.Point(7, 130);
            this.newDeviceBtn.Name = "newDeviceBtn";
            this.newDeviceBtn.Size = new System.Drawing.Size(58, 25);
            this.newDeviceBtn.TabIndex = 52;
            this.newDeviceBtn.Text = "New";
            this.newDeviceBtn.UseVisualStyleBackColor = false;
            this.newDeviceBtn.Click += new System.EventHandler(this.newDeviceBtn_Click);
            // 
            // devicesBox
            // 
            this.devicesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devicesBox.FormattingEnabled = true;
            this.devicesBox.Location = new System.Drawing.Point(143, 127);
            this.devicesBox.Name = "devicesBox";
            this.devicesBox.Size = new System.Drawing.Size(160, 28);
            this.devicesBox.TabIndex = 50;
            this.devicesBox.SelectedIndexChanged += new System.EventHandler(this.devicesBox_SelectedIndexChanged);
            // 
            // imagesBtn
            // 
            this.imagesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.imagesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.imagesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.imagesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagesBtn.ForeColor = System.Drawing.Color.White;
            this.imagesBtn.Location = new System.Drawing.Point(16, 477);
            this.imagesBtn.Name = "imagesBtn";
            this.imagesBtn.Size = new System.Drawing.Size(276, 35);
            this.imagesBtn.TabIndex = 45;
            this.imagesBtn.Text = "Images";
            this.imagesBtn.UseVisualStyleBackColor = false;
            this.imagesBtn.Click += new System.EventHandler(this.imagesBtn_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.uploadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.uploadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.uploadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.ForeColor = System.Drawing.Color.White;
            this.uploadBtn.Location = new System.Drawing.Point(16, 437);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(276, 35);
            this.uploadBtn.TabIndex = 44;
            this.uploadBtn.Text = "UpLoad";
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Brown;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(164, 696);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(141, 35);
            this.saveBtn.TabIndex = 43;
            this.saveBtn.Text = "Save Note";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // excuteBtn
            // 
            this.excuteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.excuteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.excuteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.excuteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excuteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.excuteBtn.Location = new System.Drawing.Point(7, 696);
            this.excuteBtn.Name = "excuteBtn";
            this.excuteBtn.Size = new System.Drawing.Size(141, 35);
            this.excuteBtn.TabIndex = 42;
            this.excuteBtn.Text = "Excute";
            this.excuteBtn.UseVisualStyleBackColor = false;
            this.excuteBtn.Click += new System.EventHandler(this.excuteBtn_Click);
            // 
            // noteBox
            // 
            this.noteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteBox.Location = new System.Drawing.Point(8, 518);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.noteBox.Size = new System.Drawing.Size(297, 172);
            this.noteBox.TabIndex = 33;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Yellow;
            this.progressBar1.ForeColor = System.Drawing.Color.Blue;
            this.progressBar1.Location = new System.Drawing.Point(16, 381);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(276, 10);
            this.progressBar1.TabIndex = 41;
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.connectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.connectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.ForeColor = System.Drawing.Color.White;
            this.connectBtn.Location = new System.Drawing.Point(16, 397);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(276, 35);
            this.connectBtn.TabIndex = 40;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // cStopBox
            // 
            this.cStopBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cStopBox.FormattingEnabled = true;
            this.cStopBox.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cStopBox.Location = new System.Drawing.Point(182, 302);
            this.cStopBox.Name = "cStopBox";
            this.cStopBox.Size = new System.Drawing.Size(121, 28);
            this.cStopBox.TabIndex = 39;
            this.cStopBox.Text = "One";
            // 
            // cParityBox
            // 
            this.cParityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cParityBox.FormattingEnabled = true;
            this.cParityBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cParityBox.Location = new System.Drawing.Point(182, 268);
            this.cParityBox.Name = "cParityBox";
            this.cParityBox.Size = new System.Drawing.Size(121, 28);
            this.cParityBox.TabIndex = 38;
            this.cParityBox.Text = "None";
            // 
            // cDataBox
            // 
            this.cDataBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cDataBox.FormattingEnabled = true;
            this.cDataBox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cDataBox.Location = new System.Drawing.Point(182, 234);
            this.cDataBox.Name = "cDataBox";
            this.cDataBox.Size = new System.Drawing.Size(121, 28);
            this.cDataBox.TabIndex = 37;
            this.cDataBox.Text = "8";
            // 
            // cBaudBox
            // 
            this.cBaudBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBaudBox.FormattingEnabled = true;
            this.cBaudBox.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.cBaudBox.Location = new System.Drawing.Point(182, 200);
            this.cBaudBox.Name = "cBaudBox";
            this.cBaudBox.Size = new System.Drawing.Size(121, 28);
            this.cBaudBox.TabIndex = 36;
            this.cBaudBox.Text = "9600";
            // 
            // cComBox
            // 
            this.cComBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cComBox.FormattingEnabled = true;
            this.cComBox.Location = new System.Drawing.Point(182, 166);
            this.cComBox.Name = "cComBox";
            this.cComBox.Size = new System.Drawing.Size(121, 28);
            this.cComBox.TabIndex = 35;
            // 
            // stopbitBox
            // 
            this.stopbitBox.AutoSize = true;
            this.stopbitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopbitBox.Location = new System.Drawing.Point(58, 310);
            this.stopbitBox.Name = "stopbitBox";
            this.stopbitBox.Size = new System.Drawing.Size(69, 20);
            this.stopbitBox.TabIndex = 34;
            this.stopbitBox.Text = "Stop Bit";
            // 
            // parityBox
            // 
            this.parityBox.AutoSize = true;
            this.parityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parityBox.Location = new System.Drawing.Point(58, 276);
            this.parityBox.Name = "parityBox";
            this.parityBox.Size = new System.Drawing.Size(52, 20);
            this.parityBox.TabIndex = 33;
            this.parityBox.Text = "Parity";
            // 
            // databitBox
            // 
            this.databitBox.AutoSize = true;
            this.databitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databitBox.Location = new System.Drawing.Point(58, 242);
            this.databitBox.Name = "databitBox";
            this.databitBox.Size = new System.Drawing.Size(71, 20);
            this.databitBox.TabIndex = 32;
            this.databitBox.Text = "Data Bit";
            // 
            // baudBox
            // 
            this.baudBox.AutoSize = true;
            this.baudBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudBox.Location = new System.Drawing.Point(58, 208);
            this.baudBox.Name = "baudBox";
            this.baudBox.Size = new System.Drawing.Size(88, 20);
            this.baudBox.TabIndex = 31;
            this.baudBox.Text = "Baud Rate";
            // 
            // comBox
            // 
            this.comBox.AutoSize = true;
            this.comBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBox.Location = new System.Drawing.Point(58, 174);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(48, 20);
            this.comBox.TabIndex = 30;
            this.comBox.Text = "COM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "HS Code";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(108, 88);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(195, 27);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hshop_Terminal_v1._0.Properties.Resources.Hshop_logo;
            this.pictureBox1.Location = new System.Drawing.Point(56, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.cBoxBaud1);
            this.tabPage2.Controls.Add(this.cBoxBaud2);
            this.tabPage2.Controls.Add(this.clearBtn);
            this.tabPage2.Controls.Add(this.receiveBox2);
            this.tabPage2.Controls.Add(this.receiveBox1);
            this.tabPage2.Controls.Add(this.autoSendBtn);
            this.tabPage2.Controls.Add(this.cComBox2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.p2Connect);
            this.tabPage2.Controls.Add(this.cComBox1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.sendBox2);
            this.tabPage2.Controls.Add(this.sendBox1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1090, 745);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Two COM";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hshop_Terminal_v1._0.Properties.Resources.Hshop_logo;
            this.pictureBox2.Location = new System.Drawing.Point(971, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            // 
            // cBoxBaud1
            // 
            this.cBoxBaud1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxBaud1.FormattingEnabled = true;
            this.cBoxBaud1.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.cBoxBaud1.Location = new System.Drawing.Point(182, 89);
            this.cBoxBaud1.Name = "cBoxBaud1";
            this.cBoxBaud1.Size = new System.Drawing.Size(142, 37);
            this.cBoxBaud1.TabIndex = 67;
            // 
            // cBoxBaud2
            // 
            this.cBoxBaud2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxBaud2.FormattingEnabled = true;
            this.cBoxBaud2.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.cBoxBaud2.Location = new System.Drawing.Point(771, 89);
            this.cBoxBaud2.Name = "cBoxBaud2";
            this.cBoxBaud2.Size = new System.Drawing.Size(142, 37);
            this.cBoxBaud2.TabIndex = 66;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Yellow;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(464, 94);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(172, 35);
            this.clearBtn.TabIndex = 65;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // receiveBox2
            // 
            this.receiveBox2.BackColor = System.Drawing.Color.White;
            this.receiveBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiveBox2.Location = new System.Drawing.Point(555, 176);
            this.receiveBox2.Name = "receiveBox2";
            this.receiveBox2.ReadOnly = true;
            this.receiveBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.receiveBox2.Size = new System.Drawing.Size(528, 563);
            this.receiveBox2.TabIndex = 64;
            this.receiveBox2.Text = "";
            // 
            // receiveBox1
            // 
            this.receiveBox1.BackColor = System.Drawing.Color.White;
            this.receiveBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiveBox1.Location = new System.Drawing.Point(7, 176);
            this.receiveBox1.Name = "receiveBox1";
            this.receiveBox1.ReadOnly = true;
            this.receiveBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.receiveBox1.Size = new System.Drawing.Size(528, 563);
            this.receiveBox1.TabIndex = 63;
            this.receiveBox1.Text = "";
            // 
            // autoSendBtn
            // 
            this.autoSendBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.autoSendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoSendBtn.Location = new System.Drawing.Point(464, 53);
            this.autoSendBtn.Name = "autoSendBtn";
            this.autoSendBtn.Size = new System.Drawing.Size(172, 35);
            this.autoSendBtn.TabIndex = 62;
            this.autoSendBtn.Text = "Auto Send";
            this.autoSendBtn.UseVisualStyleBackColor = false;
            this.autoSendBtn.Click += new System.EventHandler(this.autoSendBtn_Click);
            // 
            // cComBox2
            // 
            this.cComBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cComBox2.FormattingEnabled = true;
            this.cComBox2.Location = new System.Drawing.Point(771, 46);
            this.cComBox2.Name = "cComBox2";
            this.cComBox2.Size = new System.Drawing.Size(142, 37);
            this.cComBox2.TabIndex = 61;
            this.cComBox2.Click += new System.EventHandler(this.cComBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(781, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 60;
            this.label3.Text = "2nd COM";
            // 
            // p2Connect
            // 
            this.p2Connect.BackColor = System.Drawing.Color.Lime;
            this.p2Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Connect.Location = new System.Drawing.Point(464, 12);
            this.p2Connect.Name = "p2Connect";
            this.p2Connect.Size = new System.Drawing.Size(172, 35);
            this.p2Connect.TabIndex = 57;
            this.p2Connect.Text = "Connect";
            this.p2Connect.UseVisualStyleBackColor = false;
            this.p2Connect.Click += new System.EventHandler(this.p2Connect_Click);
            // 
            // cComBox1
            // 
            this.cComBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cComBox1.FormattingEnabled = true;
            this.cComBox1.Location = new System.Drawing.Point(182, 46);
            this.cComBox1.Name = "cComBox1";
            this.cComBox1.Size = new System.Drawing.Size(142, 37);
            this.cComBox1.TabIndex = 56;
            this.cComBox1.Click += new System.EventHandler(this.cComBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(193, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 29);
            this.label5.TabIndex = 55;
            this.label5.Text = "1st COM";
            // 
            // sendBox2
            // 
            this.sendBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBox2.Location = new System.Drawing.Point(555, 137);
            this.sendBox2.Multiline = true;
            this.sendBox2.Name = "sendBox2";
            this.sendBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sendBox2.Size = new System.Drawing.Size(528, 33);
            this.sendBox2.TabIndex = 53;
            this.sendBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendBox2_KeyPress);
            // 
            // sendBox1
            // 
            this.sendBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBox1.Location = new System.Drawing.Point(7, 137);
            this.sendBox1.Multiline = true;
            this.sendBox1.Name = "sendBox1";
            this.sendBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sendBox1.Size = new System.Drawing.Size(528, 33);
            this.sendBox1.TabIndex = 51;
            this.sendBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendBox1_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 785);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hshop Terminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox sendBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.ComboBox cStopBox;
        private System.Windows.Forms.ComboBox cParityBox;
        private System.Windows.Forms.ComboBox cDataBox;
        private System.Windows.Forms.ComboBox cBaudBox;
        private System.Windows.Forms.ComboBox cComBox;
        private System.Windows.Forms.Label stopbitBox;
        private System.Windows.Forms.Label parityBox;
        private System.Windows.Forms.Label databitBox;
        private System.Windows.Forms.Label baudBox;
        private System.Windows.Forms.Label comBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button excuteBtn;
        private System.Windows.Forms.Button uploadBtn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.IO.Ports.SerialPort serialPort3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox receiveBox;
        private System.Windows.Forms.Button imagesBtn;
        private System.Windows.Forms.Button autoSendBtn;
        private System.Windows.Forms.ComboBox cComBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button p2Connect;
        private System.Windows.Forms.ComboBox cComBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sendBox2;
        private System.Windows.Forms.TextBox sendBox1;
        private System.Windows.Forms.RichTextBox receiveBox2;
        private System.Windows.Forms.RichTextBox receiveBox1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ComboBox devicesBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button newDeviceBtn;
        private System.Windows.Forms.ComboBox cBoxBaud1;
        private System.Windows.Forms.ComboBox cBoxBaud2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox appendBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer3;
    }
}

