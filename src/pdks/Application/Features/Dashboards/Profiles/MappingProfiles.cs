using Application.Features.Dashboards.Queries.GetDashboard;
using AutoMapper;
using Domain.SqlViews;

namespace Application.Features.Dashboards.Profiles;

public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<DashboardStatistic, GetDashboardQuery>().ReverseMap();
        CreateMap<DashboardStatistic, GetDashboardQueryResponse>().ReverseMap();

    }
}