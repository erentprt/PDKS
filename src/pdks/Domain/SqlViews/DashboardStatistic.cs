using Core.Persistence.Repositories;

namespace Domain.SqlViews;

public class DashboardStatistic:SqlView 
{
    public int TotalEmployees { get; set; }
    public int NumberOfEmployeesNotAtWork { get; set; }
    public int NumberOfEmployeesInTheWorkplace { get; set; }
    public double AllTimeSalary { get; set; }
}