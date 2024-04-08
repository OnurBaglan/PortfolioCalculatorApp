using ExternalDataProvider.API;
using System.Text.Json;

namespace ExternalDataProvider.Services;

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

        var data = await _apiReader.ReadData(request);

        var value = decimal.Parse(data);

        return value;


    }


    

}