

using ExternalDataProvider.API;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.Json;

namespace ExternalDataProvider.Services;

public class RedDayValidator : IRedDayValidator
{
    private readonly IApiReader _apiReader;

    public RedDayValidator(IApiReader apiReader)
    {
        _apiReader = apiReader;
    }
    public async Task<bool> IsRedDay(DateTime date)
    {
        var request = new ApiGetRequest(QueryType.QuoteStock, date, null, null);

        var result = await _apiReader.ReadDayMarketStatus(request);

        return result;
    }




}
