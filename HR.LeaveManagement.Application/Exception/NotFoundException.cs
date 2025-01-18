namespace HR.LeaveManagement.Application.Exception;

public class NotFoundException : System.Exception
{
    public NotFoundException(string name, object key) : base($"{name} ({key}) was not found")
    {      
    }
}