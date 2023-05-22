using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Employees.Queries.GetListNotAtWork;

public class GetListNotAtWorkQuery:IRequest<GetListResponse<GetListNotAtWorkListItemDto>>
{
    public PageRequest PageRequest { get; set; }
}

public class GetListEmployeeQueryHandler : IRequestHandler<GetListNotAtWorkQuery, GetListResponse<GetListNotAtWorkListItemDto>>
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;


    public GetListEmployeeQueryHandler(IEmployeeRepository employeeRepository, IMapper mapper)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
    }

    public async Task<GetListResponse<GetListNotAtWorkListItemDto>> Handle(GetListNotAtWorkQuery request, CancellationToken cancellationToken)
    {
        IPaginate<Employee> employees = await _employeeRepository.GetListAsync(
            index: request.PageRequest.Page,
            size: request.PageRequest.PageSize,
            predicate: x => x.AtWork == false
        );
        var mappedEmployeeListModel = _mapper.Map<GetListResponse<GetListNotAtWorkListItemDto>>(employees);
        return mappedEmployeeListModel;
    }
}