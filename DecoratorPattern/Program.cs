// See https://aka.ms/new-console-template for more information
using SystemComponents;
using SystemComponents.Beverages;
using SystemComponents.Ingredients;

Console.WriteLine("Hello, World!");

Console.WriteLine("Creating DarkRoast with Milk and Chocolate");

Beverage beverage = new DarkRoast();

beverage = new Chocolate(beverage);


beverage = new Milk(beverage);

Console.WriteLine(beverage.getCost());
Console.WriteLine(beverage.getDescription());
