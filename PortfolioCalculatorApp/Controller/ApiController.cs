using PortfolioCalculatorApp.EventArguments;
using PortfolioCalculatorApp.Model.BusinessModel;
using PortfolioCalculatorApp.Views.Interfaces;
using System.Data;

public class ApiController
{
	private readonly IApiKeyTabView _view;
	private readonly ApiModel _model;

	public ApiController(IApiKeyTabView view, ApiModel model)
	{
		_view = view;
		_model = model;
		_view.ValidateApiKey += OnValidateApiKeyAsync;
		_view.SaveApiKey += OnSaveApiKey;
		_view.LoadApiKeys += OnLoadApiKey;

	}

	private void OnLoadApiKey(object? sender, EventArgs e)
	{


		if (File.Exists("apiKey1.txt"))
		{
			var apiKey1 = File.ReadAllText("apiKey1.txt");
			_view.ApiKey1 = apiKey1;
		}
		if (File.Exists("apiKey2.txt"))
		{
			var apiKey2 = File.ReadAllText("apiKey2.txt");
			_view.ApiKey2 = apiKey2;
		}

		
	}

	private void OnSaveApiKey(object? sender, EventArgs e)
	{
		var apiSource = GetApiSource(sender);

		var apiKey = GetApiKeyValue(apiSource);

		_model.SaveApiKey(apiKey, apiSource);

		SetApiKeyStatusLabel(apiSource, "Key is saved");
	}

	public async void OnValidateApiKeyAsync(object? sender, EventArgs? e)
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

	private void SetApiKeyStatusLabel(ApiSources apiSource, string text)
	{
		_view.GetType().GetProperty(string.Format("ApiKey{0}Status", (int)apiSource)).SetValue(_view, text);
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