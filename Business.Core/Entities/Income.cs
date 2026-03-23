using System;
using System.Collections.Generic;

using Business.Core.Clients.Interfaces;
using Business.Core.Core.Interfaces;

namespace Business.Core.Core;

public class Income : IFinancialOperation
{
    
    public required Guid Id { get; init; }
    public required IClient Client { get; init; }
    public required DateTime Date { get; init; }
    public Decimal GetAmount()
    {
        throw new NotImplementedException();
    }
}