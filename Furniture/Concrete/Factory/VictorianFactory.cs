using Furniture.Abstract;
using Furniture.Concrete.Chairs;
using Furniture.Concrete.CoffeeTables;
using Furniture.Concrete.Sofas;

namespace Furniture.Concrete.Factory;

public class VictorianFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new VictorianChair();
    }

    public ISofa CreateSofa()
    {
        return new VictorianSofa();
    }

    public ICoffeeTable CreateCoffeeTable()
    {
        return new VictorianCoffeeTable();
    }
}