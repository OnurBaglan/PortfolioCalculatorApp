using PortfolioCalculatorApp.Model.BusinessModel;
using PortfolioCalculatorApp.Model.DTO;
using PortfolioCalculatorApp.Views.Interfaces;
using System.Windows.Forms;

namespace PortfolioCalculatorApp.Controller;

internal class PortfolioController
{
    private readonly IAddPortfolioView _addPortfolioView;
    private readonly IPortfolioListView _portfolioViewList;
    private readonly PortfolioModel _addPortfolioModel;

    public PortfolioController(IAddPortfolioView addPortfolioView, IPortfolioListView portfolioViewList)
    {
        _addPortfolioView = addPortfolioView;
        _portfolioViewList = portfolioViewList;
        _addPortfolioModel = new PortfolioModel();


        _addPortfolioView.InitializeComboBox += OnInitializeComboBox;
        _addPortfolioView.SearchStock += OnSearchStock;
        _addPortfolioView.ResetSelections += OnResetSelections;
        _addPortfolioView.AddPurchase += OnAddPurchase;
        _addPortfolioView.RemovePurchase += OnRemovePurchase;
    }

    private void OnRemovePurchase(object? sender, EventArgs e)
    {
        if(_addPortfolioView.ListBoxAddedPurchases.SelectedItem is not null)
        {
        _addPortfolioView.ListBoxAddedPurchases.Items.Remove(_addPortfolioView.ListBoxAddedPurchases.SelectedItem);

        }
    }

    private void OnAddPurchase(object? sender, EventArgs e)
    {
        while (!IsPurchaseSelectionsValid())
        {
            MessageBox.Show(@"Please make sure you selected a stock symbol, at least one lot
and a date not in the future.");
            return;
        }

        var newPurchase = new Purchase()
        {
            StockSymbol = (string)_addPortfolioView.ComboBoxStockSymbols.SelectedItem,
            Lots = (int)_addPortfolioView.NumericUpDownLots.Value,
            PurchaseDate = _addPortfolioView.DateTimePickerPurchaseDate.Value

        };

        _addPortfolioView.ListBoxAddedPurchases.Items.Add(newPurchase.ToString());

    }

    private bool IsPurchaseSelectionsValid()
    {
        return _addPortfolioView.ComboBoxStockSymbols.SelectedItem is not null &&
            _addPortfolioView.DateTimePickerPurchaseDate.Value < DateTime.Now &&
            _addPortfolioView.NumericUpDownLots.Value != 0;
    }

    private void OnResetSelections(object? sender, EventArgs e)
    {
        _addPortfolioView.ComboBoxStockSymbols.SelectedItem = null;

        _addPortfolioView.NumericUpDownLots.Value = 0;

        _addPortfolioView.DateTimePickerPurchaseDate.Value = DateTime.Now;
    }

    public void OnInitializeComboBox(object? sender, EventArgs? e)
    {
        var stockList = _addPortfolioModel.StockList.ToArray();
        _addPortfolioView.ComboBoxStockSymbols.Items.AddRange(stockList);
        _addPortfolioView.ComboBoxStockSymbols.DropDownStyle = ComboBoxStyle.DropDownList;
    }

    public void OnSearchStock(object? sender, EventArgs? e)
    {

        _addPortfolioView.ComboBoxStockSymbols.Items.Clear();

        var data = _addPortfolioModel.StockList.Where(item => item.ToUpper().Contains(GetTextOfTextBox(sender).ToUpper())).ToArray();
        _addPortfolioView.ComboBoxStockSymbols.Items.AddRange(data);
        _addPortfolioView.ComboBoxStockSymbols.SelectedItem = data.FirstOrDefault();



        if (string.IsNullOrEmpty(GetTextOfTextBox(sender)))
        {
            _addPortfolioView.ComboBoxStockSymbols.SelectedItem = null;
        }
    }

    private string? GetTextOfTextBox(object? sender)
    {
        return (string)sender.GetType().GetProperty("Text").GetValue(sender);
    }
}
