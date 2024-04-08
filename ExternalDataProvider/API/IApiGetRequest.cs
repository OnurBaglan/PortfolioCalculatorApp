namespace ExternalDataProvider.API
{
    public interface IApiGetRequest
    {
        QueryType ApiSource { get; init; }
        string? Currency { get; init; }
        string DateInFormat { get; init; }
        string? StockSymbol { get; init; }
    }
}