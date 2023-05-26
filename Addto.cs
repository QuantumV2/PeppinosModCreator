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
	public partial class Addto : Form
	{
		public Addto()
		{
			InitializeComponent();
		}
		Point lastPoint;
		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void Addto_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void Addto_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
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
	public partial class Addto : Form
	{
		public Addto()
		{
			InitializeComponent();
		}
		Point lastPoint;
		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void Addto_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void Addto_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
        }
	}
}
>>>>>>> 3fd27bb835a8c104f89561736d5407cdd967392e
