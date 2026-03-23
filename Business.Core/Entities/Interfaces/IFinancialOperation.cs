using System;

namespace Business.Core.Core.Interfaces;

public interface IFinancialOperation
{
    Guid Id { get; }
    DateTime Date { get; }
    Decimal GetAmount();
}