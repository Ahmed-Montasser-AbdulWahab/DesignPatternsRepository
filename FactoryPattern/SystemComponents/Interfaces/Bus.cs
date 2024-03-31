namespace SystemComponents.Interfaces{
    public abstract class Bus{
        protected string _model = "";

        protected int _seats = 0 ;

        protected string _color = "Red";

        public string Model {set{_model = value;} get {return _model;}}
        public int Seats {set{_seats = value;} get{return _seats;}}

        public string Color {set{_color = value;} get{return _color;}}

        public abstract void manufacture();

        public override string ToString()
        {
            return $"{_model} bus with {_seats} Seats in {_color} Color.";
        }
    }
}