using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

        

namespace WindowsFormsApplication5
{

    public class Flat 
    {
       public About About { get; set; }
		public Adress Adres { get; set; }
		public User UserDate { get; set; }
       
       
		public Flat()
		{

		}
        public Flat (Adress adres, About description, User userDate)
        {
			Adres =  adres;
            About = description;
			UserDate = userDate;
        }
		public Flat (string city, string district, double price, string type, double place, int room, int floor, string name, string mail, long number, string description)
		{
			Adres = new Adress(city, district);
			About = new About(price, type, room, floor, place, description);
			UserDate = new User(name, number, mail);
		}

       
    }
}
