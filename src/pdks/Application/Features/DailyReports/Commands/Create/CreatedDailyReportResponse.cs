using Core.Application.Dtos;

namespace Application.Features.DailyReports.Commands.Create;

public class CreatedDailyReportResponse:IDto
{
    public int Id { get; set; }
    public int NumberOfEmployeesInTheWorkplace { get; set; }
    public int NumberOfEmployeesNotAtWork{ get; set; }
    public int TotalNumberOfEmployees { get; set; }
    public int MoneyPaidToday { get; set; }
    public DateTime Date { get; set; }
}