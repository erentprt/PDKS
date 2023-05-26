using Core.Application.Dtos;

namespace Application.Features.Employees.Queries.GetByIdDetails;

public class GetByIdEmployeeDetailsListItemDto:IDto
{
    public int Id { get; set; }
    public string Userid_Date { get; set; }
    public string EmployeeCode { get; set; }
    public DateTime LoginTime { get; set; }
    public DateTime? ExitTime { get; set; }
}