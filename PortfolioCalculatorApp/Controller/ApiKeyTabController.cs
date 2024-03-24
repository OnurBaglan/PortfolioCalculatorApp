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



	public async void OnValidateApiKeyAsync(object sender, EventArgs e)
	{

		ApiSources apiSource = GetApiSource(sender);

		string apiKey = GetApiKeyValue(apiSource);

		var isKeyValid = await _model.IsKeyValid(apiKey, apiSource);

		SetApiKeyStatus(apiSource, isKeyValid);

		SetApiKeyStatusLabel(apiSource, isKeyValid);

		SetApiKeyStatusStrip();

		SetMainMenuBlockerStatus();

	}

	private void SetMainMenuBlockerStatus()
	{
		if (_view.IsApiKey1Valid && _view.IsApiKey2Valid)
		{
			_view.MainMenuBlockerLabel.Visible = false;
			_view.MainMenuBlockerPanel.Visible = false;
		}
		else
		{
			_view.MainMenuBlockerLabel.Visible = true;
			_view.MainMenuBlockerPanel.Visible = true;

		}
	
		
	}

	private void SetApiKeyStatusStrip()
	{
		if (_view.IsApiKey1Valid && _view.IsApiKey2Valid)
		{
			_view.ApiKeyStatusStrip = "Api keys are valid.";
			_view.MainMenuStatusStrip = _view.ApiKeyStatusStrip;
		}
		else
		{
			_view.ApiKeyStatusStrip = "Please enter valid api keys.";
			_view.MainMenuStatusStrip = _view.ApiKeyStatusStrip;
		}
	}

	private void SetApiKeyStatusLabel(ApiSources apiSource, bool isKeyValid)
	{
		_view.GetType().GetProperty(string.Format("ApiKey{0}Status", (int)apiSource)).SetValue(_view, string.Format("Api key status correct: {0}", isKeyValid));
	}

	private void SetApiKeyStatus(ApiSources apiSource, bool isKeyValid)
	{
		_view.GetType().GetProperty(string.Format("IsApiKey{0}Valid", (int)apiSource)).SetValue(_view, isKeyValid);
	}

	private string GetApiKeyValue(ApiSources apiSource)
	{
		return (string)_view.GetType().GetProperty(string.Format("ApiKey{0}", (int)apiSource)).GetValue(_view);
	}

	private ApiSources GetApiSource(object sender)
	{
		int apiSourceId = int.Parse(((string)sender.GetType().GetProperty("Name").GetValue(sender)).Last().ToString());

		var result = (ApiSources)apiSourceId;

		return result;
	}

}