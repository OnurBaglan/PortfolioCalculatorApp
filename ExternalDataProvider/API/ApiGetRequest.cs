namespace ExternalDataProvider.API;

public class ApiGetRequest : IApiGetRequest
{
    public QueryType ApiSource { get; init; }

    public string? StockSymbol { get; init; }

    private readonly DateTime _date;

    public string DateInFormat { get; init; }

    public string? Currency { get; init; }

    public ApiGetRequest(QueryType apiSource,
        DateTime date, string? stockSymbol, string? currency)
    {
        ApiSource = apiSource;
        _date = date;

        DateInFormat = $"{_date.Year}-{_date.Month}-{_date.Day}";
        StockSymbol = stockSymbol;
        Currency = currency;

    }

}

