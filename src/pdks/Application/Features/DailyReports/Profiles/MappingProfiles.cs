using Application.Features.DailyReports.Commands.Create;
using Application.Features.DailyReports.Queries.GetByDate;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.DailyReports.Profiles;

public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<DailyReport, CreatedDailyReportResponse>().ReverseMap();
        CreateMap<DailyReport, CreateDailyReportCommand>().ReverseMap();
        
        CreateMap<CreatedDailyReportResponse, GetByDateDailyReportQuery>().ReverseMap();
        CreateMap<DailyReport , GetByDateDailyReportQueryResponse>().ReverseMap();
    }
}