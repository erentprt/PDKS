using Application.Services.EmployeeService;
using Application.Services.LoginAndExitService;
using Application.Services.Repositories;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Employees.Queries.GetByIdDetails;

public class GetByIdEmployeeDetailsQuery:IRequest<List<LoginAndExit>>
{
    public int Id { get; set; }

    public GetByIdEmployeeDetailsQuery(int id)
    {
        Id = id;
    }
}

public class GetByIdEmployeeDetailsResponseHandler:IRequestHandler<GetByIdEmployeeDetailsQuery,List<LoginAndExit>>
{
    private readonly ILoginAndExitService _loginAndExitService;
    private readonly IMapper _mapper;
    private readonly ILoginAndExitRepository _loginAndExitRepository;
    private readonly IEmployeeService _employeeService;
    public GetByIdEmployeeDetailsResponseHandler(ILoginAndExitService loginAndExitService, IMapper mapper, IEmployeeService employeeService, ILoginAndExitRepository loginAndExitRepository)
    {
        _loginAndExitService = loginAndExitService;
        _mapper = mapper;
        _employeeService = employeeService;
        _loginAndExitRepository = loginAndExitRepository;
    }

    public async Task<List<LoginAndExit>> Handle(GetByIdEmployeeDetailsQuery request, CancellationToken cancellationToken)
    {
        var employee = await _employeeService.GetById(request.Id);
        var loginAndExitList = await _loginAndExitRepository.GetListAsync(x => x.EmployeeCode == employee.EmployeeCode,orderBy:x=>x.OrderByDescending(x=>x.LoginTime));
        List<LoginAndExit> loginAndExits = new List<LoginAndExit>();
        foreach (var loginAndExit in loginAndExitList.Items)
        {
            loginAndExits.Add(loginAndExit);
        }
        return loginAndExits;
    }
}