using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class CheckOut
    {
        public int CheckOut_ID { get; set; }
        public int Reservation_ID { get; set; }
        public decimal Total_Price { get; set; }
        public string CheckOut_Status { get; set; }
        public CheckOut() { }
        public CheckOut(int checkOut_ID, int reservation_ID, decimal total_Price, string checkOut_Status)
        {
            CheckOut_ID = checkOut_ID;
            Reservation_ID = reservation_ID;
            Total_Price = total_Price;
            CheckOut_Status = checkOut_Status;
        }
        public CheckOut(int reservation_ID, decimal total_Price, string checkOut_Status)
        {
            Reservation_ID = reservation_ID;
            Total_Price = total_Price;
            CheckOut_Status = checkOut_Status;
        }
    }
}
