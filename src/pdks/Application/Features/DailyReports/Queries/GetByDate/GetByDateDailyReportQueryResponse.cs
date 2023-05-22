using Domain.Entities;

namespace Application.Features.DailyReports.Queries.GetByDate;

public class GetByDateDailyReportQueryResponse
{
    public List<Employee> LoggedInEmployees { get; set; }
    public List<Employee> NotLoggedInEmployees { get; set; }
}