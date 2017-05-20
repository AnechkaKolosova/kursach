using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

        

namespace WindowsFormsApplication5
{
    class AllFlats
    {
        public List<Flat> Flats { get; set; }
        public AllFlats (Flat flat)
            {
            this.Flats = new List<Flat>();
            this.Flats.Add(flat);
            }
        
    }
    class Flat
    {
        public string City { get; set; }
        public string District { get; set; }
        public string Price { get; set; }
        public string Type { get; set; }
        public string Room { get; set; }
        public string Floor { get; set; }
        public string Place { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }

        //конструктор для квартиры
        public Flat (string city, string district, string price, string type, string room,
            string floor, string place, string name, string number, string mail, string description)
        {
            this.City = city;
            this.District = district;
            this.Price = price;
            this.Type = type;
            this.Room = room;
            this.Floor = floor;
            this.Place = place;
            this.Name = name;
            this.Number = number;
            this.Mail = mail;
            this.Description = description; 
        }
    }
}
