/*******************************************************************************
* Copyright (C) Maxim Integrated Products, Inc., All rights Reserved.
* 
* This software is protected by copyright laws of the United States and
* of foreign countries. This material may also be protected by patent laws
* and technology transfer regulations of the United States and of foreign
* countries. This software is furnished under a license agreement and/or a
* nondisclosure agreement and may only be used or reproduced in accordance
* with the terms of those agreements. Dissemination of this information to
* any party or parties not specified in the license agreement and/or
* nondisclosure agreement is expressly prohibited.
*
* The above copyright notice and this permission notice shall be included
* in all copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
* OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
* MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
* IN NO EVENT SHALL MAXIM INTEGRATED BE LIABLE FOR ANY CLAIM, DAMAGES
* OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
* ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
* OTHER DEALINGS IN THE SOFTWARE.
*
* Except as contained in this notice, the name of Maxim Integrated
* Products, Inc. shall not be used except as stated in the Maxim Integrated
* Products, Inc. Branding Policy.
*
* The mere transfer of this software does not imply any licenses
* of trade secrets, proprietary technology, copyrights, patents,
* trademarks, maskwork rights, or any other form of intellectual
* property whatsoever. Maxim Integrated Products, Inc. retains all
* ownership rights.
*******************************************************************************
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;
using MaximStyle;

namespace MAX32630_One_Wire_Interface
{

    public partial class SerialUSBForm : Form
    {
        private MaximButton MaximButton_connect_serial;
        private SerialPort ComPort1;
        private IContainer components;
        private ColumnHeader columnHeader;
        private ListBox listBox1;
        private MaximButton Refresh_List;
        SerialPort myserialport;

        public SerialUSBForm(SerialPort xyz)
        {
            InitializeComponent();
            myserialport = xyz;
        }


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialUSBForm));
            this.MaximButton_connect_serial = new MaximStyle.MaximButton();
            this.ComPort1 = new System.IO.Ports.SerialPort(this.components);
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Refresh_List = new MaximStyle.MaximButton();
            this.SuspendLayout();
            // 
            // MaximButton_connect_serial
            // 
            this.MaximButton_connect_serial.Location = new System.Drawing.Point(204, 157);
            this.MaximButton_connect_serial.Name = "MaximButton_connect_serial";
            this.MaximButton_connect_serial.Size = new System.Drawing.Size(75, 23);
            this.MaximButton_connect_serial.TabIndex = 2;
            this.MaximButton_connect_serial.Text = "Connect";
            this.MaximButton_connect_serial.UseVisualStyleBackColor = true;
            this.MaximButton_connect_serial.Click += new System.EventHandler(this.MaximButton_connect_serial_Click_1);
            // 
            // ComPort1
            // 
            this.ComPort1.PortName = "COM";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(37, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 147);
            this.listBox1.TabIndex = 3;
            // 
            // Refresh_List
            // 
            this.Refresh_List.Location = new System.Drawing.Point(204, 33);
            this.Refresh_List.Name = "Refresh_List";
            this.Refresh_List.Size = new System.Drawing.Size(75, 23);
            this.Refresh_List.TabIndex = 4;
            this.Refresh_List.Text = "Refresh List";
            this.Refresh_List.UseVisualStyleBackColor = true;
            this.Refresh_List.Click += new System.EventHandler(this.Refresh_List_Click);
            // 
            // SerialUSBForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(317, 225);
            this.Controls.Add(this.Refresh_List);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.MaximButton_connect_serial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SerialUSBForm";
            this.Text = "Connect to Serial Device";
            this.Load += new System.EventHandler(this.SerialUSBForm_Load);
            this.ResumeLayout(false);

        }

        private void Button_search_maxim_Click_1(object sender, EventArgs e)
        {

        }

        private void MaximButton_connect_serial_Click_1(object sender, EventArgs e)
        {
            if (!(myserialport.IsOpen))
            {
                try
                {
                    myserialport.PortName = Convert.ToString(listBox1.SelectedItem);

                    myserialport.BaudRate = 9600;
                    myserialport.Parity = System.IO.Ports.Parity.None;
                    myserialport.DataBits = 8;
                    myserialport.StopBits = System.IO.Ports.StopBits.One;
                    myserialport.Handshake = System.IO.Ports.Handshake.None;
                    myserialport.RtsEnable = true;
                    myserialport.DtrEnable = true;

                    //
                    //myserialport.DataReceived += Mainform.serialPort1_onDataReceived;

                    try
                    {

                        myserialport.Open();

                    }
                    catch (System.ArgumentException ex)
                    {
                        MessageBox.Show("Please select the Valid COM port and click connect", "Error: COM Port Not Selected");
                        return;
                    }

                    this.Hide();

                }
                catch (UnauthorizedAccessException ex)
                {
                    //   MessageBox.Show(ex.Message);
                }
            }
            else if (myserialport.IsOpen)
            {

                myserialport.Close();

                try
                {


                    myserialport.PortName = Convert.ToString(listBox1.SelectedItem);

                    myserialport.BaudRate = 9600;
                    myserialport.Parity = System.IO.Ports.Parity.None;
                    myserialport.DataBits = 8;
                    myserialport.StopBits = System.IO.Ports.StopBits.One;
                    myserialport.Handshake = System.IO.Ports.Handshake.None;
                    myserialport.RtsEnable = true;
                    myserialport.DtrEnable = true;

                    try
                    {

                        myserialport.Open();

                    }
                    catch (System.ArgumentException ex)
                    {
                        MessageBox.Show("Please select the Valid COM port and click connect", "Error: COM Port Not Selected");
                        return;
                    }

                    this.Hide();

                }
                catch (UnauthorizedAccessException ex)
                {
                    //   MessageBox.Show(ex.Message);
                }
                return;

            }
        }

        private void SerialUSBForm_Load(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();

                string[] ArrayComPortsNames = null;
                int index = 0;
                ArrayComPortsNames = SerialPort.GetPortNames();

                while (index < ArrayComPortsNames.Length)
                {
                    listBox1.Items.Add(ArrayComPortsNames[index]);
                    index++;
                }
            }
            catch (NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }
        }

        private void Refresh_List_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();

                string[] ArrayComPortsNames = null;
                int index = 0;
                ArrayComPortsNames = SerialPort.GetPortNames();

                while (index < ArrayComPortsNames.Length)
                {
                    listBox1.Items.Add(ArrayComPortsNames[index]);
                    index++;
                }
            }
            catch (NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }
        }

        private void Auto_Connect_Click(object sender, EventArgs e)
        {
            //bool success = false;
            //int index = 0;
            //string in_data = "";
            //string[] ArrayComPortsNames = null;
            //ArrayComPortsNames = SerialPort.GetPortNames();

            //myserialport.BaudRate = 9600;
            //myserialport.Parity = System.IO.Ports.Parity.None;
            //myserialport.DataBits = 8;
            //myserialport.StopBits = System.IO.Ports.StopBits.One;
            //myserialport.Handshake = System.IO.Ports.Handshake.None;
            //myserialport.RtsEnable = true;
            //myserialport.DtrEnable = true;

            //while ((index < ArrayComPortsNames.Length) && (success == false))
            //{
            //    myserialport.PortName = ArrayComPortsNames[index];

            //    try
            //    {
            //        myserialport.Open();
            //        myserialport.WriteLine("INIT");
            //        System.Threading.Thread.Sleep(100);
            //        in_data = myserialport.ReadLine();

            //        if(in_data.Contains("Version"))
            //        {
            //            MessageBox.Show($"Connected to {myserialport.PortName}");
            //            return;
            //        }
            //    }

            //    catch(ArgumentException ex)
            //    {
            //        continue;
            //    }
            //}
        }
    }
}
