using ExternalDataProvider.Misc;
using Microsoft.VisualBasic;
using static System.Net.WebRequestMethods;

namespace ExternalDataProvider.API;

public class ApiReader : IApiReader
{
    private readonly Dictionary<int, string> _urls;
    private readonly IDataFormatter _rawDataFormatter;
    public ApiReader(IDataFormatter rawDataFormatter)
    {
        _urls = new Dictionary<int, string>()
{
    {1,"https://query1.finance.yahoo.com/v7/finance/download/{0}?period1={1}&period2={2}&interval=1d&events=history&includeAdjustedClose=true" },
    {2,"https://query1.finance.yahoo.com/v7/finance/download/{0}{1}=X?period1={2}&period2={3}&interval=1d&events=history&includeAdjustedClose=true" },
    {3,"https://query1.finance.yahoo.com/v7/finance/download/GC=F?period1={0}&period2={1}&interval=1d&events=history&includeAdjustedClose=true" },


};
        _rawDataFormatter = rawDataFormatter;
    }

    public async Task<string> ReadData(IApiGetRequest request)
    {

        string dateInFormat = request.Date.AsUnixFormat();
        string dateInFormat_10DaysPrior = request.Date.AddDays(-10).AsUnixFormat();

        string? stockSymbol = request.StockSymbol;
        string? currency = request.Currency;
        QueryType source = request.ApiSource;


        using HttpClient client = new HttpClient();
        {
            if (source == QueryType.QuoteStock)
            {
                var response = await client.GetStringAsync
                     (string.Format(_urls[(int)source], stockSymbol, dateInFormat_10DaysPrior, dateInFormat));
                var result = _rawDataFormatter.GetValueFromCsvString(response);
                return result;
            }
            if (source == QueryType.QuoteCurrency)
            {
                var usdSymbol = "USD";

                var response = await client.GetStringAsync
                    (string.Format(_urls[(int)source], usdSymbol,currency, dateInFormat_10DaysPrior, dateInFormat));
                var result = _rawDataFormatter.GetValueFromCsvString(response);
                return result;
            }
            if (source == QueryType.QuoteGold)
            {
                var response = await client.GetStringAsync
                      (string.Format(_urls[(int)source], dateInFormat_10DaysPrior, dateInFormat));
                var result = _rawDataFormatter.GetValueFromCsvString(response);
                return result;

            }

        }

        return string.Empty;



    }

    public async Task<bool> ReadDayMarketStatus(IApiGetRequest request)
    {
        string dateInFormat = request.Date.AsUnixFormat();
        string dateInFormat_10DaysPrior = request.Date.AddDays(-10).AsUnixFormat();
        string dateInUsFormat = request.Date.AsUsShortFormat();

        string? stockSymbol = request.StockSymbol;
        string? currency = request.Currency;
        QueryType source = request.ApiSource;


        using HttpClient client = new HttpClient();
        {
            var response = await client.GetStringAsync
                     (string.Format(_urls[1], "AMZN", dateInFormat_10DaysPrior, dateInFormat));
            var result = _rawDataFormatter.IsRedDay(response, dateInUsFormat);
            return result;

        }
    }

}
