using FluentValidation;

namespace Application.Features.Departments.Commands.Create;

public class CreateDepartmentCommandValidator:AbstractValidator<CreateDepartmentCommand>
{
    public CreateDepartmentCommandValidator()
    {
        RuleFor(d=>d.Name).NotEmpty();
        RuleFor(d => d.Name).MinimumLength(2);
        RuleFor(d => d.Name).MaximumLength(50);

        RuleFor(d => d.Description).MaximumLength(500);
        
    }
}