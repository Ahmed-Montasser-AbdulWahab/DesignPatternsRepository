using SystemComponents.Interfaces;

namespace SystemComponents.Factories{
    public class MercedesBusFactory : BusesFactory
    {
        public string getModel()
        {
            return "Mercedes" ;
        }

        public int getSeatNumber()
        {
            return 46 ;
        }

        public string getColor(){
            return "Red";
        }
    }
}