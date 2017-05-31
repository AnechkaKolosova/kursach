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

		public void SearchResalt()
		{
			dataGridView1.Rows.Clear();

			foreach (Flat i in Search(comboBox2.Text, comboBox3.Text, comboBox1.Text, comboBox4.Text, comboBox5.Text,
				comboBox6.Text, comboBox9.Text, comboBox10.Text, comboBox7.Text, comboBox8.Text))
			{
				dataGridView1.Rows.Add(i.Adres.City, i.Adres.District, i.About.Type, i.About.Room, i.About.Floor, i.About.Place);
			}
		}
	}
}