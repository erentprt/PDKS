﻿using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Employees.Queries.GetList;

public class GetListEmployeeQuery:IRequest<GetListResponse<GetListEmployeeListItemDto>>
{
    public PageRequest PageRequest { get; set; }
}

public class GetListEmployeeQueryHandler : IRequestHandler<GetListEmployeeQuery, GetListResponse<GetListEmployeeListItemDto>>
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;


    public GetListEmployeeQueryHandler(IEmployeeRepository employeeRepository, IMapper mapper)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
    }

    public async Task<GetListResponse<GetListEmployeeListItemDto>> Handle(GetListEmployeeQuery request, CancellationToken cancellationToken)
    {
        IPaginate<Employee> employees = await _employeeRepository.GetListAsync(
            index: request.PageRequest.Page,
            size: request.PageRequest.PageSize
        );
        var mappedEmployeeListModel = _mapper.Map<GetListResponse<GetListEmployeeListItemDto>>(employees);
        return mappedEmployeeListModel;
    }
}