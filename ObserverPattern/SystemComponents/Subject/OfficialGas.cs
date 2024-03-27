namespace SystemComponents.Subject{
    public class OfficialGas{
        public delegate void Notify(double isIncreased);

        public event Notify? PriceChanged ;

        private double _priceOf92Gasoline = 1.00 ;
        private double _lastPriceOf92Gasoline = 1.00 ;

     

        public void setPrice(double newPrice){
     
            PriceChanged?.Invoke(newPrice - _priceOf92Gasoline);
            _lastPriceOf92Gasoline = _priceOf92Gasoline;
            _priceOf92Gasoline = newPrice;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public double getDifferenceNewToOld(){
            return _priceOf92Gasoline - _lastPriceOf92Gasoline;
        }

        public double getCurrentPrice() => _priceOf92Gasoline ;

    }
}