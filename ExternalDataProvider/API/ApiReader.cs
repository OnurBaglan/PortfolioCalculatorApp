using Microsoft.VisualBasic;
using static System.Net.WebRequestMethods;

namespace ExternalDataProvider.API;

public class ApiReader : IApiReader
{
    private readonly Dictionary<int, string> _urls;
    public ApiReader()
    {
        _urls = new Dictionary<int, string>()
{
    {1,"https://query1.finance.yahoo.com/v7/finance/download/{0}?period1={1}&period2={2}&interval=1d&events=history&includeAdjustedClose=true" },
    {2,"https://query1.finance.yahoo.com/v7/finance/download/{0}{1}=X?period1={2}&period2={3}&interval=1d&events=history&includeAdjustedClose=true" },
    {3,"https://query1.finance.yahoo.com/v7/finance/download/GC%3DF=X?period1={0}&period2={1}&interval=1d&events=history&includeAdjustedClose=true" },

    
};
    }

    public async Task<string> ReadRawData(IApiGetRequest request)
    {

        string date = request.DateInFormat;
        string? stockSymbol = request.StockSymbol;
        string? currency = request.Currency;
        QueryType source = request.ApiSource;


        using HttpClient client = new HttpClient();
        {
            if (source == QueryType.QuoteStock)
            {
                var response = await client.GetAsync
                    (string.Format(_urls[(int)source], stockSymbol, date, Environment.GetEnvironmentVariable(source.ToString())));
                response.EnsureSuccessStatusCode();
                var result = await response.Content.ReadAsStringAsync();
                return result;
            }
            if (source == QueryType.QuoteCurrency)
            {
                var response = await client.GetAsync
                    (string.Format(_urls[(int)source], date, stockSymbol, Environment.GetEnvironmentVariable(source.ToString())));
                response.EnsureSuccessStatusCode();
                var result = await response.Content.ReadAsStringAsync();
                return result;
            }
            if (source == QueryType.QuoteGold)
            {
                var response = await client.GetAsync
                    (string.Format(_urls[(int)source], date, Environment.GetEnvironmentVariable(source.ToString())));
                response.EnsureSuccessStatusCode();
                var result = await response.Content.ReadAsStringAsync();
                return result;

            }

        }

        return string.Empty;



    }

    public async Task<string> ReadDayMarketStatus(IApiGetRequest request)
    {
        string date = request.DateInFormat;
        QueryType source = QueryType.QuoteStock;
        var url = "https://api.marketdata.app/v1/markets/status/?from={0}&to={0}&token={1}";

        using HttpClient client = new HttpClient();
        {
            var response = await client.GetAsync(string.Format(url, date, Environment.GetEnvironmentVariable(source.ToString())));
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return result;

        }
    }

}

