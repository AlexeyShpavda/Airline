using Interfaces.TransportAircraftInterfaces.Airplanes.CargoAirplanes;
using Interfaces.TransportAircraftInterfaces.Enums;

namespace AirlineHierarchy.TransportAircrafts.Airplanes.CargoAirplanes
{
    public abstract class CargoAirplane : Airplane, ICargoAirplane
    {
        // Volume (m^3)
        public abstract int CargoCompartmentVolume { get; }

        public sealed override TransportedType TransportedType => TransportedType.Cargo;

        public override string ToString() => $"{TransportedType} {base.ToString()}";
    }
}
