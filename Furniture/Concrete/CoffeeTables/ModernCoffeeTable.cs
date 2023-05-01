using Furniture.Abstract;

namespace Furniture.Concrete.CoffeeTables;

public class ModernCoffeeTable : ICoffeeTable
{
    public bool HasStorage()
    {
        throw new NotImplementedException();
    }

    public bool GetShape()
    {
        throw new NotImplementedException();
    }
    public string SayName() => "I am a ModernCoffeeTable";

}