namespace SystemComponents.Beverages{
    public sealed class DarkRoast : Beverage {

        public DarkRoast(){
            _description = "DarkRoast";
        }

        public sealed override double getCost()
        {
            return 5.0 ;
        }

    }
}