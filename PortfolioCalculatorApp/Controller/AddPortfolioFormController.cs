using PortfolioCalculatorApp.Model.BusinessModel;
using PortfolioCalculatorApp.Model.DTO;
using PortfolioCalculatorApp.Views.Interfaces;

namespace PortfolioCalculatorApp.Controller;

public class AddPortfolioFormController
{
    private readonly IAddPortfolioFormView _addPortfolioFormView;
    private readonly StockListLoader _portfolioModel;
    private readonly List<Purchase> _purchases = new();

    public static event EventHandler<Portfolio> AddValidPortfolio;

    public AddPortfolioFormController(IAddPortfolioFormView addPortfolioFormView)
    {

        _portfolioModel = new StockListLoader();

        _addPortfolioFormView = addPortfolioFormView;
        _addPortfolioFormView.InitializeComboBox += OnInitializeComboBox;
        _addPortfolioFormView.SearchStock += OnSearchStock;
        _addPortfolioFormView.ResetSelections += OnResetSelections;
        _addPortfolioFormView.AddPurchase += OnAddPurchase;
        _addPortfolioFormView.RemovePurchase += OnRemovePurchase;
        _addPortfolioFormView.AddPortfolio += OnAddPortfolio;
        _addPortfolioFormView.AddPortfolioFormClosed += OnFormClosed;
    }

    private void OnFormClosed(object? sender, EventArgs e)
    {
        _addPortfolioFormView.ComboBoxStockSymbols.SelectedItem = null;
        _addPortfolioFormView.TextBoxPortfolioName.Text = null;
        _addPortfolioFormView.NumericUpDownLots.Value = 0;
        _addPortfolioFormView.DateTimePickerPurchaseDate.Value = DateTime.Now;
        _addPortfolioFormView.ListBoxAddedPurchases.Items.Clear();


    }

    private void OnAddPortfolio(object? sender, EventArgs e)
    {
        while (!DoesAddingMakeSense())
        {
            MessageBox.Show(@"Make sure you entered a valid portfolio name and have at least one purchase added");
            return;
        }



        var portfolio = new Portfolio()
        {
            Purchases = _purchases,
            Name = _addPortfolioFormView.TextBoxPortfolioName.Text
        };

        _addPortfolioFormView.CloseWrapperWithMessage("Portfolio added.");

        AddValidPortfolio?.Invoke(this, portfolio);

    }

   
    private bool DoesAddingMakeSense()
    {
        //a more in depth validation is needed in future not to duplicate names
        return !string.IsNullOrEmpty(_addPortfolioFormView.TextBoxPortfolioName.Text) &&
            _addPortfolioFormView.ListBoxAddedPurchases.Items.Count != 0;
    }

    private void OnRemovePurchase(object? sender, EventArgs e)
    {
        if (_addPortfolioFormView.ListBoxAddedPurchases.SelectedItem is not null)
        {
            var purchaseToDelete = (Purchase)_addPortfolioFormView.ListBoxAddedPurchases.SelectedItem;
            _addPortfolioFormView.ListBoxAddedPurchases.Items.Remove(purchaseToDelete);
            _purchases.Remove(purchaseToDelete);

        }
    }

    private void OnAddPurchase(object? sender, EventArgs e)
    {
        while (!IsPurchaseSelectionsValid())
        {
            MessageBox.Show(@"Please make sure you selected a stock symbol, at least one lot
and a valid weekday date");
            return;
        }

        var newPurchase = new Purchase()
        {
            StockSymbol = ConvertStockSymbolRawToSymbol(_addPortfolioFormView.ComboBoxStockSymbols.SelectedItem),
            Lots = (int)_addPortfolioFormView.NumericUpDownLots.Value,
            PurchaseDate = _addPortfolioFormView.DateTimePickerPurchaseDate.Value

        };

        _purchases.Add(newPurchase);

        _addPortfolioFormView.ListBoxAddedPurchases.Items.Add(newPurchase);

    }

    private string ConvertStockSymbolRawToSymbol(object? selectedItem)
    {
        var rawText = (string)selectedItem;

        var splitText = rawText.Split("----");

        return splitText[0];
    }

    private bool IsPurchaseSelectionsValid()
    {
        return _addPortfolioFormView.ComboBoxStockSymbols.SelectedItem is not null &&
            _addPortfolioFormView.DateTimePickerPurchaseDate.Value <= DateTime.Now &&
            _addPortfolioFormView.NumericUpDownLots.Value != 0 &&
            IsDateWeekday(_addPortfolioFormView.DateTimePickerPurchaseDate.Value);
    }

    private bool IsDateWeekday(DateTime value)
    {
        return value.DayOfWeek != DayOfWeek.Sunday &&
            value.DayOfWeek != DayOfWeek.Saturday;
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
