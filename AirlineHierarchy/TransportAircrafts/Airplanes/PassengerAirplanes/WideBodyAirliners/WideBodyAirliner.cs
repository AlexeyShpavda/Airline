using Interfaces.TransportAircraftInterfaces.Airplanes.PassengerAirplanes.Enums;

namespace AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.WideBodyAirliners
{
    public abstract class WideBodyAirliner : PassengerAirplane
    {
        public sealed override FlightRangeClassification FlightRangeClassification =>
            FlightRangeClassification.LongHaul;
    }
}
