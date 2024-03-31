using SystemComponents.Interfaces;

namespace SystemComponents.Factories{
    public class ManBusFactory : BusesFactory
    {
        public string getColor()
        {
            return "Black";
        }

        public string getModel()
        {
            return "Man" ;
        }

        public int getSeatNumber()
        {
            return 48 ;
        }
    }
}