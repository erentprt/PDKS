using Core.Application.Dtos;

namespace Application.Features.Departments.Commands.Create;

public class CreatedDepartmentResponse:IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }

}