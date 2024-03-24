namespace PortfolioCalculatorApp.Views.Interfaces;

public interface IApiKeyTabView
{
	string ApiKey1 { get; set; }
	string ApiKey2 { get; set; }

	public bool IsApiKey1Valid { get; set; }
	public bool IsApiKey2Valid { get; set; }

	public string ApiKey1Status { get; set; }
	public string ApiKey2Status { get; set; }

	event EventHandler ValidateApiKey1;
}