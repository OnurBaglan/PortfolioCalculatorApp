using Microsoft.VisualBasic;
using static System.Net.WebRequestMethods;

namespace ExternalDataProvider.API;

public class ApiReader
{
	private readonly Dictionary<int, string> _urls;
	public ApiReader()
	{
		_urls = new Dictionary<int, string>()
{
	{1,"https://api.marketdata.app/v1/stocks/candles/D/{0}/?from={1}&to={1}&token={2}" },
	{2,"https://api.currencybeacon.com/v1/historical?base=USD&date={0}&symbols={1}&api_key={2}" },
	{3,"https://api.metals.dev/v1/timeseries?start_date={0}&end_date={0}&api_key={1}" },


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
					(string.Format(_urls[(int)source], date, stockSymbol, Environment.GetEnvironmentVariable(source.ToString())));
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

	public async Task<string> ReadDayMarketStatus(ApiGetRequest request)
	{
		string date = request.DateInFormat;
		ApiSources source = ApiSources.MarketDataApp;
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

