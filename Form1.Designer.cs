namespace WindowsFormsApp1
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
            this.SuspendLayout();
            // 
            // compbutton
            // 
            this.compbutton.Location = new System.Drawing.Point(206, 350);
            this.compbutton.Name = "compbutton";
            this.compbutton.Size = new System.Drawing.Size(243, 88);
            this.compbutton.TabIndex = 0;
            this.compbutton.Text = "Compile";
            this.compbutton.UseVisualStyleBackColor = true;
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
            this.tipLabel.Location = new System.Drawing.Point(523, 28);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(28, 13);
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
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Updates not found";
            // 
            // addComp
            // 
            this.addComp.Location = new System.Drawing.Point(477, 350);
            this.addComp.Name = "addComp";
            this.addComp.Size = new System.Drawing.Size(166, 88);
            this.addComp.TabIndex = 9;
            this.addComp.Text = "Add Component";
            this.addComp.UseVisualStyleBackColor = true;
            this.addComp.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(504, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "var";
            // 
            // PeppinoModCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addComp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tipLabel);
            /*this.Controls.Add(this.varlabel);
            this.Controls.Add(this.varTextBoxVal);
            this.Controls.Add(this.relCheckBox);
            this.Controls.Add(this.varTextBoxName);
            this.Controls.Add(this.objlabel);
            this.Controls.Add(this.objTextBox);
            */
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compbutton);
            this.Name = "PeppinoModCreator";
            this.Text = "Peppino\'s Mod Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

