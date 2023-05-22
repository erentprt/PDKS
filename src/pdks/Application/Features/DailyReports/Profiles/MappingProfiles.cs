using Application.Features.DailyReports.Commands.Create;
using Application.Features.DailyReports.Queries.GetByDate;
using Application.Features.DailyReports.Queries.GetList;
using AutoMapper;
using Core.Persistence.Paging;
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
        
        CreateMap<DailyReport, GetListDailyReportListItemDto>().ReverseMap();
        CreateMap<IPaginate<DailyReport>, GetListResponse<GetListDailyReportListItemDto>>().ReverseMap();

    }
}