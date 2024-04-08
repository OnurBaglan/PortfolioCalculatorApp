
namespace ExternalDataProvider.API
{
    public interface IApiGetRequest
    {
        QueryType ApiSource { get; init; }
        string? Currency { get; init; }
        string? StockSymbol { get; init; }
        DateTime Date { get; init; }
    }
}