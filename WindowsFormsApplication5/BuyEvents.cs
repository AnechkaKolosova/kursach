using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApplication5
{
	partial class Buy : Form
	{
		//Search
		private void button1_Click(object sender, EventArgs e)
		{
			SearchResalt();
		}

		private void EditCombo(ComboBox c, List<string> l)
		{
			c.Items.Clear();
			foreach (string i in l)
			{
				c.Items.Add(i);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			GetBaseFromFile();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			GetMyBase();
		}

		private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			GoToFlat();
		}
	}
}