using Core.Persistence.Repositories;

namespace Domain.Enums;

public class Employee : Entity
{
    public int DepartmentId { get; set; }
    
    public string EmployeeCode { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string IdentityNumbeer { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string? HomeAddress { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Position { get; set; }
    public bool? Status { get; set; }
    public DateTime DateOfEmployment { get; set; }
    public DateTime? DateOfTermination { get; set; }
    public string? TerminationReason { get; set; }
    public string? TerminationDescription { get; set; }
    public bool AtWork { get; set; }
    public double? HourlySalary { get; set; }
    public double? MonthlySalary { get; set; }
    public Department Department { get; set; }

    public Employee()
    {
    }

    public Employee(int id, int departmentId, string employeeCode, string name, string surname, string ıdentityNumbeer, string phoneNumber, string email, string? homeAddress, DateTime dateOfBirth, string position, bool? status, DateTime dateOfEmployment, DateTime? dateOfTermination, string? terminationReason, string? terminationDescription, bool atWork, double? hourlySalary, double? monthlySalary) : base(id)
    {
        DepartmentId = departmentId;
        EmployeeCode = employeeCode;
        Name = name;
        Surname = surname;
        IdentityNumbeer = ıdentityNumbeer;
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
        
    }
} 