using Interfaces.TransportAircraftInterfaces;
using System;
using System.Collections.Generic;

namespace Interfaces.AirlineInterfaces
{
    public interface IAirline
    {
        string Name { get; set; }

        void BuyAircraft<T>(int quantity) where T : ITransportAircraft, new();

        void SellAircraft(ITransportAircraft transportAircraft);

        IEnumerable<ITransportAircraft> ShowAllAircraft();

        IEnumerable<T> ShowAircraftOfCertainType<T>() where T : ITransportAircraft;

        int GetInformationAboutTotal<T>(IEnumerable<T> transportAircraft, Func<T, int> indicatorOfInterest)
            where T : ITransportAircraft;

        IEnumerable<ITransportAircraft> SortAircraftAscending<T>(Func<ITransportAircraft, T> sortingCriteria);

        IEnumerable<ITransportAircraft> SortAircraftDescending<T>(Func<ITransportAircraft, T> sortingCriteria);

        IEnumerable<ITransportAircraft> SearchForSuitableAircraftByRange(
            Func<ITransportAircraft, double> searchCriteria, double lowerBound, double upperBound);
    }
}
