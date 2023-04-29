using FluentValidation;

namespace Application.Features.Employees.Commands.Create;

public class CreateEmployeeValidator:AbstractValidator<CreateEmployeeCommand>
{
    public CreateEmployeeValidator()
    {
    }
}