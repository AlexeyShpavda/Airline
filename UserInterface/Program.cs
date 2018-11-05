using AirlineCore;
using AirlineCore.AirlineComponents.WorkWithAircraft;
using AirlineHierarchy.TransportAircrafts.Airplanes.CargoAirplanes.Models;
using AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.LocalAirliners.Models;
using AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.NarrowBodyAirliners.Models;
using AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.RegionalAirliners.Models;
using AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.WideBodyAirliners.Models;
using Interfaces.TransportAircraftInterfaces.Airplanes.CargoAirplanes;
using Interfaces.TransportAircraftInterfaces.Airplanes.PassengerAirplanes;
using System;

namespace UserInterface
{
    internal class Program
    {
        private static void Main()
        {
            var airline = new Airline("AS_AIR", new AircraftManagement(), new AircraftSelection());

            airline.BuyAircraft<AirbusA380>(3);
            airline.BuyAircraft<AirbusBelugaXL>(2);
            airline.BuyAircraft<Boeing737>(1);
            airline.BuyAircraft<ComacARJ21>(1);
            airline.BuyAircraft<CirrusSR22>(3);

            var passengerAirplanes = airline.ShowAircraftOfCertainType<IPassengerAirplane>();
            var cargoAirplanes = airline.ShowAircraftOfCertainType<ICargoAirplane>();

            // Capacity for Passenger Aircraft is Number of Seats
            var seatsNumber = airline.GetInformationAboutTotal(passengerAirplanes, x => x.SeatsNumber);

            // Capacity for Cargo Aircraft is Volume of Cargo Compartment
            var cargoCompartmentVolume = airline.GetInformationAboutTotal(cargoAirplanes, x => x.CargoCompartmentVolume);

            // Total Load Capacity (Weight (Kg))
            var loadCapacity = airline.GetInformationAboutTotal(passengerAirplanes, x => x.LoadCapacity);

            // Flight Range Sorting
            var sortedTransportAircraft = airline.SortAircraftDescending(x => x.FlightRange);

            // Aircraft which Correspond to a Given Range of Fuel Consumption Parameters
            var lowerBound = 0;
            var upperBound = 0.5;
            var suitableTransportAircraft =
                airline.SearchForSuitableAircraftByRange(x => x.FuelConsumption, lowerBound, upperBound);

            Console.WriteLine("========== General Information About Aircraft ==========");
            Console.WriteLine($"Total Number of Seats - {seatsNumber}");
            Console.WriteLine($"Total Cargo Compartment Volume - {cargoCompartmentVolume} m^3");
            Console.WriteLine($"Total Load Capacity - {loadCapacity} kg");

            Console.WriteLine("\n================= All Airline Aircraft =================");
            foreach (var aircraft in airline.ShowAllAircraft())
            {
                Console.WriteLine(aircraft);
            }

            Console.WriteLine("\n====== All Airline Aircraft Sorted by Flight Range ======");
            foreach (var aircraft in sortedTransportAircraft)
            {
                Console.WriteLine($"{aircraft}, Flight Range - {aircraft.FlightRange}");
            }

            Console.WriteLine("\n=============== Suitable Airline Aircraft ===============");
            Console.WriteLine($"Lower Bound - {lowerBound}, Upper Bound - {upperBound}");
            foreach (var aircraft in suitableTransportAircraft)
            {
                Console.WriteLine($"{aircraft}, Fuel Consumption - {aircraft.FuelConsumption}");
            }

            Console.ReadKey();
        }
    }
}
