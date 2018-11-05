namespace AirlineHierarchy.TransportAircrafts.Airplanes.CargoAirplanes.Models
{
    public class AirbusBelugaXL : CargoAirplane
    {
        public override string Model => "BelugaXL";

        public override string Manufacturer => "Airbus";

        public override int FlightRange => 4000;

        public override double FuelConsumption => 10;

        public override int LoadCapacity => 53000;

        public override int CargoCompartmentVolume => 1400;

        public override string ToString() => $"{OverrideToStringInModels()}, {base.ToString()}";
    }
}
