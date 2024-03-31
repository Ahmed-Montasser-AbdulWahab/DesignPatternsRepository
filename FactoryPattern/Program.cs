// See https://aka.ms/new-console-template for more information
using SystemComponents.BusStores;
using SystemComponents.Interfaces;

Console.WriteLine("Hello, World!");

BusStore busStore = new FirstBusStore();

busStore.buyBus(SystemComponents.Interfaces.Enums.BusModel.Man);

busStore = new SecondBusStore();

busStore.buyBus(SystemComponents.Interfaces.Enums.BusModel.Man);

busStore.buyBus(SystemComponents.Interfaces.Enums.BusModel.Mercedes);

Console.WriteLine("End Of Program");
