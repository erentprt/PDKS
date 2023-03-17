using Application.Features.Departments.Commands.Create;
using Application.Tests.Mocks.FakeData;
using Application.Tests.Mocks.Repositories;
using Core.CrossCuttingConcers.Exceptions.Types;
using Core.Test.Application.Constants;
using FluentValidation.Results;
using Xunit;

namespace Application.Tests.Features.Department.Commands.CreateDepartment;

public class CreateDepartmentTests : DepartmentMockRepository
{
    private readonly CreateDepartmentCommandValidator _validator;
    private readonly CreateDepartmentCommand _command;
    private readonly CreateDepartmentCommand.CreateDepartmentCommandHandler _handler;

    public CreateDepartmentTests(DepartmentFakeData fakeData, CreateDepartmentCommandValidator validator, CreateDepartmentCommand command)
        : base(fakeData)
    {
        _command = command;
        _validator = validator;
        _handler = new CreateDepartmentCommand.CreateDepartmentCommandHandler(MockRepository.Object, Mapper, BusinessRules);
    }

    [Fact]
    public void DepartmentNameEmptyShouldReturnError()
    {
        _command.Name = string.Empty;
        ValidationFailure? result = _validator
            .Validate(_command)
            .Errors
            .FirstOrDefault(x => x.PropertyName == "Name" && x.ErrorCode == ValidationErrorCodes.NotEmptyValidator);
        Assert.Equal(ValidationErrorCodes.NotEmptyValidator, result?.ErrorCode);
    }

    [Fact]
    public void DepartmentNameNotMatchMinLenghtRuleShouldReturnError()
    {
        _command.Name = "";
        ValidationFailure? result = _validator
            .Validate(_command)
            .Errors
            .FirstOrDefault(x => x.PropertyName == "Name" && x.ErrorCode == ValidationErrorCodes.MinimumLengthValidator);
        Assert.Equal(ValidationErrorCodes.MinimumLengthValidator, result?.ErrorCode);
    }

    [Fact]
    public async Task CreateShouldSuccessfully()
    {
        _command.Name = "XSS";
        CreatedDepartmentResponse result = await _handler.Handle(_command, CancellationToken.None);
        Assert.Equal(expected: "XSS", result.Name);
    }

    [Fact]
    public async Task DuplicatedDepartmentNameShouldReturnError()
    {
        _command.Name = "HR";
        await Assert.ThrowsAsync<BusinessException>(async () => await _handler.Handle(_command, CancellationToken.None));
    }
}
