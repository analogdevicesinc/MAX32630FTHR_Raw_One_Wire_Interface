namespace MAX32630_One_Wire_Interface
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.maximGroupBox1 = new MaximStyle.MaximGroupBox();
            this.OD_Match_ROM = new MaximStyle.MaximRadioButton();
            this.OD_Skip_ROM = new MaximStyle.MaximRadioButton();
            this.Read_ROM = new MaximStyle.MaximRadioButton();
            this.Resume = new MaximStyle.MaximRadioButton();
            this.Match_ROM = new MaximStyle.MaximRadioButton();
            this.Button_Send_ROM = new MaximStyle.MaximButton();
            this.Skip_ROM = new MaximStyle.MaximRadioButton();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.InputText = new System.Windows.Forms.TextBox();
            this.ButtonReset = new MaximStyle.MaximButton();
            this.Button_Write_1 = new MaximStyle.MaximButton();
            this.Button_Write_0 = new MaximStyle.MaximButton();
            this.Write_Bytes_Box = new MaximStyle.MaximGroupBox();
            this.Button_Send_Power = new MaximStyle.MaximButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Box_PU_Options = new MaximStyle.MaximGroupBox();
            this.Pullup_Indicator = new MaximStyle.MaximStatusIndicator();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pullup_Write_Byte = new MaximStyle.MaximRadioButton();
            this.Pullup_Write_Bit = new MaximStyle.MaximRadioButton();
            this.Pullup_Normal = new MaximStyle.MaximRadioButton();
            this.Speed_Select_Box = new MaximStyle.MaximGroupBox();
            this.Button_Send_Speed = new MaximStyle.MaximButton();
            this.Button_Speed_OD = new MaximStyle.MaximRadioButton();
            this.Button_Speed_Norm = new MaximStyle.MaximRadioButton();
            this.Box_Read = new MaximStyle.MaximGroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Button_Read_Bit = new MaximStyle.MaximButton();
            this.Button_Read_Bytes = new MaximStyle.MaximButton();
            this.maximNumericUpDown1 = new MaximStyle.MaximNumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.maximGroupBox5 = new MaximStyle.MaximGroupBox();
            this.Dropdown_Rom_Ids = new MaximStyle.MaximComboBox();
            this.maximStatusStrip1 = new MaximStyle.MaximStatusStrip();
            this.findRomIDs = new MaximStyle.MaximButton();
            this.maximGroupBox2 = new MaximStyle.MaximGroupBox();
            this.Button_Alarm_Search = new MaximStyle.MaximButton();
            this.maximGroupBox3 = new MaximStyle.MaximGroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.maximGroupBox4 = new MaximStyle.MaximGroupBox();
            this.maximGroupBox1.SuspendLayout();
            this.Write_Bytes_Box.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Box_PU_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pullup_Indicator)).BeginInit();
            this.Speed_Select_Box.SuspendLayout();
            this.Box_Read.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.maximGroupBox5.SuspendLayout();
            this.maximGroupBox2.SuspendLayout();
            this.maximGroupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.maximGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // maximGroupBox1
            // 
            this.maximGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maximGroupBox1.BackgroundColor = System.Drawing.Color.White;
            this.maximGroupBox1.Controls.Add(this.OD_Match_ROM);
            this.maximGroupBox1.Controls.Add(this.OD_Skip_ROM);
            this.maximGroupBox1.Controls.Add(this.Read_ROM);
            this.maximGroupBox1.Controls.Add(this.Resume);
            this.maximGroupBox1.Controls.Add(this.Match_ROM);
            this.maximGroupBox1.Controls.Add(this.Button_Send_ROM);
            this.maximGroupBox1.Controls.Add(this.Skip_ROM);
            this.maximGroupBox1.Location = new System.Drawing.Point(3, 203);
            this.maximGroupBox1.Name = "maximGroupBox1";
            this.maximGroupBox1.Size = new System.Drawing.Size(254, 211);
            this.maximGroupBox1.TabIndex = 0;
            this.maximGroupBox1.TabStop = false;
            this.maximGroupBox1.Text = "ROM Commands";
            // 
            // OD_Match_ROM
            // 
            this.OD_Match_ROM.AutoSize = true;
            this.OD_Match_ROM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OD_Match_ROM.Location = new System.Drawing.Point(48, 145);
            this.OD_Match_ROM.Name = "OD_Match_ROM";
            this.OD_Match_ROM.Size = new System.Drawing.Size(157, 17);
            this.OD_Match_ROM.TabIndex = 8;
            this.OD_Match_ROM.TabStop = true;
            this.OD_Match_ROM.Text = "Reset + OD Match-ROM";
            this.OD_Match_ROM.UseVisualStyleBackColor = true;
            this.OD_Match_ROM.CheckedChanged += new System.EventHandler(this.OD_Match_ROM_CheckedChanged);
            // 
            // OD_Skip_ROM
            // 
            this.OD_Skip_ROM.AutoSize = true;
            this.OD_Skip_ROM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OD_Skip_ROM.Location = new System.Drawing.Point(48, 122);
            this.OD_Skip_ROM.Name = "OD_Skip_ROM";
            this.OD_Skip_ROM.Size = new System.Drawing.Size(148, 17);
            this.OD_Skip_ROM.TabIndex = 7;
            this.OD_Skip_ROM.TabStop = true;
            this.OD_Skip_ROM.Text = "Reset + OD Skip-ROM";
            this.OD_Skip_ROM.UseVisualStyleBackColor = true;
            this.OD_Skip_ROM.CheckedChanged += new System.EventHandler(this.OD_Skip_ROM_CheckedChanged);
            // 
            // Read_ROM
            // 
            this.Read_ROM.AutoSize = true;
            this.Read_ROM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Read_ROM.Location = new System.Drawing.Point(48, 99);
            this.Read_ROM.Name = "Read_ROM";
            this.Read_ROM.Size = new System.Drawing.Size(131, 17);
            this.Read_ROM.TabIndex = 6;
            this.Read_ROM.TabStop = true;
            this.Read_ROM.Text = "Reset + Read-ROM";
            this.Read_ROM.UseVisualStyleBackColor = true;
            this.Read_ROM.CheckedChanged += new System.EventHandler(this.Read_ROM_CheckedChanged);
            // 
            // Resume
            // 
            this.Resume.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resume.Location = new System.Drawing.Point(48, 75);
            this.Resume.Name = "Resume";
            this.Resume.Size = new System.Drawing.Size(126, 18);
            this.Resume.TabIndex = 5;
            this.Resume.TabStop = true;
            this.Resume.Text = "Reset + Resume";
            this.Resume.UseVisualStyleBackColor = true;
            this.Resume.CheckedChanged += new System.EventHandler(this.Resume_CheckedChanged);
            // 
            // Match_ROM
            // 
            this.Match_ROM.AutoSize = true;
            this.Match_ROM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Match_ROM.Location = new System.Drawing.Point(48, 52);
            this.Match_ROM.Name = "Match_ROM";
            this.Match_ROM.Size = new System.Drawing.Size(135, 17);
            this.Match_ROM.TabIndex = 4;
            this.Match_ROM.TabStop = true;
            this.Match_ROM.Text = "Reset + Match-ROM";
            this.Match_ROM.UseVisualStyleBackColor = true;
            this.Match_ROM.CheckedChanged += new System.EventHandler(this.Match_ROM_CheckedChanged);
            // 
            // Button_Send_ROM
            // 
            this.Button_Send_ROM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Send_ROM.AutoSize = true;
            this.Button_Send_ROM.Location = new System.Drawing.Point(48, 168);
            this.Button_Send_ROM.Name = "Button_Send_ROM";
            this.Button_Send_ROM.Size = new System.Drawing.Size(148, 37);
            this.Button_Send_ROM.TabIndex = 1;
            this.Button_Send_ROM.Text = "Send ROM Command";
            this.Button_Send_ROM.UseVisualStyleBackColor = true;
            this.Button_Send_ROM.Click += new System.EventHandler(this.Button_Send_ROM_Click);
            // 
            // Skip_ROM
            // 
            this.Skip_ROM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Skip_ROM.AutoSize = true;
            this.Skip_ROM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Skip_ROM.Location = new System.Drawing.Point(48, 29);
            this.Skip_ROM.Name = "Skip_ROM";
            this.Skip_ROM.Size = new System.Drawing.Size(126, 17);
            this.Skip_ROM.TabIndex = 3;
            this.Skip_ROM.TabStop = true;
            this.Skip_ROM.Text = "Reset + Skip-ROM";
            this.Skip_ROM.UseVisualStyleBackColor = true;
            this.Skip_ROM.CheckedChanged += new System.EventHandler(this.Skip_ROM_CheckedChanged);
            // 
            // OutputText
            // 
            this.OutputText.Location = new System.Drawing.Point(0, 19);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputText.Size = new System.Drawing.Size(338, 463);
            this.OutputText.TabIndex = 2;
            // 
            // serialPort1
            // 
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.SerialPort1_ErrorReceived);
            this.serialPort1.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.SerialPort1_PinChanged);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // InputText
            // 
            this.InputText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.InputText.Location = new System.Drawing.Point(11, 124);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(191, 20);
            this.InputText.TabIndex = 3;
            // 
            // ButtonReset
            // 
            this.ButtonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonReset.Location = new System.Drawing.Point(3, 422);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(254, 41);
            this.ButtonReset.TabIndex = 5;
            this.ButtonReset.Text = "Send Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // Button_Write_1
            // 
            this.Button_Write_1.Location = new System.Drawing.Point(24, 41);
            this.Button_Write_1.Name = "Button_Write_1";
            this.Button_Write_1.Size = new System.Drawing.Size(75, 44);
            this.Button_Write_1.TabIndex = 8;
            this.Button_Write_1.Text = "Write 1";
            this.Button_Write_1.UseVisualStyleBackColor = true;
            this.Button_Write_1.Click += new System.EventHandler(this.Button_Write_1_Click);
            // 
            // Button_Write_0
            // 
            this.Button_Write_0.Location = new System.Drawing.Point(106, 41);
            this.Button_Write_0.Name = "Button_Write_0";
            this.Button_Write_0.Size = new System.Drawing.Size(75, 44);
            this.Button_Write_0.TabIndex = 7;
            this.Button_Write_0.Text = "Write 0";
            this.Button_Write_0.UseVisualStyleBackColor = true;
            this.Button_Write_0.Click += new System.EventHandler(this.Button_Write_0_Click);
            // 
            // Write_Bytes_Box
            // 
            this.Write_Bytes_Box.BackgroundColor = System.Drawing.Color.White;
            this.Write_Bytes_Box.Controls.Add(this.Button_Send_Power);
            this.Write_Bytes_Box.Controls.Add(this.tableLayoutPanel2);
            this.Write_Bytes_Box.Location = new System.Drawing.Point(280, 3);
            this.Write_Bytes_Box.Name = "Write_Bytes_Box";
            this.Write_Bytes_Box.Size = new System.Drawing.Size(458, 483);
            this.Write_Bytes_Box.TabIndex = 7;
            this.Write_Bytes_Box.TabStop = false;
            this.Write_Bytes_Box.Text = "2) Device Specific Function Commands";
            // 
            // Button_Send_Power
            // 
            this.Button_Send_Power.Location = new System.Drawing.Point(262, 147);
            this.Button_Send_Power.Name = "Button_Send_Power";
            this.Button_Send_Power.Size = new System.Drawing.Size(157, 44);
            this.Button_Send_Power.TabIndex = 3;
            this.Button_Send_Power.Text = "Send Data + Pull-Up Option";
            this.Button_Send_Power.UseVisualStyleBackColor = true;
            this.Button_Send_Power.Click += new System.EventHandler(this.Button_Send_Power_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Box_PU_Options, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Speed_Select_Box, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Box_Read, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.maximGroupBox5, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.48927F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.51073F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(466, 466);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // Box_PU_Options
            // 
            this.Box_PU_Options.BackgroundColor = System.Drawing.Color.White;
            this.Box_PU_Options.Controls.Add(this.Pullup_Indicator);
            this.Box_PU_Options.Controls.Add(this.textBox1);
            this.Box_PU_Options.Controls.Add(this.label2);
            this.Box_PU_Options.Controls.Add(this.Pullup_Write_Byte);
            this.Box_PU_Options.Controls.Add(this.Pullup_Write_Bit);
            this.Box_PU_Options.Controls.Add(this.Pullup_Normal);
            this.Box_PU_Options.Controls.Add(this.InputText);
            this.Box_PU_Options.Location = new System.Drawing.Point(3, 3);
            this.Box_PU_Options.Name = "Box_PU_Options";
            this.Box_PU_Options.Size = new System.Drawing.Size(227, 191);
            this.Box_PU_Options.TabIndex = 10;
            this.Box_PU_Options.TabStop = false;
            this.Box_PU_Options.Text = "Write to Bus";
            // 
            // Pullup_Indicator
            // 
            this.Pullup_Indicator.Image = ((System.Drawing.Image)(resources.GetObject("Pullup_Indicator.Image")));
            this.Pullup_Indicator.IndicatorColor = MaximStyle.StatusIndicatorColor.Gray;
            this.Pullup_Indicator.IndicatorSize = MaximStyle.StatusIndicatorSize.Medium;
            this.Pullup_Indicator.Location = new System.Drawing.Point(192, 157);
            this.Pullup_Indicator.Name = "Pullup_Indicator";
            this.Pullup_Indicator.Size = new System.Drawing.Size(20, 20);
            this.Pullup_Indicator.TabIndex = 13;
            this.Pullup_Indicator.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(11, 151);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 26);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Note: Communication Not Functional While Strong Pullup Enabled";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data to Send";
            // 
            // Pullup_Write_Byte
            // 
            this.Pullup_Write_Byte.AutoSize = true;
            this.Pullup_Write_Byte.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pullup_Write_Byte.Location = new System.Drawing.Point(11, 75);
            this.Pullup_Write_Byte.Name = "Pullup_Write_Byte";
            this.Pullup_Write_Byte.Size = new System.Drawing.Size(202, 17);
            this.Pullup_Write_Byte.TabIndex = 5;
            this.Pullup_Write_Byte.Text = "Strong Pull-Up After Writing Byte";
            this.Pullup_Write_Byte.UseVisualStyleBackColor = true;
            this.Pullup_Write_Byte.CheckedChanged += new System.EventHandler(this.Pullup_Write_Byte_CheckedChanged);
            // 
            // Pullup_Write_Bit
            // 
            this.Pullup_Write_Bit.AutoSize = true;
            this.Pullup_Write_Bit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pullup_Write_Bit.Location = new System.Drawing.Point(11, 52);
            this.Pullup_Write_Bit.Name = "Pullup_Write_Bit";
            this.Pullup_Write_Bit.Size = new System.Drawing.Size(192, 17);
            this.Pullup_Write_Bit.TabIndex = 4;
            this.Pullup_Write_Bit.Text = "Strong Pull-Up After Writing Bit";
            this.Pullup_Write_Bit.UseVisualStyleBackColor = true;
            this.Pullup_Write_Bit.CheckedChanged += new System.EventHandler(this.Pullup_Write_Bit_CheckedChanged);
            // 
            // Pullup_Normal
            // 
            this.Pullup_Normal.AutoSize = true;
            this.Pullup_Normal.Checked = true;
            this.Pullup_Normal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pullup_Normal.Location = new System.Drawing.Point(11, 29);
            this.Pullup_Normal.Name = "Pullup_Normal";
            this.Pullup_Normal.Size = new System.Drawing.Size(123, 17);
            this.Pullup_Normal.TabIndex = 0;
            this.Pullup_Normal.TabStop = true;
            this.Pullup_Normal.Text = "Strong Pull-Up Off";
            this.Pullup_Normal.UseVisualStyleBackColor = true;
            this.Pullup_Normal.CheckedChanged += new System.EventHandler(this.Pullup_Normal_CheckedChanged);
            // 
            // Speed_Select_Box
            // 
            this.Speed_Select_Box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Speed_Select_Box.BackgroundColor = System.Drawing.Color.White;
            this.Speed_Select_Box.Controls.Add(this.Button_Send_Speed);
            this.Speed_Select_Box.Controls.Add(this.Button_Speed_OD);
            this.Speed_Select_Box.Controls.Add(this.Button_Speed_Norm);
            this.Speed_Select_Box.Location = new System.Drawing.Point(236, 200);
            this.Speed_Select_Box.Name = "Speed_Select_Box";
            this.Speed_Select_Box.Size = new System.Drawing.Size(219, 263);
            this.Speed_Select_Box.TabIndex = 9;
            this.Speed_Select_Box.TabStop = false;
            this.Speed_Select_Box.Text = "Master Speed Select";
            // 
            // Button_Send_Speed
            // 
            this.Button_Send_Speed.Location = new System.Drawing.Point(24, 117);
            this.Button_Send_Speed.Name = "Button_Send_Speed";
            this.Button_Send_Speed.Size = new System.Drawing.Size(169, 44);
            this.Button_Send_Speed.TabIndex = 2;
            this.Button_Send_Speed.Text = "Set Speed";
            this.Button_Send_Speed.UseVisualStyleBackColor = true;
            this.Button_Send_Speed.Click += new System.EventHandler(this.Button_Send_Speed_Click);
            // 
            // Button_Speed_OD
            // 
            this.Button_Speed_OD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Speed_OD.AutoSize = true;
            this.Button_Speed_OD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Speed_OD.Location = new System.Drawing.Point(117, 62);
            this.Button_Speed_OD.Name = "Button_Speed_OD";
            this.Button_Speed_OD.Size = new System.Drawing.Size(76, 17);
            this.Button_Speed_OD.TabIndex = 1;
            this.Button_Speed_OD.Text = "Overdrive";
            this.Button_Speed_OD.UseVisualStyleBackColor = true;
            this.Button_Speed_OD.CheckedChanged += new System.EventHandler(this.Button_Speed_OD_CheckedChanged);
            // 
            // Button_Speed_Norm
            // 
            this.Button_Speed_Norm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Button_Speed_Norm.AutoSize = true;
            this.Button_Speed_Norm.Checked = true;
            this.Button_Speed_Norm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Speed_Norm.Location = new System.Drawing.Point(24, 62);
            this.Button_Speed_Norm.Name = "Button_Speed_Norm";
            this.Button_Speed_Norm.Size = new System.Drawing.Size(62, 17);
            this.Button_Speed_Norm.TabIndex = 0;
            this.Button_Speed_Norm.TabStop = true;
            this.Button_Speed_Norm.Text = "Normal";
            this.Button_Speed_Norm.UseVisualStyleBackColor = true;
            this.Button_Speed_Norm.CheckedChanged += new System.EventHandler(this.Button_Speed_Norm_CheckedChanged);
            // 
            // Box_Read
            // 
            this.Box_Read.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Box_Read.BackgroundColor = System.Drawing.Color.White;
            this.Box_Read.Controls.Add(this.tableLayoutPanel4);
            this.Box_Read.Location = new System.Drawing.Point(3, 200);
            this.Box_Read.Name = "Box_Read";
            this.Box_Read.Size = new System.Drawing.Size(227, 263);
            this.Box_Read.TabIndex = 8;
            this.Box_Read.TabStop = false;
            this.Box_Read.Text = "Read Functions";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.Button_Read_Bit, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.Button_Read_Bytes, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.maximNumericUpDown1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(32, 61);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.63636F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(155, 168);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // Button_Read_Bit
            // 
            this.Button_Read_Bit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Read_Bit.Location = new System.Drawing.Point(3, 120);
            this.Button_Read_Bit.Name = "Button_Read_Bit";
            this.Button_Read_Bit.Size = new System.Drawing.Size(149, 44);
            this.Button_Read_Bit.TabIndex = 0;
            this.Button_Read_Bit.Text = "Read Bit";
            this.Button_Read_Bit.UseVisualStyleBackColor = true;
            this.Button_Read_Bit.Click += new System.EventHandler(this.Button_Read_Bit_Click);
            // 
            // Button_Read_Bytes
            // 
            this.Button_Read_Bytes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Read_Bytes.Location = new System.Drawing.Point(3, 62);
            this.Button_Read_Bytes.Name = "Button_Read_Bytes";
            this.Button_Read_Bytes.Size = new System.Drawing.Size(149, 44);
            this.Button_Read_Bytes.TabIndex = 9;
            this.Button_Read_Bytes.Text = "Read Bytes";
            this.Button_Read_Bytes.UseVisualStyleBackColor = true;
            this.Button_Read_Bytes.Click += new System.EventHandler(this.Button_Read_Bytes_Click);
            // 
            // maximNumericUpDown1
            // 
            this.maximNumericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maximNumericUpDown1.DecimalPlaces = 3;
            this.maximNumericUpDown1.EnforceMultiple = false;
            this.maximNumericUpDown1.Font = new System.Drawing.Font("Arial", 8F);
            this.maximNumericUpDown1.Increment = 1;
            this.maximNumericUpDown1.IncrementFloat = 0.5D;
            this.maximNumericUpDown1.Location = new System.Drawing.Point(3, 25);
            this.maximNumericUpDown1.Maximum = 100;
            this.maximNumericUpDown1.MaximumFloat = 5D;
            this.maximNumericUpDown1.Minimum = 0;
            this.maximNumericUpDown1.MinimumFloat = 0D;
            this.maximNumericUpDown1.Name = "maximNumericUpDown1";
            this.maximNumericUpDown1.Size = new System.Drawing.Size(149, 20);
            this.maximNumericUpDown1.TabIndex = 1;
            this.maximNumericUpDown1.Text = "maximNumericUpDown1";
            this.maximNumericUpDown1.Thousands = false;
            this.maximNumericUpDown1.Value = 0;
            this.maximNumericUpDown1.ValueFloat = 0D;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Number of Bytes to Read";
            // 
            // maximGroupBox5
            // 
            this.maximGroupBox5.BackgroundColor = System.Drawing.Color.White;
            this.maximGroupBox5.Controls.Add(this.Button_Write_0);
            this.maximGroupBox5.Controls.Add(this.Button_Write_1);
            this.maximGroupBox5.Location = new System.Drawing.Point(236, 3);
            this.maximGroupBox5.Name = "maximGroupBox5";
            this.maximGroupBox5.Size = new System.Drawing.Size(219, 100);
            this.maximGroupBox5.TabIndex = 11;
            this.maximGroupBox5.TabStop = false;
            this.maximGroupBox5.Text = "Write Bits";
            // 
            // Dropdown_Rom_Ids
            // 
            this.Dropdown_Rom_Ids.BackColor = System.Drawing.Color.White;
            this.Dropdown_Rom_Ids.DropDownHeight = 200;
            this.Dropdown_Rom_Ids.DropDownWidth = 0;
            this.Dropdown_Rom_Ids.Location = new System.Drawing.Point(32, 148);
            this.Dropdown_Rom_Ids.Name = "Dropdown_Rom_Ids";
            this.Dropdown_Rom_Ids.Size = new System.Drawing.Size(173, 21);
            this.Dropdown_Rom_Ids.TabIndex = 11;
            this.Dropdown_Rom_Ids.Text = "Rom ID\'s Found";
            this.Dropdown_Rom_Ids.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Dropdown_Rom_Ids.TextAlignDropDownList = System.Windows.Forms.HorizontalAlignment.Left;
            this.Dropdown_Rom_Ids.SelectedIndexChanged += new System.EventHandler(this.Dropdown_Rom_Ids_SelectedIndexChanged);
            // 
            // maximStatusStrip1
            // 
            this.maximStatusStrip1.Location = new System.Drawing.Point(0, 544);
            this.maximStatusStrip1.Name = "maximStatusStrip1";
            this.maximStatusStrip1.SectionsNumberOf = 3;
            this.maximStatusStrip1.SectionUseStatusProgressBar = false;
            this.maximStatusStrip1.Size = new System.Drawing.Size(1088, 22);
            this.maximStatusStrip1.TabIndex = 12;
            this.maximStatusStrip1.Text = "maximStatusStrip1";
            // 
            // findRomIDs
            // 
            this.findRomIDs.Location = new System.Drawing.Point(32, 38);
            this.findRomIDs.Name = "findRomIDs";
            this.findRomIDs.Size = new System.Drawing.Size(173, 44);
            this.findRomIDs.TabIndex = 14;
            this.findRomIDs.Text = "Standard Search";
            this.findRomIDs.UseVisualStyleBackColor = true;
            this.findRomIDs.Click += new System.EventHandler(this.FindRomIDs_Click);
            // 
            // maximGroupBox2
            // 
            this.maximGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maximGroupBox2.BackgroundColor = System.Drawing.Color.White;
            this.maximGroupBox2.Controls.Add(this.Button_Alarm_Search);
            this.maximGroupBox2.Controls.Add(this.findRomIDs);
            this.maximGroupBox2.Controls.Add(this.Dropdown_Rom_Ids);
            this.maximGroupBox2.Location = new System.Drawing.Point(3, 4);
            this.maximGroupBox2.Name = "maximGroupBox2";
            this.maximGroupBox2.Size = new System.Drawing.Size(254, 191);
            this.maximGroupBox2.TabIndex = 10;
            this.maximGroupBox2.TabStop = false;
            this.maximGroupBox2.Text = "Bus Search";
            // 
            // Button_Alarm_Search
            // 
            this.Button_Alarm_Search.Location = new System.Drawing.Point(32, 92);
            this.Button_Alarm_Search.Name = "Button_Alarm_Search";
            this.Button_Alarm_Search.Size = new System.Drawing.Size(173, 44);
            this.Button_Alarm_Search.TabIndex = 15;
            this.Button_Alarm_Search.Text = "Alarm Search";
            this.Button_Alarm_Search.UseVisualStyleBackColor = true;
            this.Button_Alarm_Search.Click += new System.EventHandler(this.Button_Alarm_Search_Click);
            // 
            // maximGroupBox3
            // 
            this.maximGroupBox3.BackgroundColor = System.Drawing.Color.White;
            this.maximGroupBox3.Controls.Add(this.tableLayoutPanel3);
            this.maximGroupBox3.Location = new System.Drawing.Point(3, 3);
            this.maximGroupBox3.Name = "maximGroupBox3";
            this.maximGroupBox3.Size = new System.Drawing.Size(266, 482);
            this.maximGroupBox3.TabIndex = 9;
            this.maximGroupBox3.TabStop = false;
            this.maximGroupBox3.Text = "1) ROM Commands";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.ButtonReset, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.maximGroupBox2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.maximGroupBox1, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.46988F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.53012F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(260, 466);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.deviceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1088, 24);
            this.menuStrip2.TabIndex = 16;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // deviceToolStripMenuItem
            // 
            this.deviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            this.deviceToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.deviceToolStripMenuItem.Text = "Device";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.23118F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.76882F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 343F));
            this.tableLayoutPanel1.Controls.Add(this.Write_Bytes_Box, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.maximGroupBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.maximGroupBox4, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1088, 489);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // maximGroupBox4
            // 
            this.maximGroupBox4.BackgroundColor = System.Drawing.Color.White;
            this.maximGroupBox4.Controls.Add(this.OutputText);
            this.maximGroupBox4.Location = new System.Drawing.Point(747, 3);
            this.maximGroupBox4.Name = "maximGroupBox4";
            this.maximGroupBox4.Size = new System.Drawing.Size(338, 482);
            this.maximGroupBox4.TabIndex = 10;
            this.maximGroupBox4.TabStop = false;
            this.maximGroupBox4.Text = "3) Device Output";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 566);
            this.Controls.Add(this.maximStatusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mainform";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MAX32630 1-Wire Interface";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.Shown += new System.EventHandler(this.Mainform_Shown);
            this.maximGroupBox1.ResumeLayout(false);
            this.maximGroupBox1.PerformLayout();
            this.Write_Bytes_Box.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Box_PU_Options.ResumeLayout(false);
            this.Box_PU_Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pullup_Indicator)).EndInit();
            this.Speed_Select_Box.ResumeLayout(false);
            this.Speed_Select_Box.PerformLayout();
            this.Box_Read.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.maximGroupBox5.ResumeLayout(false);
            this.maximGroupBox2.ResumeLayout(false);
            this.maximGroupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.maximGroupBox4.ResumeLayout(false);
            this.maximGroupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaximStyle.MaximGroupBox maximGroupBox1;
        private MaximStyle.MaximRadioButton Skip_ROM;
        private MaximStyle.MaximRadioButton Match_ROM;
        private MaximStyle.MaximRadioButton Resume;
        private MaximStyle.MaximRadioButton OD_Skip_ROM;
        private MaximStyle.MaximRadioButton Read_ROM;
        private MaximStyle.MaximRadioButton OD_Match_ROM;
        private MaximStyle.MaximButton Button_Send_ROM;
        private System.Windows.Forms.TextBox OutputText;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox InputText;
        private MaximStyle.MaximButton ButtonReset;
        private MaximStyle.MaximButton Button_Write_1;
        private MaximStyle.MaximButton Button_Write_0;
        private MaximStyle.MaximGroupBox Write_Bytes_Box;
        private MaximStyle.MaximGroupBox Box_Read;
        private System.Windows.Forms.Label label1;
        private MaximStyle.MaximNumericUpDown maximNumericUpDown1;
        private MaximStyle.MaximButton Button_Read_Bit;
        private MaximStyle.MaximGroupBox Speed_Select_Box;
        private MaximStyle.MaximButton Button_Send_Speed;
        private MaximStyle.MaximRadioButton Button_Speed_OD;
        private MaximStyle.MaximRadioButton Button_Speed_Norm;
        private MaximStyle.MaximGroupBox Box_PU_Options;
        private MaximStyle.MaximButton Button_Send_Power;
        private MaximStyle.MaximRadioButton Pullup_Normal;
        private MaximStyle.MaximButton Button_Read_Bytes;
        private MaximStyle.MaximRadioButton Pullup_Write_Bit;
        private MaximStyle.MaximRadioButton Pullup_Write_Byte;
        private MaximStyle.MaximComboBox Dropdown_Rom_Ids;
        private MaximStyle.MaximStatusStrip maximStatusStrip1;
        private MaximStyle.MaximButton findRomIDs;
        private MaximStyle.MaximGroupBox maximGroupBox2;
        private MaximStyle.MaximButton Button_Alarm_Search;
        private MaximStyle.MaximGroupBox maximGroupBox3;
        private System.Windows.Forms.Label label2;
        private MaximStyle.MaximStatusIndicator Pullup_Indicator;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaximStyle.MaximGroupBox maximGroupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private MaximStyle.MaximGroupBox maximGroupBox5;
    }
}

