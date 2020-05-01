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
using MaximStyle;

namespace MAX32630_One_Wire_Interface
{
    public partial class MaximSplashScreenForm : Form
    {
        private MaximSplashScreen maximSplashScreen1;
        private Timer timer1;
        private IContainer components;
        private MaximButton OK;
        public bool disableCheckBoxValue = false;

        public MaximSplashScreenForm(int numberofSeconds)
        {
            InitializeComponent();
            maximSplashScreen1.DismissTime = numberofSeconds;
        }
        public void Disable_splash_screen_timer()
        {
            //timer1.Enabled = false;

            maximSplashScreen1.DismissTime = 1000000;
            //maximSplashScreen1.Enabled = false;
        }



        public MaximSplashScreenForm(string applicationName, string versionString, string copyrightString,
           string nonMaximCopyrightString, Image applicationIconImage, int numberOfSeconds)
        {
            InitializeComponent();
            maximSplashScreen1.DismissTime = numberOfSeconds;
            maximSplashScreen1.ApplicationName = applicationName;
            maximSplashScreen1.VersionString = versionString;
            maximSplashScreen1.CopyrightString = copyrightString;
            maximSplashScreen1.NonMaximCopyrightString = nonMaximCopyrightString;
            maximSplashScreen1.ApplicationIconImage = applicationIconImage;
        }

        private void maximSplashScreen1_Load(object sender, EventArgs e)
        {
            //timer1.Tick += new EventHandler(timer1_Tick);
            //maximSplashScreen1.LinkClicked = new LinkLabelLinkClickedEventHandler(LinkClicked);
            //maximSplashScreen1.DisableSplashScreenClicked = new EventHandler(DisableSplashScreenClicked);
            //maximSplashScreen1.Checked = disableCheckBoxValue;
            //OK.Click += new EventHandler(OK_Click);
            //timer1.Interval = maximSplashScreen1.DismissTime * 1000;
            //timer1.Enabled = true;


        }

        void DisableSplashScreenClicked(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                disableCheckBoxValue = maximSplashScreen1.Checked;
            }
            else
            {
                disableCheckBoxValue = maximSplashScreen1.Checked;
            }

        }

        void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;
            //linkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("http://" + linkLabel.Text);
        }
        private void OK_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            timer1.Enabled = false;
        }

        public void showOK_Click(bool dismiss)
        {

            OK.Visible = dismiss;


        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaximSplashScreenForm));
            this.maximSplashScreen1 = new MaximStyle.MaximSplashScreen();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OK = new MaximStyle.MaximButton();
            this.SuspendLayout();
            // 
            // maximSplashScreen1
            // 
            this.maximSplashScreen1.ApplicationIconImage = null;
            this.maximSplashScreen1.ApplicationName = "MAX32630 1-Wire Interface";
            this.maximSplashScreen1.BackColor = System.Drawing.Color.White;
            this.maximSplashScreen1.Checked = false;
            this.maximSplashScreen1.CopyrightString = "© Maxim Integrated Products, Inc.";
            this.maximSplashScreen1.Font = new System.Drawing.Font("Arial", 11F);
            this.maximSplashScreen1.Location = new System.Drawing.Point(0, 0);
            this.maximSplashScreen1.Margin = new System.Windows.Forms.Padding(0);
            this.maximSplashScreen1.Name = "maximSplashScreen1";
            this.maximSplashScreen1.NonMaximCopyrightString = "";
            this.maximSplashScreen1.Size = new System.Drawing.Size(400, 320);
            this.maximSplashScreen1.TabIndex = 0;
            this.maximSplashScreen1.VersionString = "Version 1.0";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(310, 291);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // MaximSplashScreenForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.maximSplashScreen1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MaximSplashScreenForm";
            this.Load += new System.EventHandler(this.MaximSplashScreenForm_Load);
            this.ResumeLayout(false);

        }

        private void MaximSplashScreenForm_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            maximSplashScreen1.LinkClicked = new LinkLabelLinkClickedEventHandler(LinkClicked);
            maximSplashScreen1.DisableSplashScreenClicked = new EventHandler(DisableSplashScreenClicked);
            maximSplashScreen1.Checked = disableCheckBoxValue;
            OK.Click += new EventHandler(OK_Click);
            timer1.Interval = maximSplashScreen1.DismissTime * 1000;
            timer1.Enabled = true;
        }
    }
}
