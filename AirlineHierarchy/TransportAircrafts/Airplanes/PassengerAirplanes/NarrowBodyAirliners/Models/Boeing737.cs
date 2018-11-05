namespace AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.NarrowBodyAirliners.Models
{
    public class Boeing737 : NarrowBodyAirliner
    {
        public override string Model => "737";

        public override string Manufacturer => "Boeing";

        public override int FlightRange => 5600;

        public override double FuelConsumption => 8;

        public override int LoadCapacity => 65000;

        public override int SeatsNumber => 162;

        public override string ToString() => $"{OverrideToStringInModels()}, {base.ToString()}";
    }
}
