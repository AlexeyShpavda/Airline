using Interfaces.TransportAircraftInterfaces.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.TransportAircraftInterfaces
{
    public interface ITransportAircraft
    {
        string Model { get; }

        string Manufacturer { get; }

        // Kilometers
        int FlightRange { get; }

        // Gallons of Fuel per Nautical Mile
        double FuelConsumption { get; }

        // Weight (kg)
        int LoadCapacity { get; }

        AircraftType AircraftType { get; }

        TransportedType TransportedType { get; }

        Category Category { get; }

        ServiceType ServiceType { get; }

        Guid SerialNumber { get; }
    }
}
