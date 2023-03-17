using Core.Application.Dtos;

namespace Application.Features.Departments.Commands.Delete;

public class DeletedDepartmentsResponse:IDto
{
    public int Id { get; set; }
}