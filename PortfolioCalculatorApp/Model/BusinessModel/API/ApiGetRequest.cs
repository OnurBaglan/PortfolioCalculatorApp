

namespace PortfolioCalculatorApp.Model.BusinessModel.API;

internal class ApiGetRequest
{
    public ApiSources ApiSource { get; init; }

    public string? StockSymbol { get; init; }

    private readonly DateTime _date;

    public string DateInFormat { get; init; }    

    public string? Currency { get; init; }

    public ApiGetRequest(ApiSources apiSource,
        DateTime date, string? stockSymbol, string? currency)
    {
        ApiSource = apiSource;
        _date = date;

        DateInFormat = $"{_date.Year}-{_date.Month}-{_date.Day}";

        switch (apiSource)
        {
            case ApiSources.MarketDataApp:
                ArgumentNullException.ThrowIfNull(stockSymbol);
                break;
            case ApiSources.CurrencyBeacon:
                ArgumentNullException.ThrowIfNull(currency);
                break;

        }

        StockSymbol = stockSymbol;
        Currency = currency;

    }

}

