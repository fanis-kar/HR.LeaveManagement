using FluentValidation.Results;

namespace HR.LeaveManagement.Application.Exception;

public class BadRequestException : System.Exception
{
    public BadRequestException(string message) : base(message)
    {
    }

    public BadRequestException(string message, ValidationResult validationResult) : base(message)
    {
        ValidationErrors = new();

        foreach (var error in validationResult.Errors)
            ValidationErrors.Add(error.ErrorMessage);
    }

    public List<string> ValidationErrors { get; set; }
}