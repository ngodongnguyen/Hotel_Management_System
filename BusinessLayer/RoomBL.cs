using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace BusinessLayer
{
    public class RoomBL
    {
        private RoomDL roomDL;
        public RoomBL()
        {
            roomDL = new RoomDL();
        }
        public bool AddRoom(Room room)
        {
            return roomDL.AddRoom(room);
        }
        public DataTable DisplayRoom()
        {
            return roomDL.DisplayRoom();
        }
        public DataTable SearchRoom(string keyword)
        {
            return roomDL.SearchRoom(keyword);
        }
        public bool UpdateRoom(Room room)
        {
            return roomDL.UpdateRoom(room);
        }

        public bool DeleteRoom(Room room)
        {
            return roomDL.DeleteRoom(room);
        }

        public bool UpdateReservationRoom(string roomNumber, string roomAvailable)
        {
            return roomDL.UpdateReservationRoom(roomNumber,roomAvailable);
        }
        public List<string> RoomTypes()

        {
            return roomDL.RoomTypes();
        }

        public List<string> RoomNumbers(string type)
        {
            return roomDL.RoomNumbers(type);
        }

    }
}
