﻿using System;
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
        public DataTable CountOrder()
        {
            return reservationDL.CountOrder();
        }
        public DataTable GetCheckOutData()
        {
            return reservationDL.GetCheckOutData();
        }
        public DataTable GetTotalRevenue(DateTime sdate,DateTime edate)
        {
            return reservationDL.GetTotalRevenue(sdate,edate);
        }
        public DataTable GetRoomType(DateTime sdate, DateTime edate)
        {
            return reservationDL.GetRoomType(sdate,edate);
        }
        public DataTable GetInvoiceData(int reservationId)
        {
            return reservationDL.GetInvoiceData(reservationId);
        }
        public DataTable GetMostFrequentCustomer(DateTime sdate,DateTime edate)
        {
            return reservationDL.GetMostFrequentCustomer(sdate, edate);
        }
        public DataTable GetTopSpenders(DateTime sdate,DateTime edate)
        {
            return reservationDL.GetTopSpenders(sdate, edate);
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
