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
        //стартовые массивы районов по городам
        private string[] Kharkiv = new string[3] { "Шевченковский", "Киевский", "ХТЗ" };
        private string[] Kiev = new string[4] {"Борщаговский", "Печерский", "Соломенский", "Троещенский"};
        //изменение списка районов в зависимости от города
        private void  comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Харьков":
                    {
                        comboBox3.Items.Clear();
                        comboBox3.Items.AddRange(Kharkiv);
                        break;
                    }
                case "Киев":
                    {
                        comboBox3.Items.Clear();
                        comboBox3.Items.AddRange(Kiev);
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
    }
}
