namespace HR.LeaveManagement.Application.Exception;

public class BadRequest : System.Exception
{
    public BadRequest(string message) : base(message)
    {
    }
}