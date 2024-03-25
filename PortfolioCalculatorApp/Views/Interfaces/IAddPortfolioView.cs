
namespace PortfolioCalculatorApp.Views.Interfaces;

public interface IAddPortfolioView
{
    ComboBox ComboBoxStockSymbols { get; set; }

    event EventHandler InitializeComboBox;
    event EventHandler SearchStock;
}