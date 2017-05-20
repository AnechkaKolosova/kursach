using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
namespace WindowsFormsApplication5
{
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
        }

        private void Sell_Load(object sender, EventArgs e)
        {

        }
        //переходы по разным формам с помощью меню
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
        
        //добавление квартир
        private void button1_Click(object sender, EventArgs e)
        {
            Flat flat = new Flat(comboBox1.Text, comboBox2.Text, textBox4.Text, comboBox3.Text,
                comboBox6.Text, comboBox5.Text, comboBox4.Text, textBox1.Text, textBox2.Text, 
                textBox3.Text, richTextBox1.Text);
            AllFlats flats = new AllFlats(flat);
            string serealized = JsonConvert.SerializeObject(flats) + Environment.GetCommandLineArgs() ;
            using (StreamWriter output = new StreamWriter(@"\base.txt"))
            {
                output.WriteLine(serealized);
            }
                //File.AppendAllLines( serealized+@"\base.txt",Eb);
                //richTextBox1.Text = serealized;
                //вызов формы подтверждающей добавление
                Hide();
            Add add = new Add();
            add.ShowDialog();
            Close();
        }

        

        //ограничение на ввод єтажа(только цифры)
        //добавить ограничение в 200 этажей(высвечивается обьявление, что слишком высоко)
        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
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
        //ограничение на ввод кол-ва комнат(только цифры)
        private void comboBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
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
        //ограничение на ввод жтл площади(только цифры, одна запятая)
        private void comboBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (comboBox6.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;

                }
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
        //ограничение на ввод цены (только цифры и одна запятая)
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar >= '0') && e.KeyChar <= '9')
                {
                    return;
                }
                if (e.KeyChar == '.')
                {
                    e.KeyChar = ',';
                }
                if (e.KeyChar == ',')
                {
                    if (textBox4.Text.IndexOf(',') != -1)
                    {
                        e.Handled = true;

                    }
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


        }
        //ОГРАНИЧЕНИЕ В ИМЕЙЛЕ(ОДНА СОБАЧКА+доработать несколько доменніх имен)
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '@')
            {
                if (textBox2.Text.IndexOf('@') != -1)
                {
                    e.Handled = true;

                }
                return;
            }
            if (e.KeyChar == '.')
            {
                if(textBox2.Text.IndexOf('@') == -1 )
                {
                    return;
                }
                else
                {
                    if(textBox2.Text.Substring(textBox2.Text.IndexOf('@')).IndexOf('.')!= -1)
                        e.Handled = true;
                   //прописать ограничение для трех доменного почтового ящика(три точки после @)
                }
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
