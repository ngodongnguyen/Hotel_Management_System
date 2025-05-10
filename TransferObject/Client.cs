using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Client
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Client() { }
        public Client(string firstName, string lastName, string phone, string address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Address = address;
        }
        public Client(int ID, string firstName, string lastName, string phone, string address) 
        { 
            this.ID = ID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Address = address;
        }
        public Client(int ID) 
        { 
            this.ID = ID;
        }
    }
}
