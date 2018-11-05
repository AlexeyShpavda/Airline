using Interfaces.TransportAircraftInterfaces;
using System;
using System.Collections.Generic;

namespace Interfaces.AirlineInterfaces.AirlineComponents.WorkWithAircraft
{
    public interface IAircraftSelection
    {
        IEnumerable<ITransportAircraft> SortAircraftAscending<T>(IEnumerable<ITransportAircraft> transportAircraft,
            Func<ITransportAircraft, T> sortingCriteria);

        IEnumerable<ITransportAircraft> SortAircraftDescending<T>(IEnumerable<ITransportAircraft> transportAircraft,
            Func<ITransportAircraft, T> sortingCriteria);

        IEnumerable<ITransportAircraft> SearchForSuitableAircraftByRange(IEnumerable<ITransportAircraft> transportAircraft,
            Func<ITransportAircraft, double> searchCriteria, double lowerBound, double upperBound);
    }
}
