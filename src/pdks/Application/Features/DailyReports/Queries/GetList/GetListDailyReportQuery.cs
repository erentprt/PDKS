using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.DailyReports.Queries.GetList;

public class GetListDailyReportQuery:IRequest<GetListResponse<GetListDailyReportListItemDto>>
{
    public PageRequest PageRequest { get; set; }
}

public class GetListDailyReportQueryHandler : IRequestHandler<GetListDailyReportQuery, GetListResponse<GetListDailyReportListItemDto>>
{
    private readonly IDailyReportRepository _dailyReportRepository;
    private readonly IMapper _mapper;


    public GetListDailyReportQueryHandler(IDailyReportRepository dailyReportRepository, IMapper mapper)
    {
        _dailyReportRepository = dailyReportRepository;
        _mapper = mapper;
    }

    public async Task<GetListResponse<GetListDailyReportListItemDto>> Handle(GetListDailyReportQuery request, CancellationToken cancellationToken)
    {
        IPaginate<DailyReport> dailyReports = await _dailyReportRepository.GetListAsync(
            index: request.PageRequest.Page,
            size: request.PageRequest.PageSize
        );
        var mappedDailyReportListModel = _mapper.Map<GetListResponse<GetListDailyReportListItemDto>>(dailyReports);
        return mappedDailyReportListModel;
    }
}