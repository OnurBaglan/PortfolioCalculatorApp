using PortfolioCalculatorApp.Controller;
using PortfolioCalculatorApp.Model.BusinessModel;
using PortfolioCalculatorApp.Model.DTO;
using PortfolioCalculatorApp.Views.Interfaces;
using System.Data;

public class MainAppFormController
{
	private readonly IMainAppFormView _mainAppFormView;
	private readonly IAddPortfolioFormView _addPortfolioFormView;
	private readonly AddPortfolioFormController _addPortfolioFormController;

	private readonly ApiModel _apiModel;

	public MainAppFormController(IMainAppFormView mainAppFormView, IAddPortfolioFormView addPortfolioFormView)
	{
		_mainAppFormView = mainAppFormView;
		_addPortfolioFormView = addPortfolioFormView;

		_addPortfolioFormController = new AddPortfolioFormController(_addPortfolioFormView);

        _apiModel = new ApiModel();

		_mainAppFormView.ValidateApiKey += OnValidateApiKeyAsync;
		_mainAppFormView.SaveApiKey += OnSaveApiKey;
		_mainAppFormView.LoadApiKeys += OnLoadApiKey;

		_addPortfolioFormController.SaveValidPortfolio += OnShowPortfolioInMainList;
	


	}
    private void OnShowPortfolioInMainList(object? sender, Portfolio e)
    {
		_mainAppFormView.ListBoxPortfolios.Items.Add(e);

    }
   

    private void OnLoadApiKey(object? sender, EventArgs e)
	{


		if (File.Exists("apiKey1.txt"))
		{
			var apiKey1 = File.ReadAllText("apiKey1.txt");
			_mainAppFormView.ApiKey1 = apiKey1;
		}
		if (File.Exists("apiKey2.txt"))
		{
			var apiKey2 = File.ReadAllText("apiKey2.txt");
			_mainAppFormView.ApiKey2 = apiKey2;
		}

		
	}

	private void OnSaveApiKey(object? sender, EventArgs e)
	{
		var apiSource = GetApiSource(sender);

		var apiKey = GetApiKeyValue(apiSource);

		_apiModel.SaveApiKey(apiKey, apiSource);

		SetApiKeyStatusLabel(apiSource, "Key is saved");
	}

	public async void OnValidateApiKeyAsync(object? sender, EventArgs? e)
	{

		ApiSources apiSource = GetApiSource(sender);

		string apiKey = GetApiKeyValue(apiSource);

		var isKeyValid = await _apiModel.IsKeyValid(apiKey, apiSource);

		SetApiKeyStatus(apiSource, isKeyValid);

		SetApiKeyStatusLabel(apiSource, isKeyValid);

		SetApiKeyStatusStrip();

		SetMainMenuBlockerStatus();

	}

	private void SetMainMenuBlockerStatus()
	{
		if (_mainAppFormView.IsApiKey1Valid && _mainAppFormView.IsApiKey2Valid)
		{
			_mainAppFormView.MainMenuBlockerLabel.Visible = false;
			_mainAppFormView.MainMenuBlockerPanel.Visible = false;
		}
		else
		{
			_mainAppFormView.MainMenuBlockerLabel.Visible = true;
			_mainAppFormView.MainMenuBlockerPanel.Visible = true;

		}


	}

	private void SetApiKeyStatusStrip()
	{
		if (_mainAppFormView.IsApiKey1Valid && _mainAppFormView.IsApiKey2Valid)
		{
			_mainAppFormView.ApiKeyStatusStrip = "Api keys are valid.";
			_mainAppFormView.MainMenuStatusStrip = _mainAppFormView.ApiKeyStatusStrip;
		}
		else
		{
			_mainAppFormView.ApiKeyStatusStrip = "Please enter valid api keys.";
			_mainAppFormView.MainMenuStatusStrip = _mainAppFormView.ApiKeyStatusStrip;
		}
	}

	private void SetApiKeyStatusLabel(ApiSources apiSource, bool isKeyValid)
	{
		_mainAppFormView.GetType().GetProperty(string.Format("ApiKey{0}Status", (int)apiSource)).SetValue(_mainAppFormView, string.Format("Api key status correct: {0}", isKeyValid));
	}

	private void SetApiKeyStatusLabel(ApiSources apiSource, string text)
	{
		_mainAppFormView.GetType().GetProperty(string.Format("ApiKey{0}Status", (int)apiSource)).SetValue(_mainAppFormView, text);
	}

	private void SetApiKeyStatus(ApiSources apiSource, bool isKeyValid)
	{
		_mainAppFormView.GetType().GetProperty(string.Format("IsApiKey{0}Valid", (int)apiSource)).SetValue(_mainAppFormView, isKeyValid);
	}

	private string GetApiKeyValue(ApiSources apiSource)
	{
		return (string)_mainAppFormView.GetType().GetProperty(string.Format("ApiKey{0}", (int)apiSource)).GetValue(_mainAppFormView);
	}

	private ApiSources GetApiSource(object sender)
	{
		int apiSourceId = int.Parse(((string)sender.GetType().GetProperty("Name").GetValue(sender)).Last().ToString());

		var result = (ApiSources)apiSourceId;

		return result;
	}



}