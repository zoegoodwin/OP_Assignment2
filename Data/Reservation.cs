using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Data
{
	//will manage the reservation text file
	class Reservation
	{
		private string code;
		private string flight;
		private string airline;
		private string cost;
		private string name;
		private string citizenship;
		private string status;

		//class constructor REDO THIS
		//public Reservation(int aReservationCode, string aAirline, string aTravelerFullName)
		//{
		//	this.reservationCode = aReservationCode;
		//	this.airline = aAirline;
		//	this.name = aTravelerFullName;
		//}
		public Reservation(string code, string flight, string airline, string cost, string name, string citizenship, string status)
		{
			this.code = code;
			this.flight = flight;
			this.airline = airline;
			this.cost = cost;
			this.name = name;
			this.citizenship = citizenship;
			this.status = status;
		}

		//// getters and setters
		//public int ReservationCode { get {  return reservationCode; } set { reservationCode = value; } }
		//public string Airline { get {  return airline; } set { airline = value; } }
		//public string TravelerFullName { get {  return name; } set { name = value; } }

		public string Code { get { return code; } }
		public string Flight { get { return flight; } }
		public string Airline { get {  return airline; } }
        public string Cost { get { return cost; } }
        public string Name { get { return name; }}
		public string Citizenship { get {  return citizenship; }}
		public string Status { get { return status; }}



	}
}
