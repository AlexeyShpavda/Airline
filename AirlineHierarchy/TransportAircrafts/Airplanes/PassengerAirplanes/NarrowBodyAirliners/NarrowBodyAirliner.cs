using Interfaces.TransportAircraftInterfaces.Airplanes.PassengerAirplanes.Enums;

namespace AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.NarrowBodyAirliners
{
    public abstract class NarrowBodyAirliner : PassengerAirplane
    {
        public sealed override FlightRangeClassification FlightRangeClassification =>
            FlightRangeClassification.MediumHaul;
    }
}
