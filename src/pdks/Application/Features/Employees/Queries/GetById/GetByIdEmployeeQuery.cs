using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Employees.Queries.GetById;

public class GetByIdEmployeeQuery:IRequest<GetByIdEmployeeResponse>
{
    public int Id { get; set; }
    
    public GetByIdEmployeeQuery()
    {
    }
    public GetByIdEmployeeQuery(int id)
    {
        Id = id;
    }
}

public class GetByIdEmployeeResponseHandler:IRequestHandler<GetByIdEmployeeQuery,GetByIdEmployeeResponse>
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;

    public GetByIdEmployeeResponseHandler(IEmployeeRepository employeeRepository, IMapper mapper)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdEmployeeResponse> Handle(GetByIdEmployeeQuery request, CancellationToken cancellationToken)
    {
        Employee? employee = await _employeeRepository.GetAsync(x => x.Id == request.Id);
        GetByIdEmployeeResponse response = _mapper.Map<GetByIdEmployeeResponse>(employee);
        return response;
    }
}