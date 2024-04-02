using SystemComponents.Interfaces;

namespace SystemComponents.ConcreteCommands{
    public class APICommand : Command
    {
        private API _api ;

        public APICommand(API api)
        {
            _api = api ;
        }

        public void setAPI(API api){
                _api = api;
        }

        public async Task execute()
        {
            var data = await _api.getData();

            if(data is null){
                    Console.WriteLine("Failed");
            } else {
                foreach(var entry in data){
                    Console.WriteLine($"{entry.Key} :::: {entry.Value}");
                }
            }

        }


    }
}