using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using DataStreams.Csv;

namespace Keithley_Log
{
    public partial class Form1 : Form
    {
        AboutBox1 AboutForm = new AboutBox1();
        string[,] range = new string[9, 11];
        int activeRange = 1, whichRange = 1, counter = 1, oldCounter = 0;
        string InputData, Last;
        bool automatic = false;
        CsvWriter writer;

        public delegate void ekle(string text);

        public Form1()
        {
            InitializeComponent();

            string[] _ports = SerialPort.GetPortNames();

            foreach (string port in _ports)
            {
                comboBox1.Items.Add(port);
            }

            if (comboBox1.Items.Count > 0)
                comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetButtonsActivate(false);

            butun_butonlar_state_normal();
            lbButton1.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Pressed;
            domainUpDown3.SelectedIndex = 4;

            range[1, 1] = "1000V";
            range[1, 2] = "100V";
            range[1, 3] = "10V";
            range[1, 4] = "1V";
            range[1, 5] = "0.1V";
            range[1, 10] = "5";

            range[2, 1] = "750V";
            range[2, 2] = "100V";
            range[2, 3] = "10V";
            range[2, 4] = "1V";
            range[2, 5] = "0.1V";
            range[2, 10] = "5";

            range[3, 1] = "3A";
            range[3, 2] = "1A";
            range[3, 3] = "0.1A";
            range[3, 4] = "0.01A";
            range[3, 10] = "4";

            range[4, 1] = "3A";
            range[4, 2] = "1A";
            range[4, 10] = "2";

            range[5, 1] = "100M";
            range[5, 2] = "10M";
            range[5, 3] = "1M";
            range[5, 4] = "100K";
            range[5, 5] = "10K";
            range[5, 6] = "1K";
            range[5, 7] = "100";
            range[5, 8] = "10";
            range[5, 10] = "8";

            range[6, 1] = "100M";
            range[6, 2] = "10M";
            range[6, 3] = "1M";
            range[6, 4] = "100K";
            range[6, 5] = "10K";
            range[6, 6] = "1K";
            range[6, 7] = "100";
            range[6, 8] = "10";
            range[6, 10] = "8";

            range[7, 1] = "1000V";
            range[7, 2] = "100V";
            range[7, 3] = "10V";
            range[7, 4] = "1V";
            range[7, 5] = "0.1V";
            range[7, 10] = "5";

            range[8, 1] = "Auto";
            range[8, 10] = "1";
        }

        void aktifrange()
        {
            if (lbButton1.State == LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Pressed) activeRange = 1;
            if (lbButton2.State == LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Pressed) activeRange = 2;
            if (lbButton3.State == LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Pressed) activeRange = 3;
            if (lbButton4.State == LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Pressed) activeRange = 4;
            if (lbButton5.State == LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Pressed) activeRange = 5;
            if (lbButton6.State == LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Pressed) activeRange = 6;
            if (lbButton7.State == LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Pressed) activeRange = 7;
            if (lbButton8.State == LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Pressed) activeRange = 8;
            whichRange = 1;
            textBox1.Text = range[activeRange, whichRange];
        }

        public void butun_butonlar_state_normal()
        {
            lbButton1.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            lbButton2.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            lbButton3.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            lbButton4.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            lbButton5.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            lbButton6.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            lbButton7.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            lbButton8.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
        }
        private void lbButton1_ButtonChangeState(object sender, LBSoft.IndustrialCtrls.Buttons.LBButtonEventArgs e)
        {
            butun_butonlar_state_normal();


            if (lbButton1.State == LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal)
            {
                lbButton1.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Pressed;

                if (serialPort1.IsOpen)
                    serialPort1.WriteLine(":func 'volt:dc'");
            }

            aktifrange();
            domainUpDown3.Enabled = true;
            domainUpDown3.Items.Clear();
            string[] gecici = { "4", "5", "6", "7", "8" };
            domainUpDown3.Items.AddRange(gecici);
            domainUpDown3.Text = Properties.Settings.Default.dc1.ToString();
            led2.Active = Convert.ToBoolean(Properties.Settings.Default.dc2);
            whichRange = Convert.ToInt16(Properties.Settings.Default.dc3);
            SetRange();
            SetFilter();
            SetDisplayDigit();
        }
        private void lbButton2_ButtonChangeState(object sender, LBSoft.IndustrialCtrls.Buttons.LBButtonEventArgs e)
        {
            butun_butonlar_state_normal();
            if (lbButton2.State == LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal)
            { lbButton2.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Pressed; if (serialPort1.IsOpen) serialPort1.WriteLine(":sens:func 'volt:ac'"); }
            aktifrange();
            domainUpDown3.Enabled = true;
            domainUpDown3.Items.Clear();
            string[] gecici = { "4", "5", "6", "7" };
            domainUpDown3.Items.AddRange(gecici);
            domainUpDown3.Text = Properties.Settings.Default.ac1.ToString();
            led2.Active = Convert.ToBoolean(Properties.Settings.Default.ac2);
            whichRange = Convert.ToInt16(Properties.Settings.Default.ac3);
            SetRange();
            SetFilter();
            SetDisplayDigit();

        }
        private void lbButton3_ButtonChangeState(object sender, LBSoft.IndustrialCtrls.Buttons.LBButtonEventArgs e)
        {
            butun_butonlar_state_normal();
            if (lbButton3.State == LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal) { lbButton3.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Pressed; if (serialPort1.IsOpen) serialPort1.WriteLine(":sens:func 'curr:dc'"); }
            aktifrange();
            domainUpDown3.Enabled = true;
            domainUpDown3.Items.Clear();
            string[] gecici = { "4", "5", "6", "7", "8" };
            domainUpDown3.Items.AddRange(gecici);
            domainUpDown3.Text = Properties.Settings.Default.dci1.ToString();
            led2.Active = Convert.ToBoolean(Properties.Settings.Default.dci2);
            whichRange = Convert.ToInt16(Properties.Settings.Default.dci3);
            SetRange();
            SetFilter();
            SetDisplayDigit();
        }
        private void lbButton4_ButtonChangeState(object sender, LBSoft.IndustrialCtrls.Buttons.LBButtonEventArgs e)
        {
            butun_butonlar_state_normal();
            if (lbButton4.State == LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal) { lbButton4.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Pressed; if (serialPort1.IsOpen) serialPort1.WriteLine("func 'curr:ac'"); }
            aktifrange();
            domainUpDown3.Enabled = true;
            domainUpDown3.Items.Clear();
            string[] gecici = { "4", "5", "6", "7" };
            domainUpDown3.Items.AddRange(gecici);
            domainUpDown3.Text = Properties.Settings.Default.aci1.ToString();
            led2.Active = Convert.ToBoolean(Properties.Settings.Default.aci2);
            whichRange = Convert.ToInt16(Properties.Settings.Default.aci3);
            SetRange();
            SetFilter();
            SetDisplayDigit();
        }
        private void lbButton5_ButtonChangeState(object sender, LBSoft.IndustrialCtrls.Buttons.LBButtonEventArgs e)
        {
            butun_butonlar_state_normal();
            if (lbButton5.State == LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal) { lbButton5.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Pressed; if (serialPort1.IsOpen) serialPort1.WriteLine("func 'res'"); }
            aktifrange();
            domainUpDown3.Enabled = true;
            domainUpDown3.Items.Clear();
            string[] gecici = { "4", "5", "6", "7", "8" };
            domainUpDown3.Items.AddRange(gecici);
            domainUpDown3.Text = Properties.Settings.Default.o1.ToString();
            led2.Active = Convert.ToBoolean(Properties.Settings.Default.o2);
            whichRange = Convert.ToInt16(Properties.Settings.Default.o3);
            SetRange();
            SetFilter();
            SetDisplayDigit();
        }

