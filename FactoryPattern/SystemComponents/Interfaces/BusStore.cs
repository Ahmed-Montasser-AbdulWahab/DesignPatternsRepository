using SystemComponents.Interfaces.Enums;

namespace SystemComponents.Interfaces{
    public abstract class BusStore{
        protected abstract Bus? manufactureBus(BusModel model); //factory Method

        public void buyBus(BusModel model){
            Bus? bus = manufactureBus(model);


            if(bus is null){
                Console.WriteLine("Model is not available.");
                return;
            }
            bus?.manufacture();

            Console.WriteLine(bus?.ToString());

            Console.WriteLine("Bought");
        }
    }
}