using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Account
    {
        public int ID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; } 

        public Account() { }

        //Constructor không cần ID khi thêm mới
        public Account(string user, string pass) 
        {
            this.Username= user;
            this.Password= pass;
        }
        //Constructor đầy đủ để update
        public Account(int ID, string user,string pass) 
        { 
            this.ID = ID;
            this.Username= user;
            this.Password= pass;
        }
        //Constructor chỉ cần ID để xóa
        public Account(int ID)
        {
            this.ID = ID;
        }
    }
}
