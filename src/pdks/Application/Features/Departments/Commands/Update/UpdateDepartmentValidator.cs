using Application.Features.Departments.Commands.Create;
using FluentValidation;

namespace Application.Features.Departments.Commands.Update;

public class UpdateDepartmentCommandValidator:AbstractValidator<UpdateDepartmentCommand>
{
    public UpdateDepartmentCommandValidator()
    {
        RuleFor(d=>d.Name).NotEmpty();
        RuleFor(d => d.Name).MinimumLength(2);
        RuleFor(d => d.Name).MaximumLength(50);

        RuleFor(d => d.Description).MaximumLength(500);
        
    }
}