using Interfaces.AirlineInterfaces.AirlineComponents.WorkWithAircrafts;
using Interfaces.TransportAircraftInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineCore.AirlineComponents.WorkWithAircrafts
{
    public class AircraftSelection : IAircraftSelection
    {
        public IEnumerable<ITransportAircraft> SortAircraftAscending<T>(IEnumerable<ITransportAircraft> transportAircrafts,
            Func<ITransportAircraft, T> sortingCriteria)
        {
            return new List<ITransportAircraft>(transportAircrafts.OrderBy(sortingCriteria));
        }

        public IEnumerable<ITransportAircraft> SortAircraftDescending<T>(IEnumerable<ITransportAircraft> transportAircrafts,
            Func<ITransportAircraft, T> sortingCriteria)
        {
            return new List<ITransportAircraft>(transportAircrafts.OrderByDescending(sortingCriteria));
        }

        public IEnumerable<ITransportAircraft> SearchForSuitableAircraftByRange(IEnumerable<ITransportAircraft> transportAircrafts,
            Func<ITransportAircraft, double> searchCriteria, double lowerBound, double upperBound)
        {
            var suitableTransportAircrafts = from x in transportAircrafts
                                             where searchCriteria(x) >= lowerBound &&
                                                   searchCriteria(x) <= upperBound
                                             select x;

            return new List<ITransportAircraft>(suitableTransportAircrafts);
        }
    }
}
