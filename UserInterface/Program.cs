using AirlineCore;
using AirlineCore.AirlineComponents.WorkWithAircrafts;
using Interfaces.TransportAircraftInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var airline = new Airline("AS_AIR", new AircraftManagement(), new AircraftSelection(),
                new List<ITransportAircraft>());
        }
    }
}
