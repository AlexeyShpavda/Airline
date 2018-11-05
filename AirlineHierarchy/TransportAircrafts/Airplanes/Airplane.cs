using Interfaces.TransportAircraftInterfaces.Enums;

namespace AirlineHierarchy.TransportAircrafts.Airplanes
{
    public abstract class Airplane : TransportAircraft
    {
        public sealed override AircraftType AircraftType => AircraftType.Airplane;

        public override string ToString() => $"{AircraftType}, {base.ToString()}";
    }
}
