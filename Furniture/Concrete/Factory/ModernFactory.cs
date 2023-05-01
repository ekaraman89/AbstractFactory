using Furniture.Abstract;
using Furniture.Concrete.Chairs;
using Furniture.Concrete.CoffeeTables;
using Furniture.Concrete.Sofas;

namespace Furniture.Concrete.Factory;

public class ModernFactory : IFurnitureFactory

{
    public IChair CreateChair()
    {
        return new ModernChair();
    }

    public ISofa CreateSofa()
    {
        return new ModernSofa();
    }

    public ICoffeeTable CreateCoffeeTable()
    {
        return new ModernCoffeeTable();
    }
}