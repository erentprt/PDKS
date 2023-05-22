using Core.Application.Dtos;

namespace Application.Features.DailyReports.Queries.GetList;

public class GetListDailyReportListItemDto:IDto
{
    public int Id { get; set; }
    public int NumberOfEmployeesInTheWorkplace { get; set; }
    public int NumberOfEmployeesNotAtWork{ get; set; }
    public int TotalNumberOfEmployees { get; set; }
    public int MoneyPaidToday { get; set; }
     
    public DateTime Date { get; set; }

}