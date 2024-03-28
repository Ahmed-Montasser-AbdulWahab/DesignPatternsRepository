namespace SystemComponents.Ingredients{
    public sealed class Chocolate : IngredientDecorator
    {
        public Chocolate(Beverage beverage){
            _beverage = beverage ;
            _description = $"{beverage.getDescription()} with Chocolate";
        }
        public override sealed double getCost()
        {
            return (_beverage?.getCost() ?? 0) + 1.5 ; 
        }

  
    }
}