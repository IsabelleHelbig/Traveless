using System.Runtime.CompilerServices;

namespace Traveless.Data;

public class FlightObj
{
	public string FlightCode { get; set; }
	public string DepartureAirport { get; set; }
	public string DestinationAirport { get; set; }
	public string FlyingDay { get; set; }
	public string FlyingTime { get; set; }
	public int Seats { get; set; }
	public double Cost { get; set; }
	public string airline { get; set; }
	public FlightObj(String flightCode,String airline, String departureAirport, string destinationAirport, string flyingDay, string flyingTime, int seats, double cost)
	{
		this.FlightCode= flightCode;
		switch (airline)
		{
			case "AS":
				airline = "AirShaker";
				break;
			case "AL":
				airline = "Always Late Airlines";
				break;
			case "CA":
				airline = "Conned Air";
				break;
			case "EC":
				airline = "Error Canada";
				break;
			case "GA":
				airline = "Gypped Air";
				break;
			case "MA":
				airline = "Mediocre Airlines";
				break;
			case "OA":
				airline = "Otto Airlines";
				break;
			case "SL":
				airline = "Scare Airlines";
				break;
			case "ST":
				airline = "ScareTransat";
				break;
			case "SW":
				airline = "Sprawl Airways";
				break;
			case "TB":
				airline = "Try a Bus Airways";
				break;
			case "VA":
				airline = "Vertical Airways";
				break;
		}
		this.airline = airline;
		this.DepartureAirport= departureAirport;	
		this.DestinationAirport= destinationAirport;
		this.FlyingDay= flyingDay;
		this.FlyingTime= flyingTime;
		this.Seats= seats;
		this.Cost= cost;
	}
	public override string ToString()
	{
		return($"{FlightCode},{DepartureAirport},{DestinationAirport},{FlyingDay},{FlyingTime},{Seats},{Cost},{airline}");
	}
}
