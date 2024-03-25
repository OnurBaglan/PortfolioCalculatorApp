using PortfolioCalculatorApp.Model.BusinessModel;
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
