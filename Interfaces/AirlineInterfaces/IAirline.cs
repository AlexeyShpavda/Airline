using Interfaces.TransportAircraftInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.AirlineInterfaces
{
    public interface IAirline
    {
        string Name { get; set; }

        void BuyAircrafts<T>(int quantity) where T : ITransportAircraft, new();

        void SellAircraft(ITransportAircraft transportAircrafts);

        IEnumerable<ITransportAircraft> ShowAllAircraft();

        IEnumerable<T> ShowAircraftsOfCertainType<T>() where T : ITransportAircraft;

        int GetInformationAboutTotal<T>(IEnumerable<T> transportAircrafts, Func<T, int> indicatorOfInterest)
            where T : ITransportAircraft;

        IEnumerable<ITransportAircraft> SortAircraftAscending<T>(Func<ITransportAircraft, T> sortingCriteria);

        IEnumerable<ITransportAircraft> SortAircraftDescending<T>(Func<ITransportAircraft, T> sortingCriteria);

        IEnumerable<ITransportAircraft> SearchForSuitableAircraftByRange(
            Func<ITransportAircraft, double> searchCriteria, double lowerBound, double upperBound);
    }
}
