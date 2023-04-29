using Core.Persistence.Repositories;

namespace Domain.Entities;

public class LoginAndExit
{
    public string Userid_Date { get; set; }
    public int EmployeeCode { get; set; }
    public DateTime LoginTime { get; set; }
    public DateTime? ExitTime { get; set; }
    public Employee Employee { get; set; }
}