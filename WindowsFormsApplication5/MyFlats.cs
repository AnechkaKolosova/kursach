using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
	public partial class MyFlats : Form
	{
		public MyFlats()
		{
			InitializeComponent();
		}

		private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Hide();
			Form1 main = new Form1();
			main.ShowDialog();
			Close();
		}
		private void купитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Hide();
			Buy buy = new Buy();
			buy.ShowDialog();
			Close();
		}
		private void продатьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Hide();
			Sell sell = new Sell();
			sell.ShowDialog();
			Close();

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		
	}
}
