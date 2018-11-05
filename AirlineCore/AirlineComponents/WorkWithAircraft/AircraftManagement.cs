using Interfaces.AirlineInterfaces.AirlineComponents.WorkWithAircraft;
using Interfaces.TransportAircraftInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirlineCore.AirlineComponents.WorkWithAircraft
{
    public class AircraftManagement : IAircraftManagement
    {
        public void BuyAircraft<T>(ICollection<ITransportAircraft> transportAircraft, int quantity)
            where T : ITransportAircraft, new()
        {
            while (quantity > 0)
            {
                transportAircraft.Add(new T());
                quantity--;
            }
        }

        public void SellAircraft(ICollection<ITransportAircraft> transportAircraftCollection, ITransportAircraft transportAircraft)
        {
            transportAircraftCollection.Remove(transportAircraft);
        }

        public IEnumerable<ITransportAircraft> ShowAllAircraft(IEnumerable<ITransportAircraft> transportAircraft)
        {
            return transportAircraft;
        }

        public IEnumerable<T> ShowAircraftOfCertainType<T>(IEnumerable<ITransportAircraft> transportAircraft)
            where T : ITransportAircraft
        {
            return new List<T>(transportAircraft.OfType<T>());
        }

        public int GetInformationAboutTotal<T>(IEnumerable<T> transportAircraft, Func<T, int> summationCriteria)
            where T : ITransportAircraft
        {
            return transportAircraft.Sum(summationCriteria);
        }
    }
}
