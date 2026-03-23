using Business.Core.Repository.Interfaces;

namespace Business.Core.Analytics;

public class Analytics
{
    public required IFinancialRepository FinancialRepository { get; init; }
    
}