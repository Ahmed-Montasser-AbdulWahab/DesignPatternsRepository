using SystemComponents.Interfaces;

namespace SystemComponents.ConcreteCommands{
    public class NoCommand : Command
    {

        public NoCommand()
        {
        }

        

        public Task execute()
        {
            return Task.CompletedTask;

        }


    }
}