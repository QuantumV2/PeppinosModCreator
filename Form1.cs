using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.Net.NetworkInformation;

namespace WindowsFormsApp1
{

    public partial class PeppinoModCreator : Form
    {
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelviewer.Controls.Add(childForm);
            panelviewer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public class Version
        {
            public string major = "0";
            public string minor = "0";
            public string build = "0";
        }

        public Version currversion = new Version()
        {
            major = "0",
            minor = "1",
            build = "0"
        };

        public string[] tipArray = { "I'm a Creeper\nMinecrafts Grim Reaper", "PEPPINO YOURE MINE!\nYOUVE TAKEN FAR TOO MUCH\nTIME FOR A SIMPLE JOG TO\nTHE EXIT DOOR", "Fester out all of your\ndoubt", "And this is story all\nabout how my life got\nflipped upside down", "WHEN THE", "Did you know that you\n could make uhh uhhh" };
        public componentwindowmanager formPopup_Comp = new componentwindowmanager();
        public string codeStr;
        List<string> lsCode = new List<string>();

        public PeppinoModCreator()
        {
            InitializeComponent();
        }


        Point lastPoint;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Application_UpdateCode2();
            formPopup_Comp.Name = "New Component";
            this.FormClosing += QuitAPP;
            Random r = new Random();
            int rInt = r.Next(0, tipArray.Length);
            this.tipLabel.Text = "Tip: " + tipArray[rInt];

            //version check stuff
            string currVersionStr = currversion.major + "." + currversion.minor + "." + currversion.build;
            label3.Text = "Peppino's Mod Creator V" + currVersionStr;
            try
            {
                var webClient = new System.Net.WebClient();
                var json = webClient.DownloadString("https://pmcupdate.quantumv.repl.co/currversion.json");
                Version nextVersion = new Version();
                nextVersion = JsonConvert.DeserializeObject<Version>(json);
                //this code is so dumb i hate it
                string nextVersionStr = nextVersion.major + "." + nextVersion.minor + "." + nextVersion.build;
                if (nextVersion.major != currversion.major || nextVersion.minor != currversion.minor || nextVersion.build != currversion.build)
                {
                    label2.Text = "New version found!\nNew version: " + nextVersionStr;
                }
                else
                {
                    label2.Text = "Updates not found.";
                }
            }
            catch (Exception)
            {
                label2.Text = "Can't connect to the servers! Updates not found.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Application_UpdateCode2();
            if (!formPopup_Comp.relCheckBox.Checked)
            {
                lsCode.Add("\r\n" + formPopup_Comp.varTextBoxName.Text + " = " + formPopup_Comp.varTextBoxVal.Text);
            }
            else
            {
                lsCode.Add("\r\n" + formPopup_Comp.varTextBoxName.Text + " += " + formPopup_Comp.varTextBoxVal.Text);
            }
            var formPopup = new Addto();
            formPopup.Show(this);
            formPopup.Name = "Add this to " + formPopup_Comp.objTextBox.Text;
            formPopup.label3.Text = "For object: " + formPopup_Comp.objTextBox.Text;
            formPopup.Text = "Add this to " + formPopup_Comp.objTextBox.Text;
            Font SmallFont = new Font("Pepperoni", 20);
            codeStr = string.Join("", lsCode.ToArray());
            TextBox code = new TextBox()
            {
                Text = codeStr,
                ReadOnly = false,
                BorderStyle = 0,
                BackColor = this.BackColor,
                ForeColor = Color.White,
                TabStop = false,
                Multiline = true,
                Location = new Point(12, 50),
                TabIndex = 10,
                Size = new System.Drawing.Size(353, 394)
            };

            formPopup.Controls.Add(code);
            //lsCode.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            formPopup_Comp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            formPopup_Comp.ForeColor = System.Drawing.SystemColors.Control;
            if (!formPopup_Comp.Visible)
            {
                formPopup_Comp.Show(this);
                formPopup_Comp.FormClosing += DontLiquidate;
            }

        }

        // Use this event handler for the FormClosing event.
        private void DontLiquidate(object sender, FormClosingEventArgs e)
        {
            formPopup_Comp.Hide();
            e.Cancel = true; // this cancels the close event.
        }
private void QuitAPP(object sender, FormClosingEventArgs e)
        {
            if (formPopup_Comp != null) { 
            formPopup_Comp.FormClosing -= DontLiquidate;
            }
            e.Cancel = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
            lastPoint = new Point(e.X, e.Y);
		}

		private void button1_Click_2(object sender, EventArgs e)
		{
            Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
            WindowState = FormWindowState.Minimized;
		}

        private void button3_Click(object sender, EventArgs e)
        {
            //Application_UpdateCode2();
            if (lsCode.Count - 1 > 0) 
            { 
            lsCode.RemoveAt(lsCode.Count - 1);
            
            }
            if(codeStr != null)
            {
                codeStr.Remove(codeStr.LastIndexOf("\r\n") + 1);
            }
        }

        private void tipButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int rInt = r.Next(0, tipArray.Length);
            this.tipLabel.Text = "Tip: " + tipArray[rInt];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new test());
            panelviewer.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panelviewer.Visible = false;
        }

        //you can change the button names im lazy asf


        //this idea is bad actually i think ill use console for debugging like wtf
        /*
        private void Application_UpdateCode(Object sender, EventArgs e)
        {
            //... why does this work ...
            this.label4.Text = string.Join("", lsCode.ToArray());
        }
        public void Application_UpdateCode2()
        {
            //BUT THIS DOESNT SJHKJJJHXJKXCJHXCNMXCNM #速度与激情9# 早上好中国 现在我有冰激淋 我很喜欢冰激淋 但是《速度与激情9》比冰激淋
            this.label4.Text = string.Join("", lsCode.ToArray());
        }*/
    }
}
