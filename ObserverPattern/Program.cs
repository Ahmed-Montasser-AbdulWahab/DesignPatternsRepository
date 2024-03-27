using SystemComponents.Observers;
using SystemComponents.Subject;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

OfficialGas officialGas = new OfficialGas();

TotalStation totalStation = new TotalStation(officialGas);

totalStation.Subscribe();

officialGas.setPrice(2.00);
officialGas.setPrice(1.00);

totalStation.UnSubscribe();
officialGas.setPrice(1.00);
officialGas.setPrice(2.00);

