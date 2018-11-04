﻿using Interfaces.TransportAircraftInterfaces.Airplanes.PassengerAirplanes.Enums;
using Interfaces.TransportAircraftInterfaces.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.TransportAircraftInterfaces.Airplanes.PassengerAirplanes
{
    public interface IPassengerAirplane : ITransportAircraft
    {
        FlightRangeClassification FlightRangeClassification { get; }

        int SeatsNumber { get; }

        new TransportedType TransportedType { get; }
    }
}
