using Application.Features.Employees.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Employees.Commands.Update;

public class UpdateEmployeeCommand : IRequest<UpdatedEmployeeResponse>
{
    public int Id { get; set; }
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

public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, UpdatedEmployeeResponse>
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;
    private readonly EmployeeBusinessRules _employeeBusinessRules;

    public UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository, IMapper mapper, EmployeeBusinessRules employeeBusinessRules)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
        _employeeBusinessRules = employeeBusinessRules;
    }

    public async Task<UpdatedEmployeeResponse> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
    {
        Employee? employee = await _employeeRepository.GetAsync(x=>x.Id==request.Id);
        _employeeBusinessRules.EmployeeIdShouldExistWhenSelected(employee);
        
        _mapper.Map(request, employee);
        //await _employeeBusinessRules.EmployeeIdentityEmployeeCodeOrPhoneNumberCanNotBeDuplicatedWhenUpdated(employee!); 
        
        Employee updatedEmployee = await _employeeRepository.UpdateAsync(employee!);
        UpdatedEmployeeResponse updatedEmployeeDto = _mapper.Map<UpdatedEmployeeResponse>(updatedEmployee);
        return updatedEmployeeDto;

    }
}