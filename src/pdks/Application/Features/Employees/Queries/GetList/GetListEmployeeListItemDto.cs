using Core.Application.Dtos;

namespace Application.Features.Employees.Queries.GetList;

public class GetListEmployeeListItemDto:IDto
{
    public int Id { get; set; }
    public int DepartmentId { get; set; }
    public string EmployeeCode { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string IdentityNumbeer { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string? HomeAddress { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Position { get; set; }
    public bool? Status { get; set; }
    public DateTime DateOfEmployment { get; set; }
    public DateTime? DateOfTermination { get; set; }
    public string? TerminationReason { get; set; }
    public string? TerminationDescription { get; set; }
    public bool AtWork { get; set; }
    public double? HourlySalary { get; set; }
    public double? MonthlySalary { get; set; }
    public double? AllTimeSalary { get; set; }
}