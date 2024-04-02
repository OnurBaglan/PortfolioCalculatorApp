namespace PortfolioCalculatorApp.Model.BusinessModel.API;

public class ApiValidator : IApiValidator
{

    private readonly Dictionary<int, string> _urls;

    public ApiValidator()
    {
        _urls = new Dictionary<int, string>()
{
    {1,"https://api.marketdata.app/v1/stocks/candles/D/MSFT/?from=2020-01-01&to=2020-12-31&token={0}" },
    {2,"https://api.currencybeacon.com/v1/convert?from=USD&to=EUR&api_key={0}" },
    {3,"https://api.metals.dev/v1/latest?api_key={0}&currency=USD&unit=toz" }

};
    }


    public async Task<bool> IsApiKeyValid(string apiKey, ApiSources apiSource)
    {
        var statusCode = await MakeRandomRequest(apiKey, apiSource);

        return statusCode == 401 ? false : true;
    }

    private async Task<int> MakeRandomRequest(string apiKey, ApiSources apiSource)
    {

        var url = _urls[(int)apiSource];

        using (HttpClient client = new HttpClient())
        {
            var response = await client.GetAsync(string.Format(url, apiKey));

            var data = response.StatusCode;

            return (int)data;
        }


    }


    public void SaveApiKey(string apiKey, ApiSources apiSource)
    {
        var path = Path.Combine(Environment.CurrentDirectory, string.Format("apiKey{0}.txt", (int)apiSource));

        File.WriteAllText(path, apiKey);

    }

    public string? LoadApiKey(ApiSources apiSource)
    {
        if (File.Exists(string.Format("/apiKey{0}", (int)apiSource)))
        {
            var data = File.ReadAllText(string.Format("/apiKey{0}", (int)apiSource));
            return data;
        }

        return null;
    }
}