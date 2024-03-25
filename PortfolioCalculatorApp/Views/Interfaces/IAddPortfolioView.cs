
namespace PortfolioCalculatorApp.Views.Interfaces;

public interface IAddPortfolioView
{
    ComboBox ComboBoxStockSymbols { get; set; }
    NumericUpDown NumericUpDownLots { get; set; }
    DateTimePicker DateTimePickerPurchaseDate { get; set; }
    ListBox ListBoxAddedPurchases { get; set; }

    event EventHandler InitializeComboBox;
    event EventHandler SearchStock;
    event EventHandler ResetSelections;
    event EventHandler AddPurchase;
    event EventHandler RemovePurchase;
}