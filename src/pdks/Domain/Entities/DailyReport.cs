using Core.Persistence.Repositories;

namespace Domain.Entities;

public class DailyReport:Entity
{
     public int NumberOfEmployeesInTheWorkplace { get; set; }
     public int NumberOfEmployeesNotAtWork{ get; set; }
     public int TotalNumberOfEmployees { get; set; }
     public int MoneyPaidToday { get; set; }
     
     public DateTime Date { get; set; }

     public DailyReport()
     {
     }

     public DailyReport(int id,int numberOfEmployeesInTheWorkplace, int numberOfEmployeesNotAtWork, int totalNumberOfEmployees, int moneyPaidToday, DateTime date) : base(id)
     {
          NumberOfEmployeesInTheWorkplace = numberOfEmployeesInTheWorkplace;
          NumberOfEmployeesNotAtWork = numberOfEmployeesNotAtWork;
          TotalNumberOfEmployees = totalNumberOfEmployees;
          MoneyPaidToday = moneyPaidToday;
          Date = date;
     }
}