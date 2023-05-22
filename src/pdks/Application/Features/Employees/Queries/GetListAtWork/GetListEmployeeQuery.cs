using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Employees.Queries.GetListAtWork;

public class GetListAtWorkQuery:IRequest<GetListResponse<GetListAtWorkListItemDto>>
{
    public PageRequest PageRequest { get; set; }
}

public class GetListAtWorkQueryHandler : IRequestHandler<GetListAtWorkQuery, GetListResponse<GetListAtWorkListItemDto>>
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;


    public GetListAtWorkQueryHandler(IEmployeeRepository employeeRepository, IMapper mapper)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
    }

    public async Task<GetListResponse<GetListAtWorkListItemDto>> Handle(GetListAtWorkQuery request, CancellationToken cancellationToken)
    {
        IPaginate<Employee> employees = await _employeeRepository.GetListAsync(
            index: request.PageRequest.Page,
            size: request.PageRequest.PageSize,
            predicate: x => x.AtWork == true
        );
        var mappedEmployeeListModel = _mapper.Map<GetListResponse<GetListAtWorkListItemDto>>(employees);
        return mappedEmployeeListModel;
    }
}