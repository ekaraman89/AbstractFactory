using Furniture.Abstract;

namespace Furniture.Concrete.Sofas;

public class ModernSofa : ISofa
{
    public bool HasCushions()
    {
        throw new NotImplementedException();
    }

    public bool Recline()
    {
        throw new NotImplementedException();
    }
    public string SayName() => "I am a ModernSofa";

}