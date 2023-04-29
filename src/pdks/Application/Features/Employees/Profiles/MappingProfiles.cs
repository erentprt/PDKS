using Application.Features.Employees.Commands.Create;
using Application.Features.Employees.Commands.Delete;
using Application.Features.Employees.Commands.Update;
using Application.Features.Employees.Queries.GetById;
using Application.Features.Employees.Queries.GetList;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Employees.Profiles;

public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<Employee, CreateEmployeeCommand>().ReverseMap();
        CreateMap<Employee, CreatedEmployeeRespone>().ReverseMap();

        CreateMap<Employee, GetListEmployeeListItemDto>().ReverseMap();
        CreateMap<IPaginate<Employee>, GetListResponse<GetListEmployeeListItemDto>>().ReverseMap();

        CreateMap<Employee, DeleteEmployeeCommand>().ReverseMap();
        CreateMap<Employee, DeletedEmployeeResponse>().ReverseMap();
        
        CreateMap<Employee, GetByIdEmployeeQuery>().ReverseMap();
        CreateMap<Employee, GetByIdEmployeeResponse>().ReverseMap();
        
        CreateMap<Employee, UpdateEmployeeCommand>().ReverseMap();
        CreateMap<Employee, UpdatedEmployeeResponse>().ReverseMap();
    }
}