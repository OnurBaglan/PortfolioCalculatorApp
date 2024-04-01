using ExternalDataProvider.API;
using System.Text.Json;

namespace ExternalDataProvider;

public class CurrencyConverter : ICurrencyConverter
{
    private readonly ApiReader _apiReader;

    private const double OunceToGram = 28.3495;

    public CurrencyConverter()
    {
        _apiReader = new ApiReader();
    }


    public async Task<decimal> GetUsdToGramGold(decimal usdAmount, DateTime date)
    {

        var request = new ApiGetRequest(ApiSources.MetalDev, date, null, null);

        var jsonText = await _apiReader.ReadRawData(request);

        JsonDocument jsonDoc = JsonDocument.Parse(jsonText);

        JsonElement root = jsonDoc.RootElement;

        var dateInFormat = $"{date.Year}-{date.Month}-{date.Day}";

        JsonElement goldElement = root
            .GetProperty("rates")
            .GetProperty(dateInFormat)
            .GetProperty("metals")
            .GetProperty("gold");

        double priceOfOunceGolde = goldElement.GetDouble();
        jsonDoc.Dispose();

        return (decimal)(OunceToGram / priceOfOunceGolde) * usdAmount;




    }

    public async Task<decimal> GetUsdToCurrency(decimal usdAmount, string currencySymbol, DateTime date)
    {
        var request = new ApiGetRequest(ApiSources.CurrencyBeacon, date, null, currencySymbol);

        var jsonText = await _apiReader.ReadRawData(request);

        var dateInFormat = $"{date.Year}-{date.Month}-{date.Day}";


        using (JsonDocument document = JsonDocument.Parse(jsonText))
        {
            JsonElement ratesElement = document.RootElement.GetProperty("rates");
            double eurRate = ratesElement.GetProperty("EUR").GetDouble();

            return (decimal)(eurRate) * usdAmount;

        }

    }



}