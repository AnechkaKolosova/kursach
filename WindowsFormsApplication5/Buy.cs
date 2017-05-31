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
		

	  
		

		public Base Search(string city, string district, string type, string room, string fd, 
			string fu, string pricemax, string pricemin, string placemin, string placemax)
		{
			Base search = new Base();
			search = Form1.Itself.flats;
			search.SearchCity(city);
			search.SearchDistrict(district);
			search.SearchType(type);
			search.SearchRoom(room);
			search.SearchFloor(fd, fu);
			search.SearchPlaceOrPrice(pricemin, pricemax);
			search.SearchPlaceOrPrice(placemin, placemax);



			return search;
		}

		

		
		

		

		

		

		
			
			
		}
	}


