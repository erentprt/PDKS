using Application.Services.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.Dashboards.Queries.GetDashboard;

public class GetDashboardQuery:IRequest<GetDashboardQueryResponse>
{
}

public class GetDashboardQueryHandler:IRequestHandler<GetDashboardQuery,GetDashboardQueryResponse>
{
    private readonly IDashboardRepository _dashboardRepository;
    private readonly IMapper _mapper;

    public GetDashboardQueryHandler(IDashboardRepository dashboardRepository, IMapper mapper)
    {
        _dashboardRepository = dashboardRepository;
        _mapper = mapper;
    }

    public async Task<GetDashboardQueryResponse> Handle(GetDashboardQuery request, CancellationToken cancellationToken)
    {
        var dashboard = await _dashboardRepository.GetFirstViewAsync();
        var mappedDashboard = _mapper.Map<GetDashboardQueryResponse>(dashboard);
        return mappedDashboard;
    }
}
