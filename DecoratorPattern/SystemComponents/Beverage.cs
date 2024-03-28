namespace SystemComponents{
    public abstract class Beverage{
        protected string _description = "Unknown Beverage" ;

        public string getDescription(){
            return _description ;
        }

        public abstract double getCost() ;
    }
}