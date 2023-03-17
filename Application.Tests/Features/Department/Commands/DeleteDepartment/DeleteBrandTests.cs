using Application.Features.Departments.Commands.Delete;
using Application.Tests.Mocks.FakeData;
using Application.Tests.Mocks.Repositories;

using Core.CrossCuttingConcers.Exceptions.Types;
using Xunit;

namespace Application.Tests.Features.Department.Commands.DeleteDepartment;

public class DeleteDepartmentTests : DepartmentMockRepository
{
    private readonly DeleteDepartmentCommand.DeleteDepartmentCommandHandler _handler;
    private readonly DeleteDepartmentCommand _command;

    public DeleteDepartmentTests(DepartmentFakeData fakeData, DeleteDepartmentCommand command)
        : base(fakeData)
    {
        _command = command;
        _handler = new DeleteDepartmentCommand.DeleteDepartmentCommandHandler(MockRepository.Object, Mapper, BusinessRules);
    }

    [Fact]
    public async Task DeleteShouldSuccessfully()
    {
        _command.Id = 1;
        DeletedDepartmentsResponse result = await _handler.Handle(_command, CancellationToken.None);
        Assert.NotNull(result);
    }

    [Fact]
    public async Task DepartmentIdNotExistsShouldReturnError()
    {
        _command.Id = 6;
        await Assert.ThrowsAsync<BusinessException>(async () => await _handler.Handle(_command, CancellationToken.None));
    }
}
