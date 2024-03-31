
using SystemComponents.Buses;
using SystemComponents.Factories;
using SystemComponents.Interfaces;
using SystemComponents.Interfaces.Enums;

namespace SystemComponents.BusStores{
    public class FirstBusStore : BusStore
    {
        protected override Bus? manufactureBus(BusModel model)
        {
            return model switch {
                BusModel.Mercedes => new MercedesBus(new MercedesBusFactory()),
                BusModel.Man => new ManBus(new ManBusFactory()),
                _ => null
            };
        }
    }
}