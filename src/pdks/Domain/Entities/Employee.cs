using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Employee : Entity
{
    public int? DepartmentId { get; set; }
    public string EmployeeCode { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string IdentityNumber { get; set; }
    public string PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? HomeAddress { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Position { get; set; }
    public bool? Status { get; set; }
    public DateTime DateOfEmployment { get; set; }
    public DateTime? DateOfTermination { get; set; }
    public string? TerminationReason { get; set; }
    public string? TerminationDescription { get; set; }
    public bool AtWork { get; set; }
    public double? HourlySalary { get; set; }
    public double? MonthlySalary { get; set; }
    public double? AllTimeSalary { get; set; }
    public int  TotalWorkTime { get; set; }
    public Department Department { get; set; }
    public ICollection<LoginAndExit> LoginAndExits { get; set; }

    public Employee()
    {
        LoginAndExits = new HashSet<LoginAndExit>();
    }

    public Employee(int id, int departmentId, string employeeCode, string name, string surname, string ıdentityNumbeer, string phoneNumber, string email, string? homeAddress, DateTime dateOfBirth, string position, bool? status, DateTime dateOfEmployment, DateTime? dateOfTermination, string? terminationReason, string? terminationDescription, bool atWork, double? hourlySalary, double? monthlySalary,double allTimeSalary,int totalWorkTime) : base(id)
    {
        DepartmentId = departmentId;
        EmployeeCode = employeeCode;
        Name = name;
        Surname = surname;
        IdentityNumber = ıdentityNumbeer;
        PhoneNumber = phoneNumber;
        Email = email;
        HomeAddress = homeAddress;
        DateOfBirth = dateOfBirth;
        Position = position;
        Status = status;
        DateOfEmployment = dateOfEmployment;
        DateOfTermination = dateOfTermination;
        TerminationReason = terminationReason;
        TerminationDescription = terminationDescription;
        AtWork = atWork;
        HourlySalary = hourlySalary;
        MonthlySalary = monthlySalary;
        AllTimeSalary = allTimeSalary;
        TotalWorkTime = totalWorkTime;
    }
} 