namespace Application.Features.Dashboards.Queries.GetDashboard;

public class GetDashboardQueryResponse
{
    public int TotalEmployees { get; set; }
    public int NumberOfEmployeesNotAtWork { get; set; }
    public int NumberOfEmployeesInTheWorkplace { get; set; }
    public int AllTimeSalary { get; set; }

}