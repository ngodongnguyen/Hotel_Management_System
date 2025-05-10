using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace BusinessLayer
{
    public class CheckOutBL
    {
        private CheckOutDL checkOutDL;
        public CheckOutBL()
        {
            checkOutDL = new CheckOutDL();
        }
        public DataTable DisplayCheckOut()
        {
            return checkOutDL.DisplayCheckOut();
        }
        public bool AddCheckOut(CheckOut checkOut)
        {
            return checkOutDL.AddCheckOut(checkOut);
        }
        public bool UpdateCheckOut(int id)
        {
            return checkOutDL.UpdateCheckOut(id);
        }
    }
}
