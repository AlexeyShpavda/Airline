using Interfaces.AirlineInterfaces.AirlineComponents.WorkWithAircraft;
using Interfaces.TransportAircraftInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirlineCore.AirlineComponents.WorkWithAircraft
{
    public class AircraftSelection : IAircraftSelection
    {
        public IEnumerable<ITransportAircraft> SortAircraftAscending<T>(IEnumerable<ITransportAircraft> transportAircraft,
            Func<ITransportAircraft, T> sortingCriteria)
        {
            return new List<ITransportAircraft>(transportAircraft.OrderBy(sortingCriteria));
        }

        public IEnumerable<ITransportAircraft> SortAircraftDescending<T>(IEnumerable<ITransportAircraft> transportAircraft,
            Func<ITransportAircraft, T> sortingCriteria)
        {
            return new List<ITransportAircraft>(transportAircraft.OrderByDescending(sortingCriteria));
        }

        public IEnumerable<ITransportAircraft> SearchForSuitableAircraftByRange(IEnumerable<ITransportAircraft> transportAircraft,
            Func<ITransportAircraft, double> searchCriteria, double lowerBound, double upperBound)
        {
            var suitableTransportAircraft = from x in transportAircraft
                                             where searchCriteria(x) >= lowerBound &&
                                                   searchCriteria(x) <= upperBound
                                             select x;

            return new List<ITransportAircraft>(suitableTransportAircraft);
        }
    }
}
