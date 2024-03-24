using PortfolioCalculatorApp.EventArguments;
using PortfolioCalculatorApp.Views.Interfaces;
using System.Data;

public class ApiKeyTabController
{
	private readonly IApiKeyTabView _view;
	private readonly ApiKeyValidatorModel _model;

	public ApiKeyTabController(IApiKeyTabView view, ApiKeyValidatorModel model)
	{
		_view = view;
		_model = model;
		_view.ValidateApiKey += OnValidateApiKeyAsync;
		


	}

	//TODO: a total mess of a code needs refactoring

	public async void OnValidateApiKeyAsync(object sender, ValidateApiEventArgs e)
	{
		if (e.ApiSource == ApiSources.MarketDataApp)
		{
			var apiKey = _view.ApiKey1;
			var isValid = await _model.IsKeyValid(apiKey, e.ApiSource);

			if (isValid)
			{
				_view.IsApiKey1Valid = true;
				
			}
			else
			{
				_view.IsApiKey1Valid = false;
			}
			UpdateApiKeyStatus(e, _view.IsApiKey1Valid);
		}

		if (e.ApiSource == ApiSources.CurrencyBeacon)
		{
			var apiKey = _view.ApiKey2;
			var isValid = await _model.IsKeyValid(apiKey, e.ApiSource);

			if (isValid)
			{
				_view.IsApiKey2Valid = true;
				
			}
			else
			{
				_view.IsApiKey2Valid = false;
			}
			UpdateApiKeyStatus(e, _view.IsApiKey2Valid);

		}
	}

	private void UpdateApiKeyStatus(ValidateApiEventArgs e, bool isApiKeyValid)
	{
		if (e.ApiSource==ApiSources.MarketDataApp)
		{
			if (isApiKeyValid)
			{
			_view.ApiKey1Status = "Api key is valid.";

			}
			else
			{
				_view.ApiKey1Status = "Please enter a valid api key";

			}
		}

		if(e.ApiSource == ApiSources.CurrencyBeacon)
		{
			if (isApiKeyValid)
			{
				_view.ApiKey2Status = "Api key is valid.";

			}
			else
			{
				_view.ApiKey2Status = "Please enter a valid api key";

			}
		}
	}
}