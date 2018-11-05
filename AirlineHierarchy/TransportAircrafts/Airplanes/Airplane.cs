using Interfaces.TransportAircraftInterfaces.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AirlineHierarchy.TransportAircrafts.Airplanes
{
    public abstract class Airplane : TransportAircraft
    {
        public sealed override AircraftType AircraftType => AircraftType.Airplane;

        public override string ToString() => $"{AircraftType}, {base.ToString()}";
    }
}
