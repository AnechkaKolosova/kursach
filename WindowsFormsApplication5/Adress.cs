using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
	public class Adress
	{
	    public string City { get; set; }
		public string District { get; set; }

		public Adress(string city, string district)
		{
			City = city;
			District = district;
		}
		public  Adress()
		{

		}
	}
}
