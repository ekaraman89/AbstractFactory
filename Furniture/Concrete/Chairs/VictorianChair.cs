using Furniture.Abstract;

namespace Furniture.Concrete.Chairs;

public class VictorianChair : IChair
{
    public bool HasLegs()
    {
        throw new NotImplementedException();
    }

    public bool SitOn()
    {
        throw new NotImplementedException();
    }

    public string SayName() => "I am a VictorianChair";
}