using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Room
    {
        public int Number { get; set; }
        public string Type { get; set; }
        public string Phone { get; set; }
        public string Available { get; set; }
        public decimal Price { get; set; }
        public Room() { }
        public Room(string type, string phone, string available)
        {
            this.Type = type;
            this.Phone = phone;
            this.Available = available;
        }
        public Room(string type, string phone, string available,decimal Price)
        {
            this.Type = type;
            this.Phone = phone;
            this.Available = available;
            this.Price = Price;
        }
        public Room(int number, string type, string phone, string available)
        {
            this.Number = number;
            this.Type = type;
            this.Phone = phone;
            this.Available = available;
        }
        public Room(int number, string type, string phone, string available,decimal price)
        {
            this.Number = number;
            this.Type = type;
            this.Phone = phone;
            this.Available = available;
            this.Price= price;
        }
        public Room(int number)
        {
            this.Number = number;
        }
    }
}