        private void lbButton6_ButtonChangeState(object sender, LBSoft.IndustrialCtrls.Buttons.LBButtonEventArgs e)
        {
            butun_butonlar_state_normal();
            if (lbButton6.State == LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal)
            {
                lbButton6.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Pressed;
                if (serialPort1.IsOpen)
                    serialPort1.WriteLine("func 'fres'");
            }

            aktifrange();
            domainUpDown3.Enabled = true;
            domainUpDown3.Items.Clear();
            string[] gecici = { "4", "5", "6", "7", "8" };
            domainUpDown3.Items.AddRange(gecici);
            domainUpDown3.Text = Properties.Settings.Default.oo1.ToString();
            led2.Active = Convert.ToBoolean(Properties.Settings.Default.oo2);
            whichRange = Convert.ToInt16(Properties.Settings.Default.oo3);
            SetRange();
            SetFilter();
            SetDisplayDigit();
        }

        private void lbButton7_ButtonChangeState(object sender, LBSoft.IndustrialCtrls.Buttons.LBButtonEventArgs e)
        {
            butun_butonlar_state_normal();
            if (lbButton7.State == LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal)
            {
                lbButton7.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Pressed;
                if (serialPort1.IsOpen)
                    serialPort1.WriteLine("func 'freq'");
            }

            aktifrange();
            domainUpDown3.Enabled = false;
            domainUpDown3.Text = Properties.Settings.Default.fre1.ToString();
            led2.Active = Convert.ToBoolean(Properties.Settings.Default.fre2);
            whichRange = Convert.ToInt16(Properties.Settings.Default.fre3);
            SetRange();
            SetFilter();
            SetDisplayDigit();
        }

        private void lbButton8_ButtonChangeState(object sender, LBSoft.IndustrialCtrls.Buttons.LBButtonEventArgs e)
        {
            butun_butonlar_state_normal();
            if (lbButton8.State == LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal)
            {
                lbButton8.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Pressed;
                if (serialPort1.IsOpen)
                    serialPort1.WriteLine("func 'temp'");
            }

            aktifrange();
            domainUpDown3.Enabled = true;
            domainUpDown3.Items.Clear();
            string[] gecici = { "4", "5", "6", "7" };
            domainUpDown3.Items.AddRange(gecici);
            domainUpDown3.Text = Properties.Settings.Default.temp1.ToString();
            led2.Active = Convert.ToBoolean(Properties.Settings.Default.temp2);
            whichRange = Convert.ToInt16(Properties.Settings.Default.temp3);
            SetRange();
            SetFilter();
            SetDisplayDigit();
        }


        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            AboutForm.ShowDialog();
        }

        private void lbButton10_Click(object sender, EventArgs e)
        {
            whichRange++;
            SetRange();

        }

        private void lbButton9_Click(object sender, EventArgs e)
        {
            whichRange--;
            SetRange();
        }


        private void RangeTextUpdate(string gg)
        {
            textBox1.Text = gg;
        }

        public void SetRange()
        {
            if (serialPort1.IsOpen && activeRange != 8)
            {
                if (whichRange == 0)
                    whichRange++;

                if (whichRange == Convert.ToInt16(range[activeRange, 10]) + 1)
                    whichRange--;

                RangeTextUpdate(range[activeRange, whichRange]);
                string gecici = "";
                if (activeRange == 1) { gecici = ":SENS:VOLT:DC:RANG"; Properties.Settings.Default.dc3 = whichRange.ToString(); }
                if (activeRange == 2) { gecici = ":SENS:VOLT:AC:RANG"; Properties.Settings.Default.ac3 = whichRange.ToString(); }
                if (activeRange == 3) { gecici = ":SENS:CURR:DC:RANG"; Properties.Settings.Default.dci3 = whichRange.ToString(); }
                if (activeRange == 4) { gecici = ":SENS:CURR:AC:RANG"; Properties.Settings.Default.aci3 = whichRange.ToString(); }
                if (activeRange == 5) { gecici = ":SENS:RES:RANG"; Properties.Settings.Default.o3 = whichRange.ToString(); }
                if (activeRange == 6) { gecici = ":SENS:FRES:RANG"; Properties.Settings.Default.oo3 = whichRange.ToString(); }
                if (activeRange == 7) { gecici = ":SENS:FREQ:THR:VOLT:RANG"; Properties.Settings.Default.fre3 = whichRange.ToString(); }
                if (activeRange == 8) { gecici = ":SENS:TEMP:RANG"; Properties.Settings.Default.temp3 = whichRange.ToString(); }

                if (textBox1.Text == "Auto")
                {
                    serialPort1.WriteLine(gecici + ":AUTO ON");
                    serialPort1.WriteLine(gecici + ":AUTO ON");
                }
                else
                {
                    if (activeRange != 7) serialPort1.WriteLine(gecici + ":AUTO OFF");
                    gecici = gecici + " " + textBox1.Text.Replace("V", "").Replace("A", "").Replace("M", "e6").Replace("K", "e3");
                    serialPort1.WriteLine(gecici);
                }
            }
            Properties.Settings.Default.Save();
        }

