using PortfolioCalculatorApp.Model;
using PortfolioCalculatorApp.Views.Interfaces;
using System.Data;
using System.Text.Json;

namespace PortfolioCalculatorApp.Controller;

public class MainAppFormController
{
    private readonly IMainAppFormView _mainAppFormView;
    private readonly IAddPortfolioFormView _addPortfolioFormView;
    private readonly ICalculator _calculatorModel;

    private readonly string PortfoliosPath = "portfolios.json";

    public MainAppFormController(
        IMainAppFormView mainAppFormView,
        IAddPortfolioFormView addPortfolioFormView,
        ICalculator calculatorModel)
    {
        _mainAppFormView = mainAppFormView;
        _addPortfolioFormView = addPortfolioFormView;
        _calculatorModel = calculatorModel;


        _mainAppFormView.SavePortfolios += OnSavePortfolios;
        _mainAppFormView.LoadSavedPortfolios += OnLoadPortfolios;
        _mainAppFormView.OpenAddPortfolioForm += OnOpenAddPortfolioForm;
        _mainAppFormView.DeleteSelectedItem += OnDeleteSelectedItem;
        _mainAppFormView.InitializeCurrencyComboBox += OnLoadCurrencies;
        _mainAppFormView.CalculatePortfolio += OnCalculateEarnLossRatio;
        _mainAppFormView.CalculatePortfolio += OnCalculateTotalInvested;
        _mainAppFormView.CalculatePortfolio += OnCalculateCurrentValue;
        //_mainAppFormView.CalculatePortfolio += OnCalculateListedPurchaseDetails;
        AddPortfolioFormController.AddValidPortfolio += OnShowPortfolioInMainList;

    }

    private async void OnCalculateEarnLossRatio(object? sender, PortfolioModel e)
    {
        //TODO make a proper implementation for this
        var selectedCurrencySymbol = GetCurrencySymbolFromView();
        var selectedCurrencyName = GetCurrencyNameFromView();

        var ratio = await _calculatorModel.CalculatePortfolioEarnLoss(e, selectedCurrencySymbol);

        SetRatioInView(_mainAppFormView, ratio);
    }
    private async void OnCalculateCurrentValue(object? sender, PortfolioModel e)
    {
        var selectedCurrencySymbol = GetCurrencySymbolFromView();
        var selectedCurrencyName = GetCurrencyNameFromView();
        var totalInvested = await _calculatorModel.CalculatePortfolioWorthToday(e, selectedCurrencySymbol);
        SetPortfolioCurrentValueInView(totalInvested);
    }
    private async void OnCalculateTotalInvested(object? sender, PortfolioModel e)
    {
        var selectedCurrencySymbol = GetCurrencySymbolFromView();
        var selectedCurrencyName = GetCurrencyNameFromView();

        var totalInvested = await _calculatorModel.CalculatePortfolioCost(e, selectedCurrencySymbol);

        SetPortfolioTotalInvestedInView(totalInvested);
    }
    private void SetPortfolioCurrentValueInView(decimal totalInvested)
    {
        _mainAppFormView.LabelCurrentValue = $"{totalInvested.ToString("F2")}";
    }
    private void SetPortfolioTotalInvestedInView(decimal totalInvested)
    {
        _mainAppFormView.LabelTotalInvested = $"{totalInvested.ToString("F2")}";
    }
    private void OnLoadCurrencies(object? sender, ComboBox e)
    {
        if (File.Exists("currencies.txt"))
        {
            var data = File.ReadAllLines("currencies.txt");
            e.Items.AddRange(data);
            e.SelectedItem = data[147]; //USD
        }
    }
    private void SetRatioInView(IMainAppFormView mainAppFormView, decimal ratio)
    {
        mainAppFormView.LabelEarnLossRatio = $"{ratio.ToString("F2")} %";
    }
    private string GetCurrencyNameFromView()
    {

        var text = _mainAppFormView.ComboBoxCurrencies.SelectedItem.ToString();

        return text.Split("----").Last().ToString();
    }
    private string GetCurrencySymbolFromView()
    {
        var text = _mainAppFormView.ComboBoxCurrencies.SelectedItem.ToString();

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

}