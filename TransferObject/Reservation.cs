using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Reservation
    {
        public int ID { get; set; }
        public string R_Type { get; set;}
        public int R_Number { get;set; }
        public int ClientID { get;set; }
        public DateTime In { get;set; }
        public DateTime Out { get;set; }
        public Reservation() { }
        public Reservation(int ID, string r_Type, int r_Number, int clientID, DateTime In, DateTime Out)
        {
            this.ID = ID;
            this.R_Type = r_Type;
            this.R_Number = r_Number;
            this.ClientID = clientID;
            this.In = In;
            this.Out = Out;
        }
        public Reservation(string r_Type, int r_Number,int clientID, DateTime In, DateTime Out)
        {   
            this.R_Type=r_Type;
            this.R_Number=r_Number;
            this.ClientID = clientID;
            this.In = In;
            this.Out = Out;
        }
        public Reservation(int ID)
        {
            this.ID = ID;
        }
    }
}
