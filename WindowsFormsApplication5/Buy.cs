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
    public partial class Buy : Form
    {
        public Buy()
        {
            InitializeComponent();
        }

        
        //изменение комбобокса на список
        private void EditCombo(ComboBox c ,List<string> l)
        {
            c.Items.Clear();
            foreach (string i in l)
            {
                c.Items.Add(i);
            }
        }

        //стартовые массивы районов по городам
        private List<string> Kharkiv = new List<string> { "Шевченковский", "Киевский", "ХТЗ" };
        private List<string> Kiev = new List<string> { "Борщаговский", "Печерский", "Соломенский", "Троещенский"};
        //изменение списка районов в зависимости от города
        private void  comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString().ToLower())
            {
                case "харьков":
                    {
                        EditCombo(comboBox3, Kharkiv);
                        break;
                    }
                case "киев":
                    {
                        EditCombo(comboBox3, Kiev);
                        break;
                    }
                default:
                    {
                        comboBox3.Items.Clear();
                        break;
                    }

            }
           
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
        //кол-во комнат только цифрі не больше 100
        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >='0' && e.KeyChar <= '9')
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            
            else
            {
                e.Handled = true;
            }
        }

        private void comboBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;
            if (Char.IsControl(e.KeyChar))
                return;
            else
                e.Handled= true;
        }
		//Search
        private void button1_Click(object sender, EventArgs e)
        {
			dataGridView1.Rows.Clear();
			//foreach (Flat i in Seach())
			//{
			//	dataGridView1.Rows.Add(i.Adres.City, i.Adres.District, i.Description.Type, i.Description.Room, i.Description.Floor, i.Description.Place);
			//}
		}

	  
		

		public Base Search()
		{
			Base search = Form1.Itself.flats;
			return 
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;

			dataGridView1.Rows.Clear();
			string fname = openFileDialog1.FileName;
			string ftext = System.IO.File.ReadAllText(fname);

			string substring = "System.String[]";
			if (ftext.IndexOf(substring) != -1)
			{

				ftext = ftext.Remove(ftext.IndexOf(substring), substring.Length);
			}
			Form1.Itself.flats = JsonConvert.DeserializeObject<Base>(ftext);

			foreach(Flat i in Form1.Itself.flats)
			{
				dataGridView1.Rows.Add(i.Adres.City, i.Adres.District, i.About.Type, i.About.Room, i.About.Floor, i.About.Place);
			}
		}

		

		private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Hide();
			MyFlats myflats = new MyFlats();
			myflats.ShowDialog();
			Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			foreach (Flat i in Form1.Itself.flats)
			{
				dataGridView1.Rows.Add(i.Adres.City, i.Adres.District, i.About.Type, i.About.Room, i.About.Floor, i.About.Place);
			}
		}

		private Base Uniq(Base b)
		{
			Base result = new Base();
			foreach (Flat i in b)
			{
				int count = 0;
				
				foreach (Flat j in b)
				{
					if (i == j)
					{
						count++;
					}
				}
				if (count == 1) result.Add(i);
				
			}
			return result;
		}
			
			
		}
	}


