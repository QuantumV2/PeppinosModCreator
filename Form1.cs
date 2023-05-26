<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{

    public partial class PeppinoModCreator : Form
    {
        public string codeStr;
        List<string> lsCode = new List<string>();

        public PeppinoModCreator()
        {
            InitializeComponent();
        }

        Point lastPoint;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += QuitAPP;
            string[] tipArray = { "I'm a Creeper\nMinecrafts Grim Reaper", "PEPPINO YOURE MINE!\nYOUVE TAKEN FAR TOO MUCH\nTIME FOR A SIMPLE JOG TO\nTHE EXIT DOOR", "Fester out all of your\ndoubt", "And this is story all\nabout how my life got\nflipped upside down", "WHEN THE", "Did you know that you\n could make uhh uhhh" };
            Random r = new Random();
            int rInt = r.Next(0, tipArray.Length);
            this.tipLabel.Text = "Tip: " + tipArray[rInt];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!relCheckBox.Checked)
            {
                lsCode.Add(varTextBoxName.Text + " = " + varTextBoxVal.Text);
            }
            else
            {
                lsCode.Add(varTextBoxName.Text + " += " + varTextBoxVal.Text);
            }
            var formPopup = new Addto();
            formPopup.Show(this);
            formPopup.Name = "Add this to " + objTextBox.Text;
            formPopup.Text = "Add this to " + objTextBox.Text;
            Font SmallFont = new Font("Pepperoni", 20);
            codeStr = string.Join("\n", lsCode.ToArray());
            TextBox code = new TextBox()
            {
                Text = codeStr,
                ReadOnly = true,
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
        Form formPopup_Comp = new Form();
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!formPopup_Comp.Visible)
            {
                formPopup_Comp.Show(this);
                formPopup_Comp.Controls.Add(this.varlabel);
                formPopup_Comp.Controls.Add(this.varTextBoxVal);
                formPopup_Comp.Controls.Add(this.relCheckBox);
                formPopup_Comp.Controls.Add(this.varTextBoxName);
                formPopup_Comp.Controls.Add(this.objlabel);
                formPopup_Comp.Controls.Add(this.objTextBox);
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
	}
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{

    public partial class PeppinoModCreator : Form
    {
        public string codeStr;
        List<string> lsCode = new List<string>();

        public PeppinoModCreator()
        {
            InitializeComponent();
        }

        Point lastPoint;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += QuitAPP;
            string[] tipArray = { "I'm a Creeper\nMinecrafts Grim Reaper", "PEPPINO YOURE MINE!\nYOUVE TAKEN FAR TOO MUCH\nTIME FOR A SIMPLE JOG TO\nTHE EXIT DOOR", "Fester out all of your\ndoubt", "And this is story all\nabout how my life got\nflipped upside down", "WHEN THE", "Did you know that you\n could make uhh uhhh" };
            Random r = new Random();
            int rInt = r.Next(0, tipArray.Length);
            this.tipLabel.Text = "Tip: " + tipArray[rInt];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!relCheckBox.Checked)
            {
                lsCode.Add(varTextBoxName.Text + " = " + varTextBoxVal.Text);
            }
            else
            {
                lsCode.Add(varTextBoxName.Text + " += " + varTextBoxVal.Text);
            }
            if (varTextBoxVal.Contains(-) = true )
            {
                lsCode.Add(varTextBoxName.Text + " -= " + varTextBoxVal.Text);
            }
            var formPopup = new Addto();
            formPopup.Show(this);
            formPopup.Name = "Add this to " + objTextBox.Text;
            formPopup.Text = "Add this to " + objTextBox.Text;
            Font SmallFont = new Font("Pepperoni", 20);
            codeStr = string.Join("\n", lsCode.ToArray());
            TextBox code = new TextBox()
            {
                Text = codeStr,
                ReadOnly = true,
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
        Form formPopup_Comp = new Form();
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!formPopup_Comp.Visible)
            {
                formPopup_Comp.Show(this);
                formPopup_Comp.Controls.Add(this.varlabel);
                formPopup_Comp.Controls.Add(this.varTextBoxVal);
                formPopup_Comp.Controls.Add(this.relCheckBox);
                formPopup_Comp.Controls.Add(this.varTextBoxName);
                formPopup_Comp.Controls.Add(this.objlabel);
                formPopup_Comp.Controls.Add(this.objTextBox);
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
	}
}
>>>>>>> 3fd27bb835a8c104f89561736d5407cdd967392e
