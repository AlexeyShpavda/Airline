using Interfaces.TransportAircraftInterfaces.Enums;

namespace Interfaces.TransportAircraftInterfaces.Airplanes.CargoAirplanes
{
    public interface ICargoAirplane : ITransportAircraft
    {
        // Volume (m^3)
        int CargoCompartmentVolume { get; }

        new TransportedType TransportedType { get; }
    }
}
