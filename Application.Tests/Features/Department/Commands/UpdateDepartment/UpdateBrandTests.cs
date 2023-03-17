using Application.Features.Departments.Commands.Update;
using Application.Tests.Mocks.FakeData;
using Application.Tests.Mocks.Repositories;
using Core.CrossCuttingConcers.Exceptions.Types;
using Core.Test.Application.Constants;
using FluentValidation.Results;
using Xunit;

namespace Application.Tests.Features.Department.Commands.UpdateDepartment;

public class UpdateBrandTests : DepartmentMockRepository
{
    private readonly UpdateDepartmentCommandValidator _validator;
    private readonly UpdateDepartmentCommand _command;
    private readonly UpdateDepartmentCommand.UpdateDepartmentCommandHandler _handler;

    public UpdateBrandTests(DepartmentFakeData fakeData, UpdateDepartmentCommandValidator validator, UpdateDepartmentCommand command)
        : base(fakeData)
    {
        _validator = validator;
        _command = command;
        _handler = new UpdateDepartmentCommand.UpdateDepartmentCommandHandler(MockRepository.Object, Mapper, BusinessRules);
    }

    [Fact]
    public void BrandNameEmptyShouldReturnError()
    {
        _command.Name = string.Empty;
        ValidationFailure? result = _validator
            .Validate(_command)
            .Errors
            .FirstOrDefault(x => x.PropertyName == "Name" && x.ErrorCode == ValidationErrorCodes.NotEmptyValidator);
        Assert.Equal(ValidationErrorCodes.NotEmptyValidator, result?.ErrorCode);
    }

    [Fact]
    public void BrandNameNotMatchMinLenghtRuleShouldReturnError()
    {
        _command.Name = "S";
        ValidationFailure? result = _validator
            .Validate(_command)
            .Errors
            .FirstOrDefault(x => x.PropertyName == "Name" && x.ErrorCode == ValidationErrorCodes.MinimumLengthValidator);
        Assert.Equal(ValidationErrorCodes.MinimumLengthValidator, result?.ErrorCode);
    }

    [Fact]
    public async Task UpdateShouldSuccessfully()
    {
        _command.Id = 1;
        _command.Name = "TEST UPDATE IT";
        UpdatedDepartmentResponse result = await _handler.Handle(_command, CancellationToken.None);
        Assert.Equal(expected: "TEST UPDATE IT", result.Name);
    }

    [Fact]
    public async Task BrandIdNotExistsShouldReturnError()
    {
        _command.Id = 6;
        _command.Name = "IT";
        await Assert.ThrowsAsync<BusinessException>(async () => await _handler.Handle(_command, CancellationToken.None));
    }
}
