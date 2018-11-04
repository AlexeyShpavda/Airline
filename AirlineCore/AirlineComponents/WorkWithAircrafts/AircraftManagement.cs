using Interfaces.AirlineInterfaces.AirlineComponents.WorkWithAircrafts;
using Interfaces.TransportAircraftInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineCore.AirlineComponents.WorkWithAircrafts
{
    public class AircraftManagement : IAircraftManagement
    {
        public void BuyAircrafts<T>(ICollection<ITransportAircraft> transportAircrafts, int quantity)
            where T : ITransportAircraft, new()
        {
            while (quantity > 0)
            {
                transportAircrafts.Add(new T());
                quantity--;
            }
        }

        public void SellAircraft(ICollection<ITransportAircraft> transportAircrafts, ITransportAircraft transportAircraft)
        {
            transportAircrafts.Remove(transportAircraft);
        }

        public IEnumerable<ITransportAircraft> ShowAllAircraft(IEnumerable<ITransportAircraft> transportAircrafts)
        {
            return transportAircrafts;
        }

        public IEnumerable<T> ShowAircraftsOfCertainType<T>(IEnumerable<ITransportAircraft> transportAircrafts)
            where T : ITransportAircraft
        {
            return new List<T>(transportAircrafts.OfType<T>());
        }

        public int GetInformationAboutTotal<T>(IEnumerable<T> transportAircrafts, Func<T, int> summationСriteria)
            where T : ITransportAircraft
        {
            return transportAircrafts.Sum(summationСriteria);
        }
    }
}
