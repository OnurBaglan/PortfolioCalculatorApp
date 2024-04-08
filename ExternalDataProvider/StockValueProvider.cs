using ExternalDataProvider.API;
using ExternalDataProvider.DTO;
using System.Text.Json;

namespace ExternalDataProvider;

public class StockValueProvider : IStockValueProvider
{
    private readonly IApiReader _apiReader;
    public StockValueProvider(IApiReader apiReader)
    {
        _apiReader = apiReader;
    }

    public async Task<decimal> Get(string stockSymbol, DateTime date)
    {
        var request = new ApiGetRequest(QueryType.QuoteStock, date, stockSymbol, null);

        var jsonText = await _apiReader.ReadRawData(request);



        var result = ConvertJsonTextToStockValue(jsonText);

        return result;


    }


    private decimal ConvertJsonTextToStockValue(string jsonText)
    {
        var stockCandle = JsonSerializer.Deserialize<StockDataDTO>(jsonText);

        var result = (decimal)stockCandle.c.FirstOrDefault();

        return result;
    }


}