using System;

using Business.Core.Core.Interfaces;

namespace Business.Core.Core;

public class Expense : IFinancialOperation
{
    public required Guid Id { get; init; }
    public required DateTime Date { get; init; }

    public decimal GetAmount()
    {
        throw new NotImplementedException();
    }
}