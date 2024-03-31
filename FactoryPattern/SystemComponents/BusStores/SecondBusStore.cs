
using SystemComponents.Buses;
using SystemComponents.Factories;
using SystemComponents.Interfaces;
using SystemComponents.Interfaces.Enums;

namespace SystemComponents.BusStores{
    public class SecondBusStore : BusStore
    {
        protected override Bus? manufactureBus(BusModel model)
        {
            return model switch {
                BusModel.Mercedes => new MercedesBus(new MercedesMENABusFactory()),
                BusModel.Man => new ManBus(new ManBusFactory()),
                _ => null
            };
        }
    }
}