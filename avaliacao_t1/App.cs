namespace Semana3.dotnetP003;
public class App
{

}

public class ProductNotFoundException : Exception
{
    public ProductNotFoundException(string message) : base(message)
    {
    }
}