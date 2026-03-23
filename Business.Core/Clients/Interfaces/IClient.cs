namespace Business.Core.Interfaces;

public interface IClient
{
    Guid Id { get; }
    uint Inn { get; }
    string FirstName { get; }
    string? Patronymic { get; }
    string LastName { get; }

    Decimal GetTaxRate();
}