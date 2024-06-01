// See https://aka.ms/new-console-template for more information
using chapter1;

Console.WriteLine("Hello, World!");

TestDuck mallard = new TestMallard();
mallard.performFly();
mallard.performQuack();

TestDuck model = new TestModelDuck();
model.performFly();
model.setFlyBehavior(new FlyRocketPowered());
model.performFly();