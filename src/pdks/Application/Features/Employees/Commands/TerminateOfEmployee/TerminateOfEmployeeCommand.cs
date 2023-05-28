using Application.Services.Repositories;
using MediatR;

namespace Application.Features.Employees.Commands.TerminateOfEmployee;

public class TerminateOfEmployeeCommand : IRequest<TerminateOfEmployeeResponse>
{
    public int Id { get; set; }
    public DateTime DateOfTermination { get; set; }
    public string TerminationReason { get; set; }
    public string TerminationDescription { get; set; }
}

public class TerminateOfEmployeeCommandHandler : IRequestHandler<TerminateOfEmployeeCommand, TerminateOfEmployeeResponse>
{
    private readonly IEmployeeRepository _employeeRepository;

    public TerminateOfEmployeeCommandHandler(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<TerminateOfEmployeeResponse> Handle(TerminateOfEmployeeCommand request,
        CancellationToken cancellationToken)
    {
        var employee = await _employeeRepository.GetAsync(x => x.Id == request.Id);

        employee!.DateOfTermination = request.DateOfTermination;
        employee.TerminationReason = request.TerminationReason;
        employee.TerminationDescription = request.TerminationDescription;
        employee.Status = !employee.Status;
        
        await _employeeRepository.UpdateAsync(employee);
        return new TerminateOfEmployeeResponse();
    }
}