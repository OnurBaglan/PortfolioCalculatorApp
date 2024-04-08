namespace ExternalDataProvider.API;

public class ApiGetRequest : IApiGetRequest
{
    public QueryType ApiSource { get; init; }

    public string? StockSymbol { get; init; }

    public DateTime Date { get; init; }

    public string? Currency { get; init; }

    public ApiGetRequest(QueryType apiSource,
        DateTime date, string? stockSymbol, string? currency)
    {
        ApiSource = apiSource;
        Date = date;
        StockSymbol = stockSymbol;
        Currency = currency;

    }

}

