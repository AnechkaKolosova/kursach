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
    public partial class Form1 : Form
    {
		public static Form1 Itself;
		public Base flats;
		
		internal string Fname;
        public Form1()
        {
			//flats = new Base();
            InitializeComponent();
			 GetBase();
			Itself = this;
			
			//flats.Add(new Flat("","",0,"",0,0,0,"","","",""));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Buy buy = new Buy();
            buy.ShowDialog();
            Close();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GetBase()
        {
            Fname = "base.txt";
            string ftext = System.IO.File.ReadAllText(Fname);
			if (flats == null)
				flats = new Base();
			string substring = "System.String[]";
			if (ftext.IndexOf(substring)!=-1)
			{
				
				ftext = ftext.Remove(ftext.IndexOf(substring), substring.Length);
			}
			
			//ftext.Remove()
			flats = Newtonsoft.Json.JsonConvert.DeserializeObject<Base>(ftext);
			
		}

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            Sell sell = new Sell();
            sell.ShowDialog();
            Close();
        }
    }
}
