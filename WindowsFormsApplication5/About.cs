using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
	public class About : Adress
	{
		
		public double Price { get; set; }
		public string Type { get; set; }
		public int Room { get; set; }
		public int Floor { get; set; }
		public double Place { get; set; }
		public string Description { get; set; }

		public About (double price, string type, int room, int floor, double place, string description)
		{
			Price = price;
			Type = type;
			Room = room;
			Floor = floor;
			Place = place;
			Description = description;
		}

	}
}
