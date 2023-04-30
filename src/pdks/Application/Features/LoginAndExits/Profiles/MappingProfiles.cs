using Application.Features.LoginAndExits.Commands.LoginToCompany;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.LoginAndExits.Profiles;

public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<LoginAndExit, LoginToCompanyResponse>().ReverseMap();
        CreateMap<LoginAndExit, LoginToCompanyCommand>().ReverseMap();
    }
}