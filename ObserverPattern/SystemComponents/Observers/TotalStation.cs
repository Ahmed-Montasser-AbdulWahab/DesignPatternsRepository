using SystemComponents.Subject;

namespace SystemComponents.Observers{
    public class TotalStation{

        
        private readonly OfficialGas officialGas;

        public TotalStation(OfficialGas officialGas){
            this.officialGas = officialGas;
        }

        public void PrintUpdate(double isIncreased){
            var msg = "";
            if (isIncreased > 0) { Console.BackgroundColor = ConsoleColor.Red;
                msg = "increased";
            }
            else if (isIncreased < 0) { Console.BackgroundColor = ConsoleColor.Green;
                msg = "decreased";
            } else {
                msg = "been stable";
                Console.BackgroundColor = ConsoleColor.Black; }

            Console.WriteLine($"Price has {msg}");
        }

        public void Subscribe(){
            officialGas.PriceChanged += PrintUpdate;
        }

        public void UnSubscribe(){
            officialGas.PriceChanged -= PrintUpdate;
        }
    }
}