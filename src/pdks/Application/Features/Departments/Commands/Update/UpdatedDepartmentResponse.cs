using Core.Application.Dtos;

namespace Application.Features.Departments.Commands.Update;

public class UpdatedDepartmentResponse:IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }

}