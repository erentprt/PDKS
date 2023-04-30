using Core.Persistence.Repositories;

namespace Domain.Entities;

public class LoginAndExit:Entity
{
    public string Userid_Date { get; set; }
    public string EmployeeCode { get; set; }
    public DateTime LoginTime { get; set; }
    public DateTime? ExitTime { get; set; }
    public Employee Employee { get; set; }
}