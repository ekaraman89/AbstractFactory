using Furniture.Abstract;

namespace Furniture.Concrete.CoffeeTables;

public class VictorianCoffeeTable : ICoffeeTable
{
    public bool HasStorage()
    {
        throw new NotImplementedException();
    }

    public bool GetShape()
    {
        throw new NotImplementedException();
    }
    public string SayName() => "I am a VictorianCoffeeTable";

}