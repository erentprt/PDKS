using Core.Application.Dtos;

namespace Application.Features.Employees.Commands.Delete;

public class DeletedEmployeeResponse:IDto
{
    public int Id { get; set; }
}