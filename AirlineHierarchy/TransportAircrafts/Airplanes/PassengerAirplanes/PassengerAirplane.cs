using Interfaces.TransportAircraftInterfaces.Airplanes.PassengerAirplanes.Enums;
using Interfaces.TransportAircraftInterfaces.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes
{
    public abstract class PassengerAirplane : Airplane
    {
        public abstract FlightRangeClassification FlightRangeClassification { get; }

        public abstract int SeatsNumber { get; }

        public sealed override TransportedType TransportedType => TransportedType.Passenger;

        public override string ToString()
        {
            return $"{TransportedType} {base.ToString()}";
        }
    }
}
