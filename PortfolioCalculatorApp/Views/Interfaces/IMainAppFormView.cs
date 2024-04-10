using PortfolioCalculatorApp.Model;

namespace PortfolioCalculatorApp.Views.Interfaces;

public interface IMainAppFormView
{

    ListBox ListBoxPortfolios { get; set; }
    string LabelEarnLossRatio { get; set; }
    string LabelTotalInvested { get; set; }
    string LabelCurrentValue { get; set; }
    ComboBox ComboBoxCurrencies { get; }
	DataGridView DataGridViewPortfolioDetails { get; set; }

	event EventHandler<ListBox> SavePortfolios;
    event EventHandler LoadSavedPortfolios;
    event EventHandler<PortfolioModel> PortfolioSelected;
    event EventHandler OpenAddPortfolioForm;
    event EventHandler<ListBox> DeleteSelectedItem;
    event EventHandler<PortfolioModel> CalculatePortfolio;
    event EventHandler<ComboBox> InitializeCurrencyComboBox;
	event EventHandler<PortfolioModel> ShowPortfolioDetails;
}