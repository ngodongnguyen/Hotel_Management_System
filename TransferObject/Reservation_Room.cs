using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Reservation_Room
    {
        public int Reservation_ID { get; set; }
        public decimal Price { get; set; }
        public Reservation_Room(int Reservation_ID, decimal Price)
        {
            this.Reservation_ID=Reservation_ID;
            this.Price = Price;
        }
    }
}
