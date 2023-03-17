using Application.Features.Departments.Commands.Create;
using Application.Features.Departments.Commands.Delete;
using Application.Features.Departments.Commands.Update;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Departments.Profiles;

public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<Department, CreateDepartmentCommand>().ReverseMap();
        CreateMap<Department, CreatedDepartmentResponse>().ReverseMap();

        CreateMap<Department, UpdateDepartmentCommand>().ReverseMap();
        CreateMap<Department, UpdatedDepartmentResponse>().ReverseMap();
        
        CreateMap<Department, DeleteDepartmentCommand>().ReverseMap();
        CreateMap<Department, DeletedDepartmentsResponse>().ReverseMap();
    }
}