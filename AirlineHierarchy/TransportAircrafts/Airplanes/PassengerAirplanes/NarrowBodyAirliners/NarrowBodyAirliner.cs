﻿using Interfaces.TransportAircraftInterfaces.Airplanes.PassengerAirplanes.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.NarrowBodyAirliners
{
    public abstract class NarrowBodyAirliner : PassengerAirplane
    {
        public sealed override FlightRangeClassification FlightRangeClassification =>
            FlightRangeClassification.MediumHaul;
    }
}
