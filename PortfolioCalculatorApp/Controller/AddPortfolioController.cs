using PortfolioCalculatorApp.Model.BusinessModel;
using PortfolioCalculatorApp.Model.DTO;
using PortfolioCalculatorApp.Views.Interfaces;
using System.Windows.Forms;

namespace PortfolioCalculatorApp.Controller;

internal class AddPortfolioController
{
    private readonly IAddPortfolioView _view;
    private readonly AddPortfolioModel _model;

    public AddPortfolioController(IAddPortfolioView view, AddPortfolioModel model)
    {
        _view = view;
        _model = model;
        _view.InitializeComboBox += OnInitializeComboBox;
        _view.SearchStock += OnSearchStock;
        _view.ResetSelections += OnResetSelections;
        _view.AddPurchase += OnAddPurchase;
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
            StockSymbol = (string)_view.ComboBoxStockSymbols.SelectedItem,
            Lots = (int)_view.NumericUpDownLots.Value,
            PurchaseDate = _view.DateTimePickerPurchaseDate.Value

        };

        _view.ListViewAddedPurchases.Items.Add(newPurchase.ToString());

    }

    private bool IsPurchaseSelectionsValid()
    {
        return _view.ComboBoxStockSymbols.SelectedItem is not null &&
            _view.DateTimePickerPurchaseDate.Value < DateTime.Now &&
            _view.NumericUpDownLots.Value != 0;
    }

    private void OnResetSelections(object? sender, EventArgs e)
    {
        _view.ComboBoxStockSymbols.SelectedItem = null;

        _view.NumericUpDownLots.Value = 0;

        _view.DateTimePickerPurchaseDate.Value = DateTime.Now;
    }

    public void OnInitializeComboBox(object? sender, EventArgs? e)
    {
        var stockList = _model.StockList.ToArray();
        _view.ComboBoxStockSymbols.Items.AddRange(stockList);
        _view.ComboBoxStockSymbols.DropDownStyle = ComboBoxStyle.DropDownList;
    }

    public void OnSearchStock(object? sender, EventArgs? e)
    {

        _view.ComboBoxStockSymbols.Items.Clear();

        var data = _model.StockList.Where(item => item.ToUpper().Contains(GetTextOfTextBox(sender).ToUpper())).ToArray();
        _view.ComboBoxStockSymbols.Items.AddRange(data);
        _view.ComboBoxStockSymbols.SelectedItem = data.FirstOrDefault();



        if (string.IsNullOrEmpty(GetTextOfTextBox(sender)))
        {
            _view.ComboBoxStockSymbols.SelectedItem = null;
        }
    }

    private string? GetTextOfTextBox(object? sender)
    {
        return (string)sender.GetType().GetProperty("Text").GetValue(sender);
    }
}
