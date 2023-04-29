using Application.Features.Employees.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Employees.Commands.Delete;

public class DeleteEmployeeCommand:IRequest<DeletedEmployeeResponse>
{
    public int Id { get; set; }
    
    public DeleteEmployeeCommand(int id)
    {
        Id = id;
    }
    
    public DeleteEmployeeCommand()
    {
    }
}

public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, DeletedEmployeeResponse>
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;
    private readonly EmployeeBusinessRules _employeeBusinessRules;
    
    public DeleteEmployeeCommandHandler(IEmployeeRepository employeeRepository, EmployeeBusinessRules employeeBusinessRules, IMapper mapper)
    {
        _employeeRepository = employeeRepository;
        _employeeBusinessRules = employeeBusinessRules;
        _mapper = mapper;
    }

    public async Task<DeletedEmployeeResponse> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
    {
        await _employeeBusinessRules.EmployeeIdShouldExistWhenSelected(request.Id);
        Employee mappedEmployee = _mapper.Map<Employee>(request);
        Employee deletedEmployee = await _employeeRepository.DeleteAsync(mappedEmployee);
        DeletedEmployeeResponse deletedEmployeeDto = _mapper.Map<DeletedEmployeeResponse>(deletedEmployee);
        return deletedEmployeeDto;
    }
}