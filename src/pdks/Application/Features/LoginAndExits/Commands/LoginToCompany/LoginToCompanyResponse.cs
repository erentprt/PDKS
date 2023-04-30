using Domain.Entities;

namespace Application.Features.LoginAndExits.Commands.LoginToCompany;

public class LoginToCompanyResponse
{
    public string Userid_Date { get; set; }
    public string EmployeeCode { get; set; }
    public DateTime LoginTime { get; set; }
    public DateTime? ExitTime { get; set; }
}