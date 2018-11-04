using Interfaces.TransportAircraftInterfaces.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.TransportAircraftInterfaces.Airplanes.CargoAirplanes
{
    public interface ICargoAirplane : ITransportAircraft
    {
        // Volume (m^3)
        int CargoCompartmentVolume { get; }

        new TransportedType TransportedType { get; }
    }
}
