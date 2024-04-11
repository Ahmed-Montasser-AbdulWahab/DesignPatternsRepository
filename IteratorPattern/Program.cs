// See https://aka.ms/new-console-template for more information
using IteratorPattern.SystemComponents.Menus;
using IteratorPattern.SystemComponents.SuperMenu;

Console.WriteLine("Hello, World!");

CairoGuide cairoGuide = new CairoGuide(new CTABusesMenu(), new CompanyBusesMenu());

cairoGuide.printLines();