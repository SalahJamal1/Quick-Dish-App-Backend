namespace FoodApplication.Exceptions;

public class AppErrorResponse : ApplicationException
{

    public AppErrorResponse(string message) : base(message)
    {

    }
}