using Interfaces.TransportAircraftInterfaces.Airplanes.PassengerAirplanes;
using Interfaces.TransportAircraftInterfaces.Airplanes.PassengerAirplanes.Enums;
using Interfaces.TransportAircraftInterfaces.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes
{
    public abstract class PassengerAirplane : Airplane, IPassengerAirplane
    {
        public abstract FlightRangeClassification FlightRangeClassification { get; }

        public abstract int SeatsNumber { get; }

        public sealed override TransportedType TransportedType => TransportedType.Passenger;

        public override string ToString() => $"{TransportedType} {base.ToString()}";
    }
}
