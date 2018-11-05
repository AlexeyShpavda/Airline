using Interfaces.TransportAircraftInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.AirlineInterfaces.AirlineComponents.WorkWithAircrafts
{
    public interface IAircraftManagement
    {
        void BuyAircrafts<T>(ICollection<ITransportAircraft> transportAircrafts, int quantity)
            where T : ITransportAircraft, new();

        void SellAircraft(ICollection<ITransportAircraft> transportAircrafts, ITransportAircraft transportAircraft);

        IEnumerable<ITransportAircraft> ShowAllAircraft(IEnumerable<ITransportAircraft> transportAircrafts);

        IEnumerable<T> ShowAircraftsOfCertainType<T>(IEnumerable<ITransportAircraft> transportAircrafts)
            where T : ITransportAircraft;

        int GetInformationAboutTotal<T>(IEnumerable<T> transportAircrafts, Func<T, int> summationСriteria)
            where T : ITransportAircraft;
    }
}
