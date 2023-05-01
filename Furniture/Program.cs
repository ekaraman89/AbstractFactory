// See https://aka.ms/new-console-template for more information

using Furniture.Abstract;
using Furniture.Concrete.Factory;

Console.WriteLine("Hello, World!");
IFurnitureFactory factory = new ModernFactory();

ISofa sofa = factory.CreateSofa();
IChair chair = factory.CreateChair();
ICoffeeTable coffeeTable = factory.CreateCoffeeTable();

Console.WriteLine($"Sofa => {sofa.SayName()}");
Console.WriteLine($"Chair => {chair.SayName()}");
Console.WriteLine($"CoffeeTable => {coffeeTable.SayName()}");
Console.WriteLine("-------------------------------");

factory = new ArtDecoFactory();

sofa = factory.CreateSofa();
chair = factory.CreateChair();
coffeeTable = factory.CreateCoffeeTable();
Console.WriteLine($"Sofa => {sofa.SayName()}");
Console.WriteLine($"Chair => {chair.SayName()}");
Console.WriteLine($"CoffeeTable => {coffeeTable.SayName()}");
Console.WriteLine("-------------------------------");

factory = new VictorianFactory();

sofa = factory.CreateSofa();
chair = factory.CreateChair();
coffeeTable = factory.CreateCoffeeTable();
Console.WriteLine($"Sofa => {sofa.SayName()}");
Console.WriteLine($"Chair => {chair.SayName()}");
Console.WriteLine($"CoffeeTable => {coffeeTable.SayName()}");
Console.WriteLine("-------------------------------");