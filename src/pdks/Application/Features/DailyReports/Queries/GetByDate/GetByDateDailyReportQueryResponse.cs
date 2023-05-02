namespace Application.Features.DailyReports.Queries.GetByDate;

public class GetByDateDailyReportQueryResponse
{
    public int Id { get; set; }
    public int NumberOfEmployeesInTheWorkplace { get; set; }
    public int NumberOfEmployeesNotAtWork{ get; set; }
    public int TotalNumberOfEmployees { get; set; }
    public int MoneyPaidToday { get; set; }
    public DateTime Date { get; set; }
}