using PortfolioCalculatorApp.BusinessModel.API;
using PortfolioCalculatorApp.Model;
using PortfolioCalculatorApp.Views.Interfaces;
using System.Data;
using System.Text.Json;

namespace PortfolioCalculatorApp.Controller;

public class MainAppFormController
{
    private readonly IMainAppFormView _mainAppFormView;
    private readonly IAddPortfolioFormView _addPortfolioFormView;
    private readonly IApiValidator _apiValidatorModel;
    private readonly ICalculator _calculatorModel;

    private readonly string PortfoliosPath = "portfolios.json";

    public MainAppFormController(
        IMainAppFormView mainAppFormView,
        IAddPortfolioFormView addPortfolioFormView,
        IApiValidator apiValidatorModel,
        ICalculator calculatorModel)
    {
        _mainAppFormView = mainAppFormView;
        _addPortfolioFormView = addPortfolioFormView;
        _apiValidatorModel = apiValidatorModel;
        _calculatorModel = calculatorModel;


        _mainAppFormView.ValidateApiKey += OnValidateApiKeyAsync;
        _mainAppFormView.SaveApiKey += OnSaveApiKey;
        _mainAppFormView.LoadApiKeys += OnLoadApiKey;
        _mainAppFormView.SavePortfolios += OnSavePortfolios;
        _mainAppFormView.LoadSavedPortfolios += OnLoadPortfolios;
        _mainAppFormView.OpenAddPortfolioForm += OnOpenAddPortfolioForm;
        _mainAppFormView.DeleteSelectedItem += OnDeleteSelectedItem;
        AddPortfolioFormController.AddValidPortfolio += OnShowPortfolioInMainList;
        _mainAppFormView.InitializeCurrencyComboBox += OnLoadCurrencies;
        _mainAppFormView.CalculatePortfolio += OnCalculateEarnLossRatio;
        //_mainAppFormView.CalculatePortfolio += OnCalculateTotalInvested;
        //_mainAppFormView.CalculatePortfolio += OnCalculateCurrentValue;
        //_mainAppFormView.CalculatePortfolio += OnCalculateListedPurchaseDetails;


    }



    private void OnLoadCurrencies(object? sender, ComboBox e)
    {
        if (File.Exists("currencies.txt"))
        {
            var data = File.ReadAllLines("currencies.txt");
            e.Items.AddRange(data);
            e.SelectedItem = data[146]; //USD
        }
    }

    private async void OnCalculateEarnLossRatio(object? sender, PortfolioModel e)
    {
        var selectedCurrencySymbol = GetCurrencySymbol(sender);
        var selectedCurrencyName = GetCurrencyName(sender);

        var ratio = await _calculatorModel.CalculatePortfolioEarnLoss(e, selectedCurrencySymbol);
              //TODO make a proper implementation for this
        
    }

    private string GetCurrencyName(object? sender)
    {
        var form = sender as MainAppForm;

        var comboBox = (ComboBox)form.GetType().GetProperty("ComboBox_Currencies").GetValue(form);

        var text = comboBox.SelectedItem.ToString();

        return text.Split("----").Last().ToString();
    }

    private string GetCurrencySymbol(object? sender)
    {
        var form = sender as MainAppForm;

        var comboBox = (ComboBox)form.GetType().GetProperty("ComboBox_Currencies").GetValue(form);

        var text = comboBox.SelectedItem.ToString();

        return text.Split("----").First().ToString();
    }

    private void OnDeleteSelectedItem(object? sender, ListBox listBox)
    {


        var itemToDelete = listBox.SelectedItem;

        if (itemToDelete == null) return;

        listBox.Items.Remove(itemToDelete);
    }

    private void OnOpenAddPortfolioForm(object? sender, EventArgs e)
    {
        _addPortfolioFormView.ShowDialogWrapper();

    }

    private void OnLoadPortfolios(object? sender, EventArgs e)
    {
        if (File.Exists(PortfoliosPath))
        {
            var data = File.ReadAllText(PortfoliosPath);
            var collection = JsonSerializer.Deserialize<List<PortfolioModel>>(data);

            if (collection is not null)
            {
                var result = collection.Select(x => (object)x).ToArray();
                _mainAppFormView.ListBoxPortfolios.Items.AddRange(result);

            }



        }
    }


    private void OnSavePortfolios(object? sender, ListBox listBox)
    {
        List<PortfolioModel> portfoliosToSave = new();

        foreach (var item in listBox.Items)
        {
            portfoliosToSave.Add((PortfolioModel)item);
        }

        var newJsonText = JsonSerializer.Serialize(portfoliosToSave);

        File.WriteAllText(PortfoliosPath, newJsonText);

    }



    private void OnShowPortfolioInMainList(object? sender, PortfolioModel e)
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
        if (File.Exists("apiKey3.txt"))
        {
            var apiKey3 = File.ReadAllText("apiKey3.txt");
            _mainAppFormView.ApiKey3 = apiKey3;
        }



    }

    private void OnSaveApiKey(object? sender, EventArgs e)
    {
        var apiSource = GetApiSource(sender);

        var apiKey = GetApiKeyValue(apiSource);

        _apiValidatorModel.SaveApiKey(apiKey, apiSource);

        SetApiKeyStatusLabel(apiSource, "Key is saved");
    }

    public async void OnValidateApiKeyAsync(object? sender, EventArgs? e)
    {

        ApiSources apiSource = GetApiSource(sender);

        string apiKey = GetApiKeyValue(apiSource);

        var isKeyValid = await _apiValidatorModel.IsApiKeyValid(apiKey, apiSource);

        SetApiKeyStatus(apiSource, isKeyValid);

        SetApiKeyStatusLabel(apiSource, isKeyValid);

        SetApiKeyStatusStrip();

        SetMainMenuBlockerStatus();

        SetEnvironmentVariable(apiSource, apiKey, isKeyValid);

    }

    private static void SetEnvironmentVariable(ApiSources apiSource, string apiKey, bool isKeyValid)
    {
        if (isKeyValid)
        {
            Environment.SetEnvironmentVariable(apiSource.ToString(), apiKey);
        }
    }

    private void SetMainMenuBlockerStatus()
    {
        if (_mainAppFormView.IsApiKey1Valid && _mainAppFormView.IsApiKey2Valid && _mainAppFormView.IsApiKey3Valid)
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
        if (_mainAppFormView.IsApiKey1Valid && _mainAppFormView.IsApiKey2Valid && _mainAppFormView.IsApiKey3Valid)
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
        _mainAppFormView
            .GetType()
            .GetProperty(string.Format("ApiKey{0}Status", (int)apiSource))
            .SetValue(_mainAppFormView, string.Format("Api key status correct: {0}", isKeyValid));
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