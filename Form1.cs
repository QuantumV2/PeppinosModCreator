using System;
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
        List<string> lsCode = new List<string>();
        
        public PeppinoModCreator()
        {
            InitializeComponent();
        }

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
            var formPopup = new Form();
            formPopup.Show(this);
            formPopup.Name = "Add this to " + objTextBox.Text;
            formPopup.Text = "Add this to " + objTextBox.Text;
            TextBox code = new TextBox()
            {
                Text = string.Join("\n", lsCode.ToArray()),
                ReadOnly = true,
                BorderStyle = 0,
                BackColor = this.BackColor,
                TabStop = false,
                Multiline = true,
                Location = new Point(10, 10),
                TabIndex = 10,
                Size = new System.Drawing.Size(99, 500)
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
    }
}
