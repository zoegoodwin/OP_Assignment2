
using Microsoft.Maui.Controls.Shapes;
using Microsoft.UI.Xaml.Controls.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Data
{
	//will manage the flight list and airport list
	internal class FlightManager
	{
		//constants for Flights file and Airports file
		private const string FLIGHTS_CSV = @"C:\Users\V\Documents\GitHub\OP_Assignment2\flights.csv";
        private const string AIRPORTS_CSV = @"C:\Users\V\Documents\GitHub\OP_Assignment2\airports.csv";

        //list creation for the text files
        public static List<Flight> flightList = new List<Flight>();
		public static List<Airport> airportList = new List<Airport>();

		//constructor to populate the lists
		public FlightManager()
		{
			populateLists();
		}

		//method to populate Flight and Airport information: NEED TO EMBED FLIGHT AND AIRPORT INTO TRY/CATCH EXCEPTION STMT
		public static void populateLists() 
		{
			Flight flight;
			foreach(string line in System.IO.File.ReadAllLines(FLIGHTS_CSV)) 
			{
				//how to split
				string[] flightData = line.Split(",");
				//how to assign indices
				string code = flightData[0];
				string airline = flightData[1];
				string from = flightData[2];
				string to = flightData[3];
				string weekday = flightData[4];
				string time = flightData[5];
				int seats = int.Parse(flightData[6]);
				double costperseat = double.Parse(flightData[7]);
				//defining a flight
				flight = new Flight(code, airline, from, to, weekday, time, seats, costperseat);
				//adding a flight to the list
				flightList.Add(flight);
			}

			Airport airport;
			foreach(string line in System.IO.File.ReadAllLines(AIRPORTS_CSV))
			{
				//how to split
				string[] airportData = line.Split(",");
				//how to assign indices
				string code = airportData[0];
				string name = airportData[1];
				//defining an airport
				airport = new Airport(code, name);
				//adding an airport to the list
				airportList.Add(airport);
			}
		}

		//will return the list of flights
		public static List<Flight> GetFlights()
		{
            return flightList;
		}

		//will return the list of airports
		public static List<Airport> GetAirports()
		{
			return airportList;
		}

		//public const string Any = "Any" FOR WEEKDAYS, OR ENUM
		public const string Any = "Any"; 


		//find flight by code, param flight code, return flight object
		public static List<Flight> findFlightByFrom (List<Flight> fList, string fromCode) 
		{
            //Reverts list before search
            fList = revertList();

            //Edited flight list
            List<Flight> editedFlightList = new List<Flight>();

            //Every flight in the flight list 
            foreach (Flight flight in fList)
            {
                if (flight.From == fromCode)
                {
                    editedFlightList.Add(flight);
                }
            }
            return editedFlightList;
        }

        public static List<Flight> findFlightByTo(List<Flight> fList, string inputCode)
        {
            //Reverts list before search
            fList = revertList();

            //Edited flight list
            List<Flight> editedFlightList = new List<Flight>();

            //Every flight in the flight list 
            foreach (Flight flight in fList)
            {
                if (flight.To == inputCode)
                {
                    editedFlightList.Add(flight);
                }
            }
            return editedFlightList;
        }

        //find flight by weekday, param flight code, return flight object
        public static List<Flight> findFlightByWeekday(List<Flight> fList, string weekday)
        {
            //Reverts list before search
            fList = revertList();

            //Edited flight list
            List<Flight> editedFlightList = new List<Flight>();

            //Every flight in the flight list 
            foreach (Flight flight in fList)
            {
                if (flight.Weekday == weekday)
                {
                    editedFlightList.Add(flight);
                }
            }
            return editedFlightList;
        }


        //find flight going from A to B on specific day; param from airport code, param to airport code, param weekday; return flight list
        public static List<Flight> findFlightByRange (List<Flight> fList, string startAirport, string endAirport, string weekday)
		{
            //Reverts list before search
            fList = revertList();

            //Edited flight list
            List<Flight> editedFlightList = new List<Flight>();

            //Every flight in the flight list 
            foreach (Flight flight in fList)
			{
				//If the from matches start airport code and to ends endairport code
				if ((flight.From == startAirport) && (flight.To == endAirport) && (flight.Weekday == weekday)) 
				{
					editedFlightList.Add(flight);
                }
			}
            return editedFlightList;

        }

		public static List<Flight> revertList()
		{
			flightList.Clear();
            //Reverts list
            populateLists();
            return flightList = GetFlights();
        }

    }
}