        public void SetButtonsActivate(bool ff)
        {
            lbButton15.Enabled = ff;
            lbButton16.Enabled = ff;
            lbButton9.Enabled = ff;
            lbButton10.Enabled = ff;
            lbButton1.Enabled = ff;
            lbButton2.Enabled = ff;
            lbButton3.Enabled = ff;
            lbButton4.Enabled = ff;
            lbButton5.Enabled = ff;
            lbButton6.Enabled = ff;
            lbButton7.Enabled = ff;
            lbButton8.Enabled = ff;
            lbButton13.Enabled = ff;
            domainUpDown3.Enabled = ff;
        }

        private void lbButton11_Click(object sender, EventArgs e)
        {
            if (led4.Active)
            {
                SetButtonsActivate(true);

            }
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.PortName = comboBox1.SelectedItem.ToString();
                    serialPort1.BaudRate = int.Parse(comboBox2.SelectedItem.ToString());
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.NewLine = "\r";
                    serialPort1.DataBits = 8;
                    serialPort1.Handshake = Handshake.None;

                    serialPort1.Open();
                    led1.Active = true;
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    lbButton11.Label = "Kapat";
                    serialPort1.WriteLine("*RST");
                    serialPort1.WriteLine("*CLS");
                    serialPort1.WriteLine(":FORM:ELEM READ");
                    SetRange();
                    SetDisplayDigit();
                    SetFilter();
                }
                catch
                {
                    MessageBox.Show("Serial port " + serialPort1.PortName + " cannot be opened!", "RS232 tester", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox1.SelectedText = "";
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    led1.Active = false;
                    comboBox1.Enabled = true;
                    comboBox2.Enabled = true;
                    lbButton11.Label = "Aç";
                }
                catch
                {
                    MessageBox.Show("Serial port " + serialPort1.PortName + " cannot be opened!", "RS232 tester", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox1.SelectedText = "";
                }
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            InputData = serialPort1.ReadLine();

        }

        private void lbButton16_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(":read?");
            timer1.Interval = Convert.ToInt16(textBox2.Text);
            timer1.Enabled = true;
            automatic = false;
            //serialPort1.WriteLine(":SENS:VOLT:DC:RANG:UPP?"); 
        }





