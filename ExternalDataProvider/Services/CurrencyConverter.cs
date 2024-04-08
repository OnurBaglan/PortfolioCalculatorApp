using ExternalDataProvider.API;
using System.Text.Json;

namespace ExternalDataProvider.Services;

public class CurrencyConverter : ICurrencyConverter
{
    private readonly IApiReader _apiReader;

    private const decimal OunceToGram = 28.3495m;

    public CurrencyConverter(IApiReader apiReader)
    {
        _apiReader = apiReader;
    }


    public async Task<decimal> GetUsdToGramGold(decimal usdAmount, DateTime date)
    {

        var request = new ApiGetRequest(QueryType.QuoteGold, date, null, null);

        var data = await _apiReader.ReadData(request);

        var ounceValue = decimal.Parse(data);

        return (OunceToGram / ounceValue) * usdAmount;




    }

    public async Task<decimal> GetUsdToCurrency(decimal usdAmount, string currencySymbol, DateTime date)
    {
        var request = new ApiGetRequest(QueryType.QuoteCurrency, date, null, currencySymbol);

        var data = await _apiReader.ReadData(request);

        var value= decimal.Parse(data);

        return value*usdAmount;


    }



}