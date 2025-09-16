namespace Exceptions.Exception;

public class MyException: System.Exception
{
    public MyException(string message) : base(message)
    {
    }
}