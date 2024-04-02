using SystemComponents.ConcreteCommands;
using SystemComponents.Interfaces;

namespace SystemComponents.Invoker{
    public class ApiInvoker {
        private Command command1 ;
        private Command command2 ;

        public ApiInvoker(){
            command1 = command2 = new NoCommand();
        }

        public void setFirstCommand(Command command){
            command1 = command ;
        }

        public void setSecondCommand(Command command){
            command2 = command ;
        }

        public async Task performFirstCommand(){
            await command1.execute();
        }
        public async Task performSecondCommand(){
            await command2.execute();
        }

        public override string ToString()
        {
            return $"First Command is {command1.GetType()}\nSecond Command is {command2.GetType()}";
        }
    }
}