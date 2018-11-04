using AirlineCore;
using AirlineCore.AirlineComponents.WorkWithAircrafts;
using AirlineHierarchy.TransportAircrafts.Airplanes.CargoAirplanes.Models;
using AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.LocalAirliners.Models;
using AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.NarrowBodyAirliners.Models;
using AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.RagionalAirliners.Models;
using AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.WideBodyAirliners.Models;
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

            airline.BuyAircrafts<AirbusA380>(3);
            airline.BuyAircrafts<AirbusBelugaXL>(2);
            airline.BuyAircrafts<Boeing737>(1);
            airline.BuyAircrafts<ComacARJ21>(1);
            airline.BuyAircrafts<CirrusSR22>(3);
        }
    }
}
