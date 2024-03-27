using PortfolioCalculatorApp.Model.DTO;
using PortfolioCalculatorApp.Views.Interfaces;
using System.Net.Http.Json;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PortfolioCalculatorApp.Model.BusinessModel.API;

public class ApiReader
{
    private readonly IMainAppFormView _view;
    private readonly string[] _apiKeys;

    public ApiReader(IMainAppFormView view)
    {
        _view = view;
    }

    internal async Task<decimal> ConvertTo(string currency, decimal rawValue, DateTime purchaseDate)
    {
        var url = "https://api.currencybeacon.com/v1/historical?base=USD&date={0}&symbols={1}&api_key={2}";
        var dateInFormat = $"{purchaseDate.Year}-{purchaseDate.Month}-{purchaseDate.Day}";

        using HttpClient client = new HttpClient();
        {
            var response = await client.GetAsync(string.Format(url, dateInFormat, currency, _view.ApiKey2));

            response.EnsureSuccessStatusCode();

            var jsonText = await response.Content.ReadAsStringAsync();

            var result = ConvertJsonTextToCurrencyValue(jsonText, currency);

            return result;


        }
    }

    private decimal ConvertJsonTextToCurrencyValue(string jsonText, string currency)
    {
        JsonDocument jsonDoc = JsonDocument.Parse(jsonText);

        JsonElement root = jsonDoc.RootElement;

        JsonElement valueElement = root
            .GetProperty("response")
            .GetProperty("rates")
            .GetProperty(currency);

        decimal value = valueElement.GetDecimal();

        jsonDoc.Dispose();

        return value;
    }

    internal async Task<decimal> GetStockValue(string stockSymbol, DateTime purchaseDate)
    {
        var url = "https://api.marketdata.app/v1/stocks/candles/D/{0}/?from={1}&to={1}&token={2}";
        var dateInFormat = $"{purchaseDate.Year}-{purchaseDate.Month}-{purchaseDate.Day}";

        using HttpClient client = new HttpClient();
        {
            var response = await client.GetAsync(string.Format(url, "NVDA", dateInFormat, _view.ApiKey1));

            response.EnsureSuccessStatusCode();

            var jsonText = await response.Content.ReadAsStringAsync();

            var result = ConvertJsonTextToStockValue(jsonText);

            return result;


        }
    }

    private decimal ConvertJsonTextToStockValue(string jsonText)
    {
        var stockCandle = JsonSerializer.Deserialize<StockCandle>(jsonText);

        var result = (decimal)stockCandle.c.FirstOrDefault();

        return result;
    }
}

