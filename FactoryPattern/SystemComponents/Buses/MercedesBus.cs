using SystemComponents.Interfaces;

namespace SystemComponents.Buses{
    public class MercedesBus : Bus
    {
        private readonly BusesFactory _busesFactory ;

        public MercedesBus(BusesFactory busesFactory)
        {
            _busesFactory = busesFactory ;
        }

        public override void manufacture()
        {
            _model = _busesFactory.getModel();
            _seats = _busesFactory.getSeatNumber();
            _color = _busesFactory.getColor();
        }
    }
}