using Application.Features.Employees.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Employees.Commands.Create;

public class CreateEmployeeCommand:IRequest<CreatedEmployeeRespone>
{
    public int? DepartmentId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string EmployeeCode { get; set; }
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
}

public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, CreatedEmployeeRespone>
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;
    private readonly EmployeeBusinessRules _employeeBusinessRules;


    public CreateEmployeeCommandHandler(IEmployeeRepository employeeRepository, IMapper mapper, EmployeeBusinessRules employeeBusinessRules)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
        _employeeBusinessRules = employeeBusinessRules;
    }

    public async Task<CreatedEmployeeRespone> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
    {
        await _employeeBusinessRules.EmployeeCodeIdentityNumberPhoneNumberMustBeUnique(request);
        
        Employee mappedEmployee = _mapper.Map<Employee>(request);
        Employee createdEmployee = await _employeeRepository.AddAsync(mappedEmployee);
        CreatedEmployeeRespone createdEmployeeDto = _mapper.Map<CreatedEmployeeRespone>(createdEmployee);
        return createdEmployeeDto;
    }
}