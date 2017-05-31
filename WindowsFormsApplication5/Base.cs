using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    public class Base : System.Collections.Generic.List<Flat>
    {
        public Base() : base() { }

		public void SearchCity(string city)
		{
			if (city == "") return;
			for (int i = 0; i < this.Count; i++)
			{
				if (this[i].Adres.City.ToLower() != city.ToLower()) this.RemoveAt(i);
			}
		}
		public void SearchDistrict(string district)
		{
			if (district == "") return;
			for (int i = 0; i < this.Count; i++)
			{
				if (this[i].Adres.District.ToLower() != district.ToLower()) this.RemoveAt(i);
			}
		}
        public void SearchType(string type)
		{
			if (type == "") return;
			for (int i = 0; i < this.Count; i++)
			{
				if (this[i].About.Type.ToLower() != type.ToLower()) this.RemoveAt(i);
			}
		}
		public void SearchRoom(string room)
		{
			try
			{
				for (int i = 0; i < this.Count; i++)
				{
					if (this[i].About.Room < Convert.ToInt32(room)) this.RemoveAt(i);
				}
			}
			catch
			{
				return;
			}
		}
		public void SearchFloor(string floord, string flooru)
		{
			try
			{
				if (floord == "" || flooru =="")
				{
					for (int i = 0; i < this.Count; i++)
					{
						if (floord == "")
						{
							if (Convert.ToInt32(flooru) < this[i].About.Floor) this.RemoveAt(i);
						}
						else
						{
							if (Convert.ToInt32(floord) > this[i].About.Floor) this.RemoveAt(i);
						}
					}
				}
				else
				{
					for (int i = 0; i < this.Count; i++)
					{
						if (Convert.ToInt32(flooru) < this[i].About.Floor && Convert.ToInt32(floord) > this[i].About.Floor)
							this.RemoveAt(i);
				    }
			    }
			}
			catch
			{
				return;
			}
		}

	}
}
