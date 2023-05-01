using Furniture.Abstract;
using Furniture.Concrete.Chairs;
using Furniture.Concrete.CoffeeTables;
using Furniture.Concrete.Sofas;

namespace Furniture.Concrete.Factory;

public class ArtDecoFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ArtDecoChair();
    }

    public ISofa CreateSofa()
    {
        return new ArtDecoSofa();
    }

    public ICoffeeTable CreateCoffeeTable()
    {
        return new ArtDecoCoffeeTable();
    }
}