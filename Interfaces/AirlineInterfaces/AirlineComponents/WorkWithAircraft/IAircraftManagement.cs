using Interfaces.TransportAircraftInterfaces;
using System;
using System.Collections.Generic;

namespace Interfaces.AirlineInterfaces.AirlineComponents.WorkWithAircraft
{
    public interface IAircraftManagement
    {
        void BuyAircraft<T>(ICollection<ITransportAircraft> transportAircraft, int quantity)
            where T : ITransportAircraft, new();

        void SellAircraft(ICollection<ITransportAircraft> transportAircraftCollection, ITransportAircraft transportAircraft);

        IEnumerable<ITransportAircraft> ShowAllAircraft(IEnumerable<ITransportAircraft> transportAircraft);

        IEnumerable<T> ShowAircraftOfCertainType<T>(IEnumerable<ITransportAircraft> transportAircraft)
            where T : ITransportAircraft;

        int GetInformationAboutTotal<T>(IEnumerable<T> transportAircraft, Func<T, int> summationCriteria)
            where T : ITransportAircraft;
    }
}
