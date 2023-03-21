using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Data
{
	internal class ReservationManager
	{
		//location of reservation,
		public const string reservation_binary = "res/reservation.bin";//or in text form, easier to read
		
        public static List<Reservation> rList = new List<Reservation>();

        //Dummy information for reservations 
        //Reservation reserve1 = new Reservation("G1234", "YYC", "Smith", "Canadian","599.99","TB-4017");
        //Reservation reserve2 = new Reservation("B1234", "YEG", "James", "Canadian", "570.99", "OA-8724");
        //Reservation reserve3 = new Reservation("C1234", "ATL", "Lenord", "Canadian", "250.99", "SL-1151");

        public static void populateLists()
        {
            Reservation reserve1 = new Reservation("G1234", "TB-4017", "YYC", "599.99", "Smith", "Canadian", "Active");
            Reservation reserve2 = new Reservation("B1234", "OA-8724", "YEG", "599.99", "James", "Canadian", "Active");
            Reservation reserve3 = new Reservation("C1234", "SL-1151", "ATL", "599.99", "Lenord", "Canadian", "Inactive");

            rList.Add(reserve1);
            rList.Add(reserve2);
            rList.Add(reserve3);
        }

        public ReservationManager()
        {
            populateLists();
        }

        public static List<Reservation> GetReservations()
        {
            return rList;
        }

        public static List<Reservation> revertList()
        {
            rList.Clear();
            populateLists();
            return rList = GetReservations();
        }

        //make a res; param flight to book, param name of person, param citizenship; return created res. public
        public static Reservation createRes(string flight, List<Flight> fList, string personName, string citizenship)
        {
            //Getting flight information
            return null;

        }


        //find the res by airline or code; param resCode, param airline, param name of person; return res objects. use tostring method




        //find the res by code; param resCode, return res object

    }
}
