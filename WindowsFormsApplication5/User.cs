using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
	public class User 
	{
		
		public string Name { get; set; }
		public long Number { get; set; }
		public string Mail { get; set; }
		
		public User(string name, long number, string mail)
		{
			Name = name;
			Number = number;
			Mail = mail;
		}
		public User (string name, long number)
		{
			Name = name;
			Number = number;
		}
		public User (string name, string mail)
		{
			Name = name;
			Mail = mail;
		}

		public User() { }

	}
}
