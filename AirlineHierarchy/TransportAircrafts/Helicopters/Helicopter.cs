using Interfaces.TransportAircraftInterfaces.Enums;

namespace AirlineHierarchy.TransportAircrafts.Helicopters
{
    public abstract class Helicopter : TransportAircraft
    {
        public sealed override AircraftType AircraftType => AircraftType.Helicopter;
    }
}
