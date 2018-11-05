using Interfaces.TransportAircraftInterfaces.Airplanes.PassengerAirplanes.Enums;

namespace AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.RegionalAirliners
{
    public abstract class RegionalAirliner : PassengerAirplane
    {
        public sealed override FlightRangeClassification FlightRangeClassification =>
            FlightRangeClassification.ShortHaul;
    }
}
