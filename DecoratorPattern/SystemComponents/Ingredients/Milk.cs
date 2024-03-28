namespace SystemComponents.Ingredients{
    public sealed class Milk : IngredientDecorator
    {
        public Milk(Beverage beverage){
            _beverage = beverage ;
            _description = $"{beverage.getDescription()} with Milk";
        }
        public override sealed double getCost()
        { 
            return (_beverage?.getCost() ?? 0) + 0.5 ; 
        }

        

    }
}