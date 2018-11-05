using AirlineCore;
using AirlineCore.AirlineComponents.WorkWithAircrafts;
using AirlineHierarchy.TransportAircrafts.Airplanes.CargoAirplanes.Models;
using AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.LocalAirliners.Models;
using AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.NarrowBodyAirliners.Models;
using AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.RagionalAirliners.Models;
using AirlineHierarchy.TransportAircrafts.Airplanes.PassengerAirplanes.WideBodyAirliners.Models;
using Interfaces.TransportAircraftInterfaces;
using Interfaces.TransportAircraftInterfaces.Airplanes.CargoAirplanes;
using Interfaces.TransportAircraftInterfaces.Airplanes.PassengerAirplanes;
using System;
using System.Collections.Generic;

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

            var passengerAirplanes = airline.ShowAircraftsOfCertainType<IPassengerAirplane>();
            var cargoAirplanes = airline.ShowAircraftsOfCertainType<ICargoAirplane>();

            // Capacity for Passenger Aircrafts is Number of Seats
            var seatsNumber = airline.GetInformationAboutTotal(passengerAirplanes, x => x.SeatsNumber);

            // Capacity for Cargo Aircrafts is Volume of Cargo Compartment
            var cargoCompartmentVolume = airline.GetInformationAboutTotal(cargoAirplanes, x => x.CargoCompartmentVolume);

            // Total Load Capacity (Weight (Kg))
            var loadCapacity = airline.GetInformationAboutTotal(passengerAirplanes, x => x.LoadCapacity);

            // Flight Range Sorting
            var sortedTransportAircrafts = airline.SortAircraftDescending(x => x.FlightRange);

            // Aircrafts which Correspond to a Given Range of Fuel Consumption Parameters
            double lowerBound = 0;
            double upperBound = 0.5;
            var suitableTransportAircrafts =
                airline.SearchForSuitableAircraftByRange(x => x.FuelConsumption, lowerBound, upperBound);

            Console.WriteLine("========== General Information About Aircrafts ==========");
            Console.WriteLine($"Total Number of Seats - {seatsNumber}");
            Console.WriteLine($"Total Cargo Compartment Volume - {cargoCompartmentVolume} m^3");
            Console.WriteLine($"Total Load Capacity - {loadCapacity} kg");

            Console.WriteLine("\n================= All Airline Aircrafts =================");
            foreach (var aircraft in airline.ShowAllAircraft())
            {
                Console.WriteLine(aircraft.ToString());
            }

            Console.WriteLine("\n====== All Airline Aircrafts Sorted by Flight Range ======");
            foreach (var aircraft in sortedTransportAircrafts)
            {
                Console.WriteLine($"{aircraft.ToString()}, Flight Range - {aircraft.FlightRange}");
            }

            Console.WriteLine("\n=============== Suitable Airline Aircrafts ===============");
            Console.WriteLine($"Lower Bound - {lowerBound}, Upper Bound - {upperBound}");
            foreach (var aircraft in suitableTransportAircrafts)
            {
                Console.WriteLine($"{aircraft.ToString()}, Fuel Consumption - {aircraft.FuelConsumption}");
            }

            Console.ReadKey();
        }
    }
}
