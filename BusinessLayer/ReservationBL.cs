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
    public class ReservationBL
    {
        private ReservationDL reservationDL;
        public ReservationBL()
        {
            reservationDL= new ReservationDL();
        }
        public bool AddReservation(Reservation reservation)
        {
            return reservationDL.AddReservation(reservation);
        }
        public DataTable DisplayReservation()
        {
            return reservationDL.DisplayReservation();
        }
        public Reservation_Room GetPrice(int reservationId)
        {
            return reservationDL.GetPrice(reservationId);
        }
        public DataTable GetCheckOutData()
        {
            return reservationDL.GetCheckOutData();
        }

        public DataTable SearchReservation(string keyword)
        {
            return reservationDL.SearchReservation(keyword);
        }
        public bool UpdateReservation(Reservation reservation)
        {
            return reservationDL.UpdateReservation(reservation);
        }
        public bool CancelReservation(Reservation reservation)
        {
            return reservationDL.CancelReservation(reservation);
        }
    }
}