        public bool WriteDisplay()
        {
            double ff = Convert.ToDouble(InputData);
            string firstMask;


            if (Convert.ToDouble(InputData) < 10000000000000000)
            {
                double gec3 = Convert.ToDouble(InputData) / 100000000;
                if (textBox1.Text.EndsWith("M")) gec3 = gec3 / 1000000;
                if (textBox1.Text.EndsWith("K")) gec3 = gec3 / 1000;
                //if (textBox1.Text.EndsWith("0.1V")) gec3 = gec3 * 10000;
                //if (gec3 < 0) gec3 = gec3 / 10;

                string _mask = "";
                string rangebu = textBox1.Text.Replace("V", "").Replace("75", "100").Replace("A", "").Replace("3", "10").Replace("M", "").Replace("K", "").Replace("uto", "0").Replace(".", ",");
                if (Convert.ToDouble(rangebu) >= 1)
                {
                    rangebu = rangebu.Replace("1", "0");
                    for (int i = 0; i < Convert.ToInt16(domainUpDown3.Text) - Convert.ToInt16(rangebu.Length); i++)
                    {
                        _mask += "0";
                    }
                    firstMask = rangebu;
                    //if (gec3 < 0) ilkmaske = ilkmaske.Substring(0, ilkmaske.Length - 1);
                }
                else
                {
                    if (activeRange != 8)
                    {
                        firstMask = "000";
                        if (activeRange == 1) _mask = "00000";
                        if (activeRange == 2) _mask = "0000";
                        gec3 = gec3 * 1000;
                    }
                    else
                    {
                        firstMask = "0000";

                        for (int i = 0; i < Convert.ToInt16(domainUpDown3.Text) - 4; i++)
                        {
                            _mask += "0";
                        }
                    }
                }


                Last = Convert.ToString(String.Format("{0:" + firstMask + "." + _mask + "}", gec3));
                lbDigitalMeter1.Format = firstMask + "." + _mask;

                lbDigitalMeter1.Value = gec3;

            }
            else { whichRange--; SetRange(); return false; }
            return true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            bool sonuc = WriteDisplay();
            if (sonuc)
            {
                counter++;
                if (counter <= oldCounter + Convert.ToInt16(textBox3.Text) || !automatic)
                {
                    toolStripProgressBar1.Value = 100;
                    writer.Write(counter.ToString(), true);
                    writer.Write(DateTime.Now.ToString("HH:mm:ss"), true);
                    writer.Write(lbDigitalMeter1.Value.ToString("0.00000"), true);
                    writer.WriteComment("");
                    if (automatic) serialPort1.WriteLine(":read?");
                    else { timer1.Enabled = false; }
                    toolStripStatusLabel1.Text = toolStripStatusLabel1.Text.ToString().Substring(0, 21) + counter.ToString();
                }
                else
                {
                    toolStripProgressBar1.Value = 0;
                    timer1.Enabled = false;
                    writer.WriteComment("");

                }
            }
            else serialPort1.WriteLine(":read?");
        }




        public void SetFilter()
        {
            if (activeRange != 7)
            {
                if (!led2.Active)
                {
                    led2.Active = true;
                    if (activeRange == 1) { serialPort1.WriteLine(":SENS:VOLT:DC:AVER:STAT ON"); Properties.Settings.Default.dc2 = "true"; }
                    if (activeRange == 2) { serialPort1.WriteLine(":SENS:VOLT:AC:AVER:STAT ON"); Properties.Settings.Default.ac2 = "true"; }
                    if (activeRange == 3) { serialPort1.WriteLine(":SENS:CURR:DC:AVER:STAT ON"); Properties.Settings.Default.dci2 = "true"; }
                    if (activeRange == 4) { serialPort1.WriteLine(":SENS:CURR:AC:AVER:STAT ON"); Properties.Settings.Default.aci2 = "true"; }
                    if (activeRange == 5) { serialPort1.WriteLine(":SENS:RES:AVER:STAT ON"); Properties.Settings.Default.o2 = "true"; }
                    if (activeRange == 6) { serialPort1.WriteLine(":SENS:FRES:AVER:STAT ON"); Properties.Settings.Default.oo2 = "true"; }
                    if (activeRange == 8) { serialPort1.WriteLine(":SENS:TEMP:AVER:STAT ON"); Properties.Settings.Default.temp2 = "true"; }
                }
                else
                {
                    led2.Active = false;
                    if (activeRange == 1) { serialPort1.WriteLine(":SENS:VOLT:DC:AVER:STAT OFF"); Properties.Settings.Default.dc2 = "false"; }
                    if (activeRange == 2) { serialPort1.WriteLine(":SENS:VOLT:AC:AVER:STAT OFF"); Properties.Settings.Default.ac2 = "false"; }
                    if (activeRange == 3) { serialPort1.WriteLine(":SENS:CURR:DC:AVER:STAT OFF"); Properties.Settings.Default.dci2 = "false"; }
                    if (activeRange == 4) { serialPort1.WriteLine(":SENS:CURR:AC:AVER:STAT OFF"); Properties.Settings.Default.aci2 = "false"; }
                    if (activeRange == 5) { serialPort1.WriteLine(":SENS:RES:AVER:STAT OFF"); Properties.Settings.Default.o2 = "false"; }
                    if (activeRange == 6) { serialPort1.WriteLine(":SENS:FRES:AVER:STAT OFF"); Properties.Settings.Default.oo2 = "false"; }
                    if (activeRange == 8) { serialPort1.WriteLine(":SENS:TEMP:AVER:STAT OFF"); Properties.Settings.Default.temp2 = "false"; }
                }
            }
            Properties.Settings.Default.Save();
        }


