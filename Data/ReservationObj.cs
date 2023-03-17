using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Data
{
	public class ReservationObj
	{
		public string ReservCode { get; set; }
		public FlightObj Flight { get; set; }

		public string Name { get; set; }

		public string Nationality { get; set; }

		public string Status { get; set; } = "Active";
		public ReservationObj(string reservCode, FlightObj flight, string name, string nationality)
		{
			this.ReservCode = reservCode;
			this.Flight = flight;
			this.Name = name;
			this.Nationality = nationality;
		}
		public override string ToString()
		{
			return ($"{ReservCode},{Flight.FlightCode},{Flight.airline},{Flight.Cost},{Name},{Nationality},{Status}");
		}
	}
}
