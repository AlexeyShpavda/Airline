using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.WideBodyAirliners.Models
{
    public class AirbusA380 : WideBodyAirliner
    {
        public override string Model => "A380";

        public override string Manufacturer => "Airbus";

        public override int FlightRange => 15700;

        public override double FuelConsumption => 10;

        public override int LoadCapacity => 150000;

        public override int SeatsNumber => 853;

        public override string ToString() => $"{Manufacturer}, {Model}, {base.ToString()}";
    }
}
