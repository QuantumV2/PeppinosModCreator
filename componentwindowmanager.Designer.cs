namespace WindowsFormsApp1
{
    partial class componentwindowmanager
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.objlabel = new System.Windows.Forms.Label();
            this.objTextBox = new System.Windows.Forms.TextBox();
            this.varTextBoxName = new System.Windows.Forms.TextBox();
            this.varlabel = new System.Windows.Forms.Label();
            this.varTextBoxVal = new System.Windows.Forms.TextBox();
            this.varlabelVal = new System.Windows.Forms.Label();
            this.relCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Pepperoni", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(405, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label3.Font = new System.Drawing.Font("Pepperoni", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(13, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "New Component";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // objlabel
            // 
            this.objlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.objlabel.Font = new System.Drawing.Font("Pepperoni", 20F);
            this.objlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.objlabel.Location = new System.Drawing.Point(180, 107);
            this.objlabel.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.objlabel.Name = "objlabel";
            this.objlabel.Size = new System.Drawing.Size(82, 26);
            this.objlabel.TabIndex = 6;
            this.objlabel.Text = "Object";
            this.objlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // objTextBox
            // 
            this.objTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.objTextBox.Font = new System.Drawing.Font("Pepperoni", 20F);
            this.objTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.objTextBox.Location = new System.Drawing.Point(133, 147);
            this.objTextBox.Name = "objTextBox";
            this.objTextBox.Size = new System.Drawing.Size(169, 33);
            this.objTextBox.TabIndex = 7;
            this.objTextBox.Text = "obj_player";
            // 
            // varTextBoxName
            // 
            this.varTextBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.varTextBoxName.Font = new System.Drawing.Font("Pepperoni", 20F);
            this.varTextBoxName.ForeColor = System.Drawing.SystemColors.Control;
            this.varTextBoxName.Location = new System.Drawing.Point(135, 231);
            this.varTextBoxName.Name = "varTextBoxName";
            this.varTextBoxName.Size = new System.Drawing.Size(169, 33);
            this.varTextBoxName.TabIndex = 9;
            this.varTextBoxName.Text = "paletteselect";
            // 
            // varlabel
            // 
            this.varlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.varlabel.Font = new System.Drawing.Font("Pepperoni", 20F);
            this.varlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.varlabel.Location = new System.Drawing.Point(168, 193);
            this.varlabel.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.varlabel.Name = "varlabel";
            this.varlabel.Size = new System.Drawing.Size(105, 26);
            this.varlabel.TabIndex = 8;
            this.varlabel.Text = "Variable";
            // 
            // varTextBoxVal
            // 
            this.varTextBoxVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.varTextBoxVal.Font = new System.Drawing.Font("Pepperoni", 20F);
            this.varTextBoxVal.ForeColor = System.Drawing.SystemColors.Control;
            this.varTextBoxVal.Location = new System.Drawing.Point(135, 319);
            this.varTextBoxVal.Name = "varTextBoxVal";
            this.varTextBoxVal.Size = new System.Drawing.Size(169, 33);
            this.varTextBoxVal.TabIndex = 11;
            this.varTextBoxVal.Text = "5";
            // 
            // varlabelVal
            // 
            this.varlabelVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.varlabelVal.Font = new System.Drawing.Font("Pepperoni", 20F);
            this.varlabelVal.ForeColor = System.Drawing.SystemColors.Control;
            this.varlabelVal.Location = new System.Drawing.Point(180, 280);
            this.varlabelVal.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.varlabelVal.Name = "varlabelVal";
            this.varlabelVal.Size = new System.Drawing.Size(70, 26);
            this.varlabelVal.TabIndex = 10;
            this.varlabelVal.Text = "Value";
            // 
            // relCheckBox
            // 
            this.relCheckBox.Font = new System.Drawing.Font("Pepperoni", 20F);
            this.relCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.relCheckBox.Location = new System.Drawing.Point(133, 381);
            this.relCheckBox.Name = "relCheckBox";
            this.relCheckBox.Size = new System.Drawing.Size(169, 40);
            this.relCheckBox.TabIndex = 12;
            this.relCheckBox.Text = "Relative?";
            this.relCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 51);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Pepperoni", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(858, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 34);
            this.button3.TabIndex = 1;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // componentwindowmanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(449, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.relCheckBox);
            this.Controls.Add(this.varTextBoxVal);
            this.Controls.Add(this.varlabelVal);
            this.Controls.Add(this.varTextBoxName);
            this.Controls.Add(this.varlabel);
            this.Controls.Add(this.objTextBox);
            this.Controls.Add(this.objlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "componentwindowmanager";
            this.Text = "componentwindowmanager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label objlabel;
        private System.Windows.Forms.Label varlabel;
        private System.Windows.Forms.Label varlabelVal;
        public System.Windows.Forms.TextBox objTextBox;
        public System.Windows.Forms.TextBox varTextBoxName;
        public System.Windows.Forms.TextBox varTextBoxVal;
        public System.Windows.Forms.CheckBox relCheckBox;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
    }
}