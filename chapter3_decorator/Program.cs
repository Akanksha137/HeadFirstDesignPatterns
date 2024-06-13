// See https://aka.ms/new-console-template for more information
using chapter3_decorator;

Console.WriteLine("Hello, World!");

Beverage beverage = new Espresso();

Console.WriteLine(beverage.getDescription() + " $ " + beverage.cost());

Beverage beverage1 = new HouseBlend();

beverage1 = new Mocha(beverage1);
beverage1 = new Mocha(beverage1);
beverage1 = new Mocha(beverage1);

Console.WriteLine(beverage1.getDescription() + " $ " + beverage1.cost());