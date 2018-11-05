using Interfaces.TransportAircraftInterfaces;
using Interfaces.TransportAircraftInterfaces.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AirlineHierarchy.TransportAircrafts
{
    public abstract class TransportAircraft : ITransportAircraft
    {
        public abstract string Model { get; }

        public abstract string Manufacturer { get; }

        // Kilometers
        public abstract int FlightRange { get; }

        // Gallons of Fuel per Nautical Mile
        public abstract double FuelConsumption { get; }

        // Weight (kg)
        public abstract int LoadCapacity { get; }

        public abstract AircraftType AircraftType { get; }

        public abstract TransportedType TransportedType { get; }

        public Category Category => Category.Civil;

        public ServiceType ServiceType => ServiceType.Transport;

        public Guid SerialNumber => Guid.NewGuid();

        public override string ToString() => $"Serial Number: {SerialNumber}";
    }
}
