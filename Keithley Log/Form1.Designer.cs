namespace Keithley_Log
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbButton10 = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.lbButton9 = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbButton8 = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.lbButton7 = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.lbButton6 = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.lbButton5 = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.lbButton4 = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.lbButton3 = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.lbButton2 = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.lbButton1 = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.lbDigitalMeter1 = new LBSoft.IndustrialCtrls.Meters.LBDigitalMeter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.domainUpDown3 = new System.Windows.Forms.DomainUpDown();
            this.led2 = new TH.WinComponents.Led();
            this.lbButton13 = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.led4 = new TH.WinComponents.Led();
            this.lbButton14 = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.lbButton15 = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbButton16 = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.led1 = new TH.WinComponents.Led();
            this.lbButton11 = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbButton10);
            this.groupBox1.Controls.Add(this.lbButton9);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(352, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(61, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Range";
            // 
            // lbButton10
            // 
            this.lbButton10.BackColor = System.Drawing.Color.Transparent;
            this.lbButton10.ButtonColor = System.Drawing.Color.LightGray;
            this.lbButton10.Enabled = false;
            this.lbButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbButton10.Label = "▼";
            this.lbButton10.Location = new System.Drawing.Point(6, 89);
            this.lbButton10.Name = "lbButton10";
            this.lbButton10.Renderer = null;
            this.lbButton10.RepeatInterval = 100;
            this.lbButton10.RepeatState = false;
            this.lbButton10.Size = new System.Drawing.Size(49, 29);
            this.lbButton10.StartRepeatInterval = 500;
            this.lbButton10.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.lbButton10.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Rectangular;
            this.lbButton10.TabIndex = 12;
            this.lbButton10.Tag = "▼";
            this.lbButton10.Click += new System.EventHandler(this.lbButton10_Click);
            // 
            // lbButton9
            // 
            this.lbButton9.BackColor = System.Drawing.Color.Transparent;
            this.lbButton9.ButtonColor = System.Drawing.Color.LightGray;
            this.lbButton9.Enabled = false;
            this.lbButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbButton9.Label = "▲";
            this.lbButton9.Location = new System.Drawing.Point(6, 19);
            this.lbButton9.Name = "lbButton9";
            this.lbButton9.Renderer = null;
            this.lbButton9.RepeatInterval = 100;
            this.lbButton9.RepeatState = false;
            this.lbButton9.Size = new System.Drawing.Size(49, 29);
            this.lbButton9.StartRepeatInterval = 500;
            this.lbButton9.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.lbButton9.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Rectangular;
            this.lbButton9.TabIndex = 11;
            this.lbButton9.Tag = "";
            this.lbButton9.Click += new System.EventHandler(this.lbButton9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1000V";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbButton8);
            this.groupBox2.Controls.Add(this.lbButton7);
            this.groupBox2.Controls.Add(this.lbButton6);
            this.groupBox2.Controls.Add(this.lbButton5);
            this.groupBox2.Controls.Add(this.lbButton4);
            this.groupBox2.Controls.Add(this.lbButton3);
            this.groupBox2.Controls.Add(this.lbButton2);
            this.groupBox2.Controls.Add(this.lbButton1);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Read Value";
            // 
            // lbButton8
            // 
            this.lbButton8.BackColor = System.Drawing.Color.Transparent;
            this.lbButton8.ButtonColor = System.Drawing.Color.LightGray;
            this.lbButton8.Enabled = false;
            this.lbButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbButton8.Label = "TEM";
            this.lbButton8.Location = new System.Drawing.Point(293, 20);
            this.lbButton8.Name = "lbButton8";
            this.lbButton8.Renderer = null;
            this.lbButton8.RepeatInterval = 100;
            this.lbButton8.RepeatState = false;
            this.lbButton8.Size = new System.Drawing.Size(35, 35);
            this.lbButton8.StartRepeatInterval = 500;
            this.lbButton8.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.lbButton8.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.lbButton8.TabIndex = 10;
            this.lbButton8.ButtonChangeState += new LBSoft.IndustrialCtrls.Buttons.ButtonChangeState(this.lbButton8_ButtonChangeState);
            // 
            // lbButton7
            // 
            this.lbButton7.BackColor = System.Drawing.Color.Transparent;
            this.lbButton7.ButtonColor = System.Drawing.Color.LightGray;
            this.lbButton7.Enabled = false;
            this.lbButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbButton7.Label = "FRE";
            this.lbButton7.Location = new System.Drawing.Point(252, 20);
            this.lbButton7.Name = "lbButton7";
            this.lbButton7.Renderer = null;
            this.lbButton7.RepeatInterval = 100;
            this.lbButton7.RepeatState = false;
            this.lbButton7.Size = new System.Drawing.Size(35, 35);
            this.lbButton7.StartRepeatInterval = 500;
            this.lbButton7.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.lbButton7.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.lbButton7.TabIndex = 9;
            this.lbButton7.ButtonChangeState += new LBSoft.IndustrialCtrls.Buttons.ButtonChangeState(this.lbButton7_ButtonChangeState);
            // 
            // lbButton6
            // 
            this.lbButton6.BackColor = System.Drawing.Color.Transparent;
            this.lbButton6.ButtonColor = System.Drawing.Color.LightGray;
            this.lbButton6.Enabled = false;
            this.lbButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbButton6.Label = "O4";
            this.lbButton6.Location = new System.Drawing.Point(211, 20);
            this.lbButton6.Name = "lbButton6";
            this.lbButton6.Renderer = null;
            this.lbButton6.RepeatInterval = 100;
            this.lbButton6.RepeatState = false;
            this.lbButton6.Size = new System.Drawing.Size(35, 35);
            this.lbButton6.StartRepeatInterval = 500;
            this.lbButton6.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.lbButton6.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.lbButton6.TabIndex = 8;
            this.lbButton6.ButtonChangeState += new LBSoft.IndustrialCtrls.Buttons.ButtonChangeState(this.lbButton6_ButtonChangeState);
            // 
            // lbButton5
            // 
            this.lbButton5.BackColor = System.Drawing.Color.Transparent;
            this.lbButton5.ButtonColor = System.Drawing.Color.LightGray;
            this.lbButton5.Enabled = false;
            this.lbButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbButton5.Label = "O2";
            this.lbButton5.Location = new System.Drawing.Point(170, 20);
            this.lbButton5.Name = "lbButton5";
            this.lbButton5.Renderer = null;
            this.lbButton5.RepeatInterval = 100;
            this.lbButton5.RepeatState = false;
            this.lbButton5.Size = new System.Drawing.Size(35, 35);
            this.lbButton5.StartRepeatInterval = 500;
            this.lbButton5.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.lbButton5.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.lbButton5.TabIndex = 7;
            this.lbButton5.ButtonChangeState += new LBSoft.IndustrialCtrls.Buttons.ButtonChangeState(this.lbButton5_ButtonChangeState);
            // 
            // lbButton4
            // 
            this.lbButton4.BackColor = System.Drawing.Color.Transparent;
            this.lbButton4.ButtonColor = System.Drawing.Color.LightGray;
            this.lbButton4.Enabled = false;
            this.lbButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbButton4.Label = "ACI";
            this.lbButton4.Location = new System.Drawing.Point(129, 20);
            this.lbButton4.Name = "lbButton4";
            this.lbButton4.Renderer = null;
            this.lbButton4.RepeatInterval = 100;
            this.lbButton4.RepeatState = false;
            this.lbButton4.Size = new System.Drawing.Size(35, 35);
            this.lbButton4.StartRepeatInterval = 500;
            this.lbButton4.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.lbButton4.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.lbButton4.TabIndex = 6;
            this.lbButton4.ButtonChangeState += new LBSoft.IndustrialCtrls.Buttons.ButtonChangeState(this.lbButton4_ButtonChangeState);
            // 
            // lbButton3
            // 
            this.lbButton3.BackColor = System.Drawing.Color.Transparent;
            this.lbButton3.ButtonColor = System.Drawing.Color.LightGray;
            this.lbButton3.Enabled = false;
            this.lbButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbButton3.Label = "DCI";
            this.lbButton3.Location = new System.Drawing.Point(88, 20);
            this.lbButton3.Name = "lbButton3";
            this.lbButton3.Renderer = null;
            this.lbButton3.RepeatInterval = 100;
            this.lbButton3.RepeatState = false;
            this.lbButton3.Size = new System.Drawing.Size(35, 35);
            this.lbButton3.StartRepeatInterval = 500;
            this.lbButton3.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.lbButton3.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.lbButton3.TabIndex = 5;
            this.lbButton3.ButtonChangeState += new LBSoft.IndustrialCtrls.Buttons.ButtonChangeState(this.lbButton3_ButtonChangeState);
            // 
            // lbButton2
            // 
            this.lbButton2.BackColor = System.Drawing.Color.Transparent;
            this.lbButton2.ButtonColor = System.Drawing.Color.LightGray;
            this.lbButton2.Enabled = false;
            this.lbButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbButton2.Label = "ACV";
            this.lbButton2.Location = new System.Drawing.Point(47, 20);
            this.lbButton2.Name = "lbButton2";
            this.lbButton2.Renderer = null;
            this.lbButton2.RepeatInterval = 100;
            this.lbButton2.RepeatState = false;
            this.lbButton2.Size = new System.Drawing.Size(35, 35);
            this.lbButton2.StartRepeatInterval = 500;
            this.lbButton2.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.lbButton2.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.lbButton2.TabIndex = 4;
            this.lbButton2.ButtonChangeState += new LBSoft.IndustrialCtrls.Buttons.ButtonChangeState(this.lbButton2_ButtonChangeState);
            // 
            // lbButton1
            // 
            this.lbButton1.BackColor = System.Drawing.Color.Transparent;
            this.lbButton1.ButtonColor = System.Drawing.Color.LightGray;
            this.lbButton1.Enabled = false;
            this.lbButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbButton1.Label = "DCV";
            this.lbButton1.Location = new System.Drawing.Point(6, 20);
            this.lbButton1.Name = "lbButton1";
            this.lbButton1.Renderer = null;
            this.lbButton1.RepeatInterval = 100;
            this.lbButton1.RepeatState = false;
            this.lbButton1.Size = new System.Drawing.Size(35, 35);
            this.lbButton1.StartRepeatInterval = 500;
            this.lbButton1.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Pressed;
            this.lbButton1.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.lbButton1.TabIndex = 3;
            this.lbButton1.ButtonChangeState += new LBSoft.IndustrialCtrls.Buttons.ButtonChangeState(this.lbButton1_ButtonChangeState);
            // 
            // lbDigitalMeter1
            // 
            this.lbDigitalMeter1.BackColor = System.Drawing.Color.Black;
            this.lbDigitalMeter1.ForeColor = System.Drawing.Color.Red;
            this.lbDigitalMeter1.Format = "00000000";
            this.lbDigitalMeter1.Location = new System.Drawing.Point(12, 12);
            this.lbDigitalMeter1.Name = "lbDigitalMeter1";
            this.lbDigitalMeter1.Renderer = null;
            this.lbDigitalMeter1.Signed = true;
            this.lbDigitalMeter1.Size = new System.Drawing.Size(334, 52);
            this.lbDigitalMeter1.TabIndex = 2;
            this.lbDigitalMeter1.Value = 0D;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.led2);
            this.groupBox3.Controls.Add(this.lbButton13);
            this.groupBox3.Location = new System.Drawing.Point(12, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 76);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.domainUpDown3);
            this.groupBox8.Location = new System.Drawing.Point(6, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(51, 51);
            this.groupBox8.TabIndex = 20;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Digits";
            // 
            // domainUpDown3
            // 
            this.domainUpDown3.Items.Add("4");
            this.domainUpDown3.Items.Add("5");
            this.domainUpDown3.Items.Add("6");
            this.domainUpDown3.Items.Add("7");
            this.domainUpDown3.Items.Add("8");
            this.domainUpDown3.Location = new System.Drawing.Point(6, 19);
            this.domainUpDown3.Name = "domainUpDown3";
            this.domainUpDown3.Size = new System.Drawing.Size(39, 20);
            this.domainUpDown3.Sorted = true;
            this.domainUpDown3.TabIndex = 18;
            this.domainUpDown3.Text = "8";
            this.domainUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.domainUpDown3.SelectedItemChanged += new System.EventHandler(this.domainUpDown3_SelectedItemChanged);
            // 
            // led2
            // 
            this.led2.Active = false;
            this.led2.BackColor = System.Drawing.Color.Transparent;
            this.led2.ColorOff = System.Drawing.Color.Red;
            this.led2.ColorOn = System.Drawing.Color.Chartreuse;
            this.led2.Location = new System.Drawing.Point(80, 20);
            this.led2.Name = "led2";
            this.led2.Size = new System.Drawing.Size(17, 17);
            this.led2.TabIndex = 17;
            this.led2.Text = "led2";
            // 
            // lbButton13
            // 
            this.lbButton13.BackColor = System.Drawing.Color.Transparent;
            this.lbButton13.ButtonColor = System.Drawing.Color.LightGray;
            this.lbButton13.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbButton13.Label = "FILTER";
            this.lbButton13.Location = new System.Drawing.Point(63, 43);
            this.lbButton13.Name = "lbButton13";
            this.lbButton13.Renderer = null;
            this.lbButton13.RepeatInterval = 100;
            this.lbButton13.RepeatState = false;
            this.lbButton13.Size = new System.Drawing.Size(50, 24);
            this.lbButton13.StartRepeatInterval = 500;
            this.lbButton13.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.lbButton13.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Rectangular;
            this.lbButton13.TabIndex = 15;
            this.lbButton13.Tag = "▼";
            this.lbButton13.Click += new System.EventHandler(this.lbButton13_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(352, 142);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(179, 76);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Read Settings";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(38, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "100";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(38, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "340";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reading Count = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reading Frequency (ms) = ";
            // 
            // led4
            // 
            this.led4.Active = false;
            this.led4.BackColor = System.Drawing.Color.Transparent;
            this.led4.ColorOff = System.Drawing.Color.Red;
            this.led4.ColorOn = System.Drawing.Color.Chartreuse;
            this.led4.Location = new System.Drawing.Point(6, 23);
            this.led4.Name = "led4";
            this.led4.Size = new System.Drawing.Size(17, 17);
            this.led4.TabIndex = 18;
            this.led4.Text = "led4";
            // 
            // lbButton14
            // 
            this.lbButton14.BackColor = System.Drawing.Color.Transparent;
            this.lbButton14.ButtonColor = System.Drawing.Color.LightGray;
            this.lbButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbButton14.Label = "SAVE";
            this.lbButton14.Location = new System.Drawing.Point(29, 19);
            this.lbButton14.Name = "lbButton14";
            this.lbButton14.Renderer = null;
            this.lbButton14.RepeatInterval = 100;
            this.lbButton14.RepeatState = false;
            this.lbButton14.Size = new System.Drawing.Size(77, 24);
            this.lbButton14.StartRepeatInterval = 500;
            this.lbButton14.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.lbButton14.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Rectangular;
            this.lbButton14.TabIndex = 19;
            this.lbButton14.Tag = "▼";
            this.lbButton14.Click += new System.EventHandler(this.lbButton14_Click);
            // 
            // lbButton15
            // 
            this.lbButton15.BackColor = System.Drawing.Color.Transparent;
            this.lbButton15.ButtonColor = System.Drawing.Color.LightGray;
            this.lbButton15.Enabled = false;
            this.lbButton15.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbButton15.Label = "AUTOMATIC";
            this.lbButton15.Location = new System.Drawing.Point(6, 16);
            this.lbButton15.Name = "lbButton15";
            this.lbButton15.Renderer = null;
            this.lbButton15.RepeatInterval = 100;
            this.lbButton15.RepeatState = false;
            this.lbButton15.Size = new System.Drawing.Size(88, 22);
            this.lbButton15.StartRepeatInterval = 500;
            this.lbButton15.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.lbButton15.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Rectangular;
            this.lbButton15.TabIndex = 20;
            this.lbButton15.Tag = "▼";
            this.lbButton15.Click += new System.EventHandler(this.lbButton15_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.lbButton14);
            this.groupBox5.Controls.Add(this.led4);
            this.groupBox5.Location = new System.Drawing.Point(419, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(112, 124);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Save Settings";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbButton15);
            this.groupBox6.Controls.Add(this.lbButton16);
            this.groupBox6.Location = new System.Drawing.Point(6, 49);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(100, 69);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "REad";
            // 
            // lbButton16
            // 
            this.lbButton16.BackColor = System.Drawing.Color.Transparent;
            this.lbButton16.ButtonColor = System.Drawing.Color.LightGray;
            this.lbButton16.Enabled = false;
            this.lbButton16.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbButton16.Label = "MANUEL";
            this.lbButton16.Location = new System.Drawing.Point(6, 41);
            this.lbButton16.Name = "lbButton16";
            this.lbButton16.Renderer = null;
            this.lbButton16.RepeatInterval = 100;
            this.lbButton16.RepeatState = false;
            this.lbButton16.Size = new System.Drawing.Size(88, 22);
            this.lbButton16.StartRepeatInterval = 500;
            this.lbButton16.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.lbButton16.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Rectangular;
            this.lbButton16.TabIndex = 21;
            this.lbButton16.Tag = "▼";
            this.lbButton16.Click += new System.EventHandler(this.lbButton16_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 232);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(542, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(138, 17);
            this.toolStripStatusLabel1.Text = "Number Of Readings = 0";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.led1);
            this.groupBox9.Controls.Add(this.lbButton11);
            this.groupBox9.Controls.Add(this.label4);
            this.groupBox9.Controls.Add(this.comboBox2);
            this.groupBox9.Controls.Add(this.label3);
            this.groupBox9.Controls.Add(this.comboBox1);
            this.groupBox9.Location = new System.Drawing.Point(141, 143);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(205, 75);
            this.groupBox9.TabIndex = 23;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Port Settings";
            // 
            // led1
            // 
            this.led1.Active = false;
            this.led1.BackColor = System.Drawing.SystemColors.Control;
            this.led1.ColorOff = System.Drawing.Color.Red;
            this.led1.ColorOn = System.Drawing.Color.LawnGreen;
            this.led1.Location = new System.Drawing.Point(6, 21);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(16, 16);
            this.led1.TabIndex = 21;
            this.led1.Text = "led1";
            // 
            // lbButton11
            // 
            this.lbButton11.BackColor = System.Drawing.Color.Transparent;
            this.lbButton11.ButtonColor = System.Drawing.Color.LightGray;
            this.lbButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbButton11.Label = "Open";
            this.lbButton11.Location = new System.Drawing.Point(134, 18);
            this.lbButton11.Name = "lbButton11";
            this.lbButton11.Renderer = null;
            this.lbButton11.RepeatInterval = 100;
            this.lbButton11.RepeatState = false;
            this.lbButton11.Size = new System.Drawing.Size(65, 48);
            this.lbButton11.StartRepeatInterval = 500;
            this.lbButton11.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.lbButton11.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Rectangular;
            this.lbButton11.TabIndex = 20;
            this.lbButton11.Tag = "▼";
            this.lbButton11.Click += new System.EventHandler(this.lbButton11_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Baud =";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "19200",
            "9600",
            "4800",
            "2400",
            "1200",
            "600",
            "300"});
            this.comboBox2.Location = new System.Drawing.Point(68, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(60, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Text = "19200";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Port =";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 340;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "CVS file (*.cvs)|*.cvs";
            this.saveFileDialog1.Title = "Dosyayı Nereye Kaydedeceksiniz ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 254);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbDigitalMeter1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keithley Multimeter Logger";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private LBSoft.IndustrialCtrls.Buttons.LBButton lbButton1;
        private LBSoft.IndustrialCtrls.Buttons.LBButton lbButton8;
        private LBSoft.IndustrialCtrls.Buttons.LBButton lbButton7;
        private LBSoft.IndustrialCtrls.Buttons.LBButton lbButton6;
        private LBSoft.IndustrialCtrls.Buttons.LBButton lbButton5;
        private LBSoft.IndustrialCtrls.Buttons.LBButton lbButton4;
        private LBSoft.IndustrialCtrls.Buttons.LBButton lbButton3;
        private LBSoft.IndustrialCtrls.Buttons.LBButton lbButton2;
        private LBSoft.IndustrialCtrls.Buttons.LBButton lbButton9;
        private System.Windows.Forms.TextBox textBox1;
        private LBSoft.IndustrialCtrls.Buttons.LBButton lbButton10;
        private System.Windows.Forms.GroupBox groupBox3;
        private TH.WinComponents.Led led2;
        private LBSoft.IndustrialCtrls.Buttons.LBButton lbButton13;
        private System.Windows.Forms.GroupBox groupBox4;
        private LBSoft.IndustrialCtrls.Buttons.LBButton lbButton14;
        private TH.WinComponents.Led led4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private LBSoft.IndustrialCtrls.Buttons.LBButton lbButton15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private LBSoft.IndustrialCtrls.Buttons.LBButton lbButton16;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DomainUpDown domainUpDown3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private TH.WinComponents.Led led1;
        private LBSoft.IndustrialCtrls.Buttons.LBButton lbButton11;
        private LBSoft.IndustrialCtrls.Meters.LBDigitalMeter lbDigitalMeter1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

