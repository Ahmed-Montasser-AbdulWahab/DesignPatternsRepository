using SystemComponents.Interfaces;

namespace SystemComponents.Buses{
    public class ManBus : Bus
    {
        private readonly BusesFactory _busesFactory ;

        public ManBus(BusesFactory busesFactory)
        {
            _busesFactory = busesFactory ;
        }

        public override void manufacture()
        {
            _model = _busesFactory.getModel();
            _seats = _busesFactory.getSeatNumber();
        }
    }
}