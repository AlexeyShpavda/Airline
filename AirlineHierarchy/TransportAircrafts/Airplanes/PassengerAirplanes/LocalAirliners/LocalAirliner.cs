using Interfaces.TransportAircraftInterfaces.Airplanes.PassengerAirplanes.Enums;

namespace AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.LocalAirliners
{
    public abstract class LocalAirliner : PassengerAirplane
    {
        public sealed override FlightRangeClassification FlightRangeClassification => FlightRangeClassification.Local;
    }
}
