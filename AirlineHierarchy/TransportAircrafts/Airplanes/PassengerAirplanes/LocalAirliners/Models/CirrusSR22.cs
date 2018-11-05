namespace AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.LocalAirliners.Models
{
    public class CirrusSR22 : LocalAirliner
    {
        public override string Model => "SR22";

        public override string Manufacturer => "Cirrus";

        public override int FlightRange => 900;

        public override double FuelConsumption => 0.1;

        public override int LoadCapacity => 1500;

        public override int SeatsNumber => 4;

        public override string ToString() => $"{OverrideToStringInModels()}, {base.ToString()}";
    }
}