        private void lbButton13_Click(object sender, EventArgs e)
        {
            SetFilter();
        }

        public void SetDisplayDigit()
        {
            if (serialPort1.IsOpen)
            {
                if (activeRange == 1) { serialPort1.WriteLine(":SENS:VOLT:DC:DIG " + domainUpDown3.Text); Properties.Settings.Default.dc1 = domainUpDown3.Text; }
                if (activeRange == 2) { serialPort1.WriteLine(":SENS:VOLT:AC:DIG " + domainUpDown3.Text); Properties.Settings.Default.ac1 = domainUpDown3.Text; }
                if (activeRange == 3) { serialPort1.WriteLine(":SENS:CURR:DC:DIG " + domainUpDown3.Text); Properties.Settings.Default.dci1 = domainUpDown3.Text; }
                if (activeRange == 4) { serialPort1.WriteLine(":SENS:CURR:AC:DIG " + domainUpDown3.Text); Properties.Settings.Default.aci1 = domainUpDown3.Text; }
                if (activeRange == 5) { serialPort1.WriteLine(":SENS:RES:DIG " + domainUpDown3.Text); Properties.Settings.Default.o1 = domainUpDown3.Text; }
                if (activeRange == 6) { serialPort1.WriteLine(":SENS:FRES:DIG " + domainUpDown3.Text); Properties.Settings.Default.oo1 = domainUpDown3.Text; }
                if (activeRange == 7) { serialPort1.WriteLine(":SENS:FREQ:DIG " + domainUpDown3.Text); Properties.Settings.Default.fre1 = domainUpDown3.Text; }
                if (activeRange == 8) { serialPort1.WriteLine(":SENS:TEMP:DIG " + domainUpDown3.Text); Properties.Settings.Default.temp1 = domainUpDown3.Text; }
            }
            Properties.Settings.Default.Save();
        }


        private void domainUpDown3_SelectedItemChanged(object sender, EventArgs e)
        {
            SetDisplayDigit();
        }

        private void lbButton14_Click(object sender, EventArgs e)
        {
            if (!led4.Active)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    writer = new CsvWriter(saveFileDialog1.FileName);
                    led4.Active = true;
                    if (led1.Active) SetButtonsActivate(true);
                    timer1.Interval = Convert.ToInt16(textBox2.Text);
                    counter = 0;
                    saveFileDialog1.Dispose();

                    lbButton14.Label = "Close";
                }


            }
            else
            {
                writer.EndRecord();
                writer.Close();
                led4.Active = false;
                SetButtonsActivate(false);
                lbButton14.Label = "Save";
            }

        }

        private void lbButton15_Click(object sender, EventArgs e)
        {
            oldCounter = counter;
            automatic = true;
            timer1.Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (led4.Active)
            {
                writer.EndRecord();
                writer.Close();
            }
            if (led1.Active) serialPort1.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.baud = comboBox2.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(textBox2.Text) < 340) textBox2.Text = "340";
            Properties.Settings.Default.zaman = textBox2.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.sayac = textBox3.Text;
            Properties.Settings.Default.Save();
        }
    }
}
