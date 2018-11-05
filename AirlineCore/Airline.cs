using System;
using System.Collections.Generic;
using Interfaces.AirlineInterfaces;
using Interfaces.AirlineInterfaces.AirlineComponents.WorkWithAircraft;
using Interfaces.TransportAircraftInterfaces;

namespace AirlineCore
{
    public class Airline : IAirline
    {
        public string Name { get; set; }

        private IAircraftManagement AircraftManagement { get; set; }

        private IAircraftSelection AircraftSelection { get; set; }

        private IEnumerable<ITransportAircraft> TransportAircraft { get; set; }

        public Airline(string name, IAircraftManagement aircraftManagement, IAircraftSelection aircraftSelection)
        {
            Name = name;
            AircraftManagement = aircraftManagement;
            AircraftSelection = aircraftSelection;
            TransportAircraft = new List<ITransportAircraft>();
        }

        public void BuyAircraft<T>(int quantity) where T : ITransportAircraft, new()
        {
            AircraftManagement.BuyAircraft<T>(
                (ICollection<ITransportAircraft>) TransportAircraft, quantity);
        }

        public void SellAircraft(ITransportAircraft transportAircraft)
        {
            AircraftManagement.SellAircraft((ICollection<ITransportAircraft>) TransportAircraft, transportAircraft);
        }

        public IEnumerable<ITransportAircraft> ShowAllAircraft()
        {
            return AircraftManagement.ShowAllAircraft(TransportAircraft);
        }

        public IEnumerable<T> ShowAircraftOfCertainType<T>() where T : ITransportAircraft
        {
            return AircraftManagement.ShowAircraftOfCertainType<T>(TransportAircraft);
        }

        public int GetInformationAboutTotal<T>(IEnumerable<T> transportAircraft, Func<T, int> countingCriteria)
            where T : ITransportAircraft
        {
            return AircraftManagement.GetInformationAboutTotal(transportAircraft, countingCriteria);
        }

        public IEnumerable<ITransportAircraft> SortAircraftAscending<T>(Func<ITransportAircraft, T> sortingCriteria)
        {
            return AircraftSelection.SortAircraftAscending(TransportAircraft, sortingCriteria);
        }

        public IEnumerable<ITransportAircraft> SortAircraftDescending<T>(Func<ITransportAircraft, T> sortingCriteria)
        {
            return AircraftSelection.SortAircraftDescending(TransportAircraft, sortingCriteria);
        }

        public IEnumerable<ITransportAircraft> SearchForSuitableAircraftByRange(
            Func<ITransportAircraft, double> searchCriteria, double lowerBound, double upperBound)
        {
            return AircraftSelection.SearchForSuitableAircraftByRange(TransportAircraft, searchCriteria, lowerBound,
                upperBound);
        }
    }
}
