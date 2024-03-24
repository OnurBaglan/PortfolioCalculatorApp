public class APIKeyValidator
{

	private readonly Dictionary<int, string> _urls;

	public APIKeyValidator()
	{
		_urls = new Dictionary<int, string>()
		{
			{1,"https://api.marketdata.app/v1/stocks/candles/D/MSFT/?from=2020-01-01&to=2020-12-31&token={0}" },
			{2,"https://api.currencybeacon.com/v1/convert?from=USD&to=EUR&api_key={0}" }

		};
	}


	public async Task<bool> IsKeyValid(string apiKey, APISources apiSource)
	{
		var statusCode = await MakeRandomRequest(apiKey,apiSource);

		return statusCode == 401 ? false : true;
	}

	private async Task<int> MakeRandomRequest(string apiKey, APISources apiSource)
	{

		var url = _urls[(int)apiSource];

		using (HttpClient client = new HttpClient())
		{
			var response = await client.GetAsync(string.Format(url,apiKey));

			var data = response.StatusCode;

			return ((int)data);
		}

			
	}
}
