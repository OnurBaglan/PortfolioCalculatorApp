
namespace PortfolioCalculatorApp.Views.Interfaces;

public interface IAddPortfolioFormView
{
    ComboBox ComboBoxStockSymbols { get; set; }
    NumericUpDown NumericUpDownLots { get; set; }
    DateTimePicker DateTimePickerPurchaseDate { get; set; }
    ListBox ListBoxAddedPurchases { get; set; }
    TextBox TextBoxPortfolioName { get; set; }

    event EventHandler InitializeComboBox;
    event EventHandler SearchStock;
    event EventHandler ResetSelections;
    event EventHandler RemovePurchase;
    event EventHandler AddPortfolio;
    event EventHandler AddPurchase;
    event EventHandler AddPortfolioFormClosed;

    public void ShowDialogWrapper();
    void CloseWrapperWithMessage(string message);
}