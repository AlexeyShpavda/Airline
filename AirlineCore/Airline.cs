using System;
using System.Collections.Generic;
using Interfaces.AirlineInterfaces;
using Interfaces.AirlineInterfaces.AirlineComponents.WorkWithAircrafts;
using Interfaces.TransportAircraftInterfaces;

namespace AirlineCore
{
    public class Airline : IAirline
    {
        public string Name { get; set; }

        private IAircraftManagement AircraftManagement { get; set; }

        private IAircraftSelection AircraftSelection { get; set; }

        private IEnumerable<ITransportAircraft> TransportAircrafts { get; set; }

        public Airline(string name, IAircraftManagement aircraftManagement,
            IAircraftSelection aircraftSelection, IEnumerable<ITransportAircraft> transportAircrafts)
        {
            Name = name;
            AircraftManagement = aircraftManagement;
            AircraftSelection = aircraftSelection;
            TransportAircrafts = transportAircrafts;
        }

        public void BuyAircrafts<T>(int quantity) where T : ITransportAircraft, new()
        {
            AircraftManagement.BuyAircrafts<T>(
                (ICollection<ITransportAircraft>) TransportAircrafts, quantity);
        }

        public void SellAircraft(ITransportAircraft transportAircrafts)
        {
            AircraftManagement.SellAircraft((ICollection<ITransportAircraft>) TransportAircrafts, transportAircrafts);
        }

        public IEnumerable<ITransportAircraft> ShowAllAircraft()
        {
            return AircraftManagement.ShowAllAircraft(TransportAircrafts);
        }

        public IEnumerable<T> ShowAircraftsOfCertainType<T>() where T : ITransportAircraft
        {
            return AircraftManagement.ShowAircraftsOfCertainType<T>(TransportAircrafts);
        }

        public int GetInformationAboutTotal<T>(IEnumerable<T> transportAircrafts, Func<T, int> countingСriteria)
            where T : ITransportAircraft
        {
            return AircraftManagement.GetInformationAboutTotal(transportAircrafts, countingСriteria);
        }

        public IEnumerable<ITransportAircraft> SortAircraftAscending<T>(Func<ITransportAircraft, T> sortingCriteria)
        {
            return AircraftSelection.SortAircraftAscending(TransportAircrafts, sortingCriteria);
        }

        public IEnumerable<ITransportAircraft> SortAircraftDescending<T>(Func<ITransportAircraft, T> sortingCriteria)
        {
            return AircraftSelection.SortAircraftDescending(TransportAircrafts, sortingCriteria);
        }

        public IEnumerable<ITransportAircraft> SearchForSuitableAircraftByRange(
            Func<ITransportAircraft, double> searchCriteria, double lowerBound, double upperBound)
        {
            return AircraftSelection.SearchForSuitableAircraftByRange(TransportAircrafts, searchCriteria, lowerBound,
                upperBound);
        }
    }
}
