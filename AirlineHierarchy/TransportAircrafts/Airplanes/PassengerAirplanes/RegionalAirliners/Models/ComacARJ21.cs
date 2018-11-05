namespace AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.RegionalAirliners.Models
{
    public class ComacARJ21 : RegionalAirliner
    {
        public override string Model => "ARJ21";

        public override string Manufacturer => "Comac";

        public override int FlightRange => 2200;

        public override double FuelConsumption => 5;

        public override int LoadCapacity => 10150;

        public override int SeatsNumber => 95;

        public override string ToString() => $"{Manufacturer}, {Model}, {base.ToString()}";
    }
}
