using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.DailyReports.Queries.GetByDate;

public class GetByDateDailyReportQuery:IRequest<GetByDateDailyReportQueryResponse>
{
}

public class GetByDateDailyReportQueryHandler:IRequestHandler<GetByDateDailyReportQuery,GetByDateDailyReportQueryResponse>
{
    private readonly IDailyReportRepository _dailyReportRepository;
    private readonly IMapper _mapper;
    
    public GetByDateDailyReportQueryHandler(IDailyReportRepository dailyReportRepository, IMapper mapper)
    {
        _dailyReportRepository = dailyReportRepository;
        _mapper = mapper;
    }

    public async Task<GetByDateDailyReportQueryResponse> Handle(GetByDateDailyReportQuery request, CancellationToken cancellationToken)
    {
        var dailyReport = await _dailyReportRepository.GetAsync(x=>x.Date.Date==DateTime.UtcNow.Date);
        return _mapper.Map<GetByDateDailyReportQueryResponse>(dailyReport);    
    }
}
