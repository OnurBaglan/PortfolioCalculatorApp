using PortfolioCalculatorApp.Model.BusinessModel;
using PortfolioCalculatorApp.Model.DTO;
using PortfolioCalculatorApp.Views.Interfaces;
using System.Windows.Forms;

namespace PortfolioCalculatorApp.Controller;

internal class AddPortfolioFormController
{
    private readonly IAddPortfolioFormView _addPortfolioFormView;
    private readonly PortfolioModel _portfolioModel;

    public AddPortfolioFormController(IAddPortfolioFormView addPortfolioFormView)
    {
       
        _portfolioModel = new PortfolioModel();

        _addPortfolioFormView = addPortfolioFormView;
        _addPortfolioFormView.InitializeComboBox += OnInitializeComboBox;
        _addPortfolioFormView.SearchStock += OnSearchStock;
        _addPortfolioFormView.ResetSelections += OnResetSelections;
        _addPortfolioFormView.AddPurchase += OnAddPurchase;
        _addPortfolioFormView.RemovePurchase += OnRemovePurchase;

    }

    private void OnRemovePurchase(object? sender, EventArgs e)
    {
        if (_addPortfolioFormView.ListBoxAddedPurchases.SelectedItem is not null)
        {
            _addPortfolioFormView.ListBoxAddedPurchases.Items.Remove(_addPortfolioFormView.ListBoxAddedPurchases.SelectedItem);

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
            StockSymbol = (string)_addPortfolioFormView.ComboBoxStockSymbols.SelectedItem,
            Lots = (int)_addPortfolioFormView.NumericUpDownLots.Value,
            PurchaseDate = _addPortfolioFormView.DateTimePickerPurchaseDate.Value

        };

        _addPortfolioFormView.ListBoxAddedPurchases.Items.Add(newPurchase.ToString());

    }

    private bool IsPurchaseSelectionsValid()
    {
        return _addPortfolioFormView.ComboBoxStockSymbols.SelectedItem is not null &&
            _addPortfolioFormView.DateTimePickerPurchaseDate.Value < DateTime.Now &&
            _addPortfolioFormView.NumericUpDownLots.Value != 0;
    }

    private void OnResetSelections(object? sender, EventArgs e)
    {
        _addPortfolioFormView.ComboBoxStockSymbols.SelectedItem = null;

        _addPortfolioFormView.NumericUpDownLots.Value = 0;

        _addPortfolioFormView.DateTimePickerPurchaseDate.Value = DateTime.Now;
    }

    public void OnInitializeComboBox(object? sender, EventArgs? e)
    {
        var stockList = _portfolioModel.StockList.ToArray();
        _addPortfolioFormView.ComboBoxStockSymbols.Items.AddRange(stockList);
        _addPortfolioFormView.ComboBoxStockSymbols.DropDownStyle = ComboBoxStyle.DropDownList;
    }

    public void OnSearchStock(object? sender, EventArgs? e)
    {

        _addPortfolioFormView.ComboBoxStockSymbols.Items.Clear();

        var data = _portfolioModel.StockList.Where(item => item.ToUpper().Contains(GetTextOfTextBox(sender).ToUpper())).ToArray();
        _addPortfolioFormView.ComboBoxStockSymbols.Items.AddRange(data);
        _addPortfolioFormView.ComboBoxStockSymbols.SelectedItem = data.FirstOrDefault();



        if (string.IsNullOrEmpty(GetTextOfTextBox(sender)))
        {
            _addPortfolioFormView.ComboBoxStockSymbols.SelectedItem = null;
        }
    }

    private string? GetTextOfTextBox(object? sender)
    {
        return (string)sender.GetType().GetProperty("Text").GetValue(sender);
    }
}
