﻿namespace ExternalDataProvider.API;

internal class ApiReader
{
    private readonly Dictionary<int, string> _urls;
    public ApiReader()
    {
        _urls = new Dictionary<int, string>()
{
    {1,"https://api.marketdata.app/v1/stocks/candles/D/{0}/?from={1}&to={1}&token={2}" },
    {2,"https://api.currencybeacon.com/v1/historical?base=USD&date={0}&symbols={1}&api_key={2}" },
    {3,"https://api.metals.dev/v1/timeseries?start_date={0}&end_date={0}&api_key={1}" }

};
    }

    public async Task<string> ReadRawData(ApiGetRequest request)
    {

        string date = request.DateInFormat;
        string? stockSymbol = request.StockSymbol;
        string? currency = request.Currency;
        ApiSources source = request.ApiSource;


        using HttpClient client = new HttpClient();
        {
            if (source == ApiSources.MarketDataApp)
            {
                var response = await client.GetAsync
                    (string.Format(_urls[(int)source], stockSymbol, date, Environment.GetEnvironmentVariable(source.ToString())));
                response.EnsureSuccessStatusCode();
                var result = await response.Content.ReadAsStringAsync();
                return result;
            }
            if (source == ApiSources.CurrencyBeacon)
            {
                var response = await client.GetAsync
                    (string.Format(_urls[(int)source], date, Environment.GetEnvironmentVariable(source.ToString())));
                response.EnsureSuccessStatusCode();
                var result = await response.Content.ReadAsStringAsync();
                return result;
            }
            if (source == ApiSources.MetalDev)
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






    //private readonly IMainAppFormView _view;
    //private readonly string[] _apiKeys;

    //public ApiReader(IMainAppFormView view)
    //{
    //    _view = view;
    //}

    //internal async Task<decimal> ConvertTo(string currency, decimal rawValue, DateTime purchaseDate)
    //{
    //    var url = "https://api.currencybeacon.com/v1/historical?base=USD&date={0}&symbols={1}&api_key={2}";
    //    var dateInFormat = $"{purchaseDate.Year}-{purchaseDate.Month}-{purchaseDate.Day}";

    //    using HttpClient client = new HttpClient();
    //    {
    //        var response = await client.GetAsync(string.Format(url, dateInFormat, currency, _view.ApiKey2));

    //        response.EnsureSuccessStatusCode();

    //        var jsonText = await response.Content.ReadAsStringAsync();

    //        var result = ConvertJsonTextToCurrencyValue(jsonText, currency);

    //        return result;


    //    }
    //}

    //private decimal ConvertJsonTextToCurrencyValue(string jsonText, string currency)
    //{
    //    JsonDocument jsonDoc = JsonDocument.Parse(jsonText);

    //    JsonElement root = jsonDoc.RootElement;

    //    JsonElement valueElement = root
    //        .GetProperty("response")
    //        .GetProperty("rates")
    //        .GetProperty(currency);

    //    decimal value = valueElement.GetDecimal();

    //    jsonDoc.Dispose();

    //    return value;
    //}

    //internal async Task<decimal> GetStockValue(string stockSymbol, DateTime purchaseDate)
    //{
    //    var url = "https://api.marketdata.app/v1/stocks/candles/D/{0}/?from={1}&to={1}&token={2}";
    //    var dateInFormat = $"{purchaseDate.Year}-{purchaseDate.Month}-{purchaseDate.Day}";

    //    using HttpClient client = new HttpClient();
    //    {
    //        var response = await client.GetAsync(string.Format(url, "NVDA", dateInFormat, _view.ApiKey1));

    //        response.EnsureSuccessStatusCode();

    //        var jsonText = await response.Content.ReadAsStringAsync();

    //        var result = ConvertJsonTextToStockValue(jsonText);

    //        return result;


    //    }
    //}

    //private decimal ConvertJsonTextToStockValue(string jsonText)
    //{
    //    var stockCandle = JsonSerializer.Deserialize<StockCandle>(jsonText);

    //    var result = (decimal)stockCandle.c.FirstOrDefault();

    //    return result;
    //}
}
