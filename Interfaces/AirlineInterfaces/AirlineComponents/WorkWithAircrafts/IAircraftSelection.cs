using Interfaces.TransportAircraftInterfaces;
using System;
using System.Collections.Generic;

namespace Interfaces.AirlineInterfaces.AirlineComponents.WorkWithAircrafts
{
    public interface IAircraftSelection
    {
        IEnumerable<ITransportAircraft> SortAircraftAscending<T>(IEnumerable<ITransportAircraft> transportAircrafts,
            Func<ITransportAircraft, T> sortingCriteria);

        IEnumerable<ITransportAircraft> SortAircraftDescending<T>(IEnumerable<ITransportAircraft> transportAircrafts,
            Func<ITransportAircraft, T> sortingCriteria);

        IEnumerable<ITransportAircraft> SearchForSuitableAircraftByRange(IEnumerable<ITransportAircraft> transportAircrafts,
            Func<ITransportAircraft, double> searchCriteria, double lowerBound, double upperBound);
    }
}
