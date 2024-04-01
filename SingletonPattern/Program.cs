// See https://aka.ms/new-console-template for more information


using SystemComponents;
using SystemComponents.Providers;
using SystemComponents.Singleton;

MaleProvider m = new MaleProvider();

StoreSingleton s1 = m.getStoreSingleton();

Console.WriteLine("---------------------------------------------------");

s1.PrintNames(); //Ahmed, Mohamed, Hamed
Console.WriteLine("---------------------------------------------------");
FemaleProvider f = new FemaleProvider();

//StoreSingleton from MaleProvider

 s1 = m.getStoreSingleton();



s1.PrintNames(); //Ahmed, Mohamed, Hamed, Samah, Manal, Hend

//StoreSingleton from FemaleProvider which should be same of MaleProvider

Console.WriteLine("---------------------------------------------------");
s1 = f.getStoreSingleton();

s1.PrintNames(); //Ahmed, Mohamed, Hamed, Samah, Manal, Hend
Console.WriteLine("---------------------------------------------------");
