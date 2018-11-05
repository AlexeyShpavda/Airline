using Interfaces.TransportAircraftInterfaces.Airplanes.PassengerAirplanes.Enums;
using Interfaces.TransportAircraftInterfaces.Enums;

namespace Interfaces.TransportAircraftInterfaces.Airplanes.PassengerAirplanes
{
    public interface IPassengerAirplane : ITransportAircraft
    {
        FlightRangeClassification FlightRangeClassification { get; }

        int SeatsNumber { get; }

        new TransportedType TransportedType { get; }
    }
}
