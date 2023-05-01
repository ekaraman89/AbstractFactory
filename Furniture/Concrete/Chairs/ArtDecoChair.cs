using Furniture.Abstract;

namespace Furniture.Concrete.Chairs;

public class ArtDecoChair : IChair
{
    public bool HasLegs()
    {
        throw new NotImplementedException();
    }

    public bool SitOn()
    {
        throw new NotImplementedException();
    }

    public string SayName() => "I am a ArtDecoChair";
}