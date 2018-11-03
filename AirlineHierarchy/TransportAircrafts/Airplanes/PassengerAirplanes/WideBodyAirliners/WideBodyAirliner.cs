using Interfaces.TransportAircraftInterfaces.Airplanes.PassengerAirplanes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.WideBodyAirliners
{
    public abstract class WideBodyAirliner : PassengerAirplane
    {
        public sealed override FlightRangeClassification FlightRangeClassification =>
            FlightRangeClassification.LongHaul;
    }
}
