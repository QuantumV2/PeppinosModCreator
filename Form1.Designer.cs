<<<<<<< HEAD
﻿namespace WindowsFormsApp1
{
    partial class PeppinoModCreator
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
            this.compbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tipLabel = new System.Windows.Forms.Label();
            this.objTextBox = new System.Windows.Forms.TextBox();
            this.objlabel = new System.Windows.Forms.Label();
            this.varTextBoxName = new System.Windows.Forms.TextBox();
            this.relCheckBox = new System.Windows.Forms.CheckBox();
            this.varTextBoxVal = new System.Windows.Forms.TextBox();
            this.varlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addComp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // compbutton
            // 
            this.compbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.compbutton.FlatAppearance.BorderSize = 0;
            this.compbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compbutton.Font = new System.Drawing.Font("Pepperoni", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.compbutton.Location = new System.Drawing.Point(206, 350);
            this.compbutton.Name = "compbutton";
            this.compbutton.Size = new System.Drawing.Size(243, 88);
            this.compbutton.TabIndex = 0;
            this.compbutton.Text = "Compile";
            this.compbutton.UseVisualStyleBackColor = false;
            this.compbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(91, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Font = new System.Drawing.Font("Pepperoni", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.tipLabel.Location = new System.Drawing.Point(658, 52);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(39, 16);
            this.tipLabel.TabIndex = 1;
            this.tipLabel.Text = "Tip: ";
            // 
            // objTextBox
            // 
            this.objTextBox.Location = new System.Drawing.Point(94, 67);
            this.objTextBox.Name = "objTextBox";
            this.objTextBox.Size = new System.Drawing.Size(100, 20);
            this.objTextBox.TabIndex = 2;
            this.objTextBox.Text = "obj_noiseboss";
            this.objTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // objlabel
            // 
            this.objlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objlabel.AutoSize = true;
            this.objlabel.Location = new System.Drawing.Point(118, 51);
            this.objlabel.Name = "objlabel";
            this.objlabel.Size = new System.Drawing.Size(38, 13);
            this.objlabel.TabIndex = 3;
            this.objlabel.Text = "Object";
            // 
            // varTextBoxName
            // 
            this.varTextBoxName.Location = new System.Drawing.Point(94, 119);
            this.varTextBoxName.Name = "varTextBoxName";
            this.varTextBoxName.Size = new System.Drawing.Size(100, 20);
            this.varTextBoxName.TabIndex = 4;
            this.varTextBoxName.Text = "paletteselect";
            // 
            // relCheckBox
            // 
            this.relCheckBox.AutoSize = true;
            this.relCheckBox.Location = new System.Drawing.Point(94, 171);
            this.relCheckBox.Name = "relCheckBox";
            this.relCheckBox.Size = new System.Drawing.Size(65, 17);
            this.relCheckBox.TabIndex = 5;
            this.relCheckBox.Text = "Relative";
            this.relCheckBox.UseVisualStyleBackColor = true;
            // 
            // varTextBoxVal
            // 
            this.varTextBoxVal.Location = new System.Drawing.Point(94, 145);
            this.varTextBoxVal.Name = "varTextBoxVal";
            this.varTextBoxVal.Size = new System.Drawing.Size(100, 20);
            this.varTextBoxVal.TabIndex = 6;
            this.varTextBoxVal.Text = "3";
            // 
            // varlabel
            // 
            this.varlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.varlabel.AutoSize = true;
            this.varlabel.Location = new System.Drawing.Point(118, 103);
            this.varlabel.Name = "varlabel";
            this.varlabel.Size = new System.Drawing.Size(45, 13);
            this.varlabel.TabIndex = 7;
            this.varlabel.Text = "Variable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pepperoni", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Updates not found";
            // 
            // addComp
            // 
            this.addComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addComp.FlatAppearance.BorderSize = 0;
            this.addComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addComp.Font = new System.Drawing.Font("Pepperoni", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addComp.ForeColor = System.Drawing.SystemColors.Control;
            this.addComp.Location = new System.Drawing.Point(477, 350);
            this.addComp.Name = "addComp";
            this.addComp.Size = new System.Drawing.Size(166, 88);
            this.addComp.TabIndex = 9;
            this.addComp.Text = "Add Component";
            this.addComp.UseVisualStyleBackColor = false;
            this.addComp.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Pepperoni", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(504, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 16);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "var";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-8, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 50);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Pepperoni", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(819, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Pepperoni", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(858, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pepperoni", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(19, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Peppino\'s Mod Creator V0.0";
            // 
            // PeppinoModCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(895, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addComp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PeppinoModCreator";
            this.Text = "Peppino\'s Mod Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button compbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.TextBox objTextBox;
        private System.Windows.Forms.Label objlabel;
        private System.Windows.Forms.TextBox varTextBoxName;
        private System.Windows.Forms.CheckBox relCheckBox;
        private System.Windows.Forms.TextBox varTextBoxVal;
        private System.Windows.Forms.Label varlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addComp;
        private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
	}
}

=======
﻿namespace WindowsFormsApp1
{
    partial class PeppinoModCreator
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
            this.compbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tipLabel = new System.Windows.Forms.Label();
            this.objTextBox = new System.Windows.Forms.TextBox();
            this.objlabel = new System.Windows.Forms.Label();
            this.varTextBoxName = new System.Windows.Forms.TextBox();
            this.relCheckBox = new System.Windows.Forms.CheckBox();
            this.varTextBoxVal = new System.Windows.Forms.TextBox();
            this.varlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addComp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // compbutton
            // 
            this.compbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.compbutton.FlatAppearance.BorderSize = 0;
            this.compbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compbutton.Font = new System.Drawing.Font("Pepperoni", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.compbutton.Location = new System.Drawing.Point(206, 350);
            this.compbutton.Name = "compbutton";
            this.compbutton.Size = new System.Drawing.Size(243, 88);
            this.compbutton.TabIndex = 0;
            this.compbutton.Text = "Compile";
            this.compbutton.UseVisualStyleBackColor = false;
            this.compbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(91, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Font = new System.Drawing.Font("Pepperoni", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.tipLabel.Location = new System.Drawing.Point(658, 52);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(39, 16);
            this.tipLabel.TabIndex = 1;
            this.tipLabel.Text = "Tip: ";
            // 
            // objTextBox
            // 
            this.objTextBox.Location = new System.Drawing.Point(94, 67);
            this.objTextBox.Name = "objTextBox";
            this.objTextBox.Size = new System.Drawing.Size(100, 20);
            this.objTextBox.TabIndex = 2;
            this.objTextBox.Text = "obj_noiseboss";
            this.objTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // objlabel
            // 
            this.objlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objlabel.AutoSize = true;
            this.objlabel.Location = new System.Drawing.Point(118, 51);
            this.objlabel.Name = "objlabel";
            this.objlabel.Size = new System.Drawing.Size(38, 13);
            this.objlabel.TabIndex = 3;
            this.objlabel.Text = "Object";
            // 
            // varTextBoxName
            // 
            this.varTextBoxName.Location = new System.Drawing.Point(94, 119);
            this.varTextBoxName.Name = "varTextBoxName";
            this.varTextBoxName.Size = new System.Drawing.Size(100, 20);
            this.varTextBoxName.TabIndex = 4;
            this.varTextBoxName.Text = "paletteselect";
            // 
            // relCheckBox
            // 
            this.relCheckBox.AutoSize = true;
            this.relCheckBox.Location = new System.Drawing.Point(94, 171);
            this.relCheckBox.Name = "relCheckBox";
            this.relCheckBox.Size = new System.Drawing.Size(65, 17);
            this.relCheckBox.TabIndex = 5;
            this.relCheckBox.Text = "Relative";
            this.relCheckBox.UseVisualStyleBackColor = true;
            // 
            // varTextBoxVal
            // 
            this.varTextBoxVal.Location = new System.Drawing.Point(94, 145);
            this.varTextBoxVal.Name = "varTextBoxVal";
            this.varTextBoxVal.Size = new System.Drawing.Size(100, 20);
            this.varTextBoxVal.TabIndex = 6;
            this.varTextBoxVal.Text = "3";
            // 
            // varlabel
            // 
            this.varlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.varlabel.AutoSize = true;
            this.varlabel.Location = new System.Drawing.Point(118, 103);
            this.varlabel.Name = "varlabel";
            this.varlabel.Size = new System.Drawing.Size(45, 13);
            this.varlabel.TabIndex = 7;
            this.varlabel.Text = "Variable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pepperoni", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Updates not found";
            // 
            // addComp
            // 
            this.addComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addComp.FlatAppearance.BorderSize = 0;
            this.addComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addComp.Font = new System.Drawing.Font("Pepperoni", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addComp.ForeColor = System.Drawing.SystemColors.Control;
            this.addComp.Location = new System.Drawing.Point(477, 350);
            this.addComp.Name = "addComp";
            this.addComp.Size = new System.Drawing.Size(166, 88);
            this.addComp.TabIndex = 9;
            this.addComp.Text = "Add Component";
            this.addComp.UseVisualStyleBackColor = false;
            this.addComp.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Pepperoni", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(504, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 16);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "var";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-8, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 50);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Pepperoni", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(819, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Pepperoni", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(858, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pepperoni", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(19, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Peppino\'s Mod Creator V0.0";
            // 
            // PeppinoModCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(895, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addComp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PeppinoModCreator";
            this.Text = "Peppino\'s Mod Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button compbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.TextBox objTextBox;
        private System.Windows.Forms.Label objlabel;
        private System.Windows.Forms.TextBox varTextBoxName;
        private System.Windows.Forms.CheckBox relCheckBox;
        private System.Windows.Forms.TextBox varTextBoxVal;
        private System.Windows.Forms.Label varlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addComp;
        private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
	}
}

>>>>>>> 3fd27bb835a8c104f89561736d5407cdd967392e
