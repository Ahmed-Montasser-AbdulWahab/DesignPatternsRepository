using SystemComponents.Interfaces;

namespace SystemComponents.Factories{
    public class MercedesMENABusFactory : BusesFactory
    {
        public string getModel()
        {
            return "Mercedes MENA" ;
        }

        public int getSeatNumber()
        {
            return 46 ;
        }

        public string getColor(){
            return "White";
        }
    }
}