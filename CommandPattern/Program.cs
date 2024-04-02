// See https://aka.ms/new-console-template for more information
using SystemComponents.ConcreteCommands;
using SystemComponents.Interfaces;
using SystemComponents.Invoker;
using SystemComponents.Receivers;

Console.WriteLine("Hello, World!");


ApiInvoker apiInvoker = new ApiInvoker();

Console.WriteLine(apiInvoker);

apiInvoker.performFirstCommand().Wait();

API azanApi = new AzanAPI();

Command azanCommand = new APICommand(azanApi);

apiInvoker.setFirstCommand(azanCommand);

apiInvoker.performFirstCommand().Wait();

Console.WriteLine(apiInvoker);

