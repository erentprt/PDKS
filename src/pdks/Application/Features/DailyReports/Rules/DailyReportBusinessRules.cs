using Application.Features.DailyReports.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcers.Exceptions.Types;

namespace Application.Features.DailyReports.Rules;

public class DailyReportBusinessRules:BaseBusinessRules
{
    private readonly IDailyReportRepository _dailyReportRepository;

    public DailyReportBusinessRules(IDailyReportRepository dailyReportRepository)
    {
        _dailyReportRepository = dailyReportRepository;
    }
    
    public async Task DailyReportExists(DateTime date)
    {
        var dailyReport = await _dailyReportRepository.GetAsync(x=>x.Date.Date == date.Date);
        
        if (dailyReport != null)
            throw new BusinessException(DailyReportMessages.DailyReportExists);
    }
    
}