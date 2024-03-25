
namespace PortfolioCalculatorApp.Views.Interfaces
{
    internal interface IPortfolioListView
    {
        ListBox ListBoxPortfolios { get; set; }
        Button ButtonAddNewPortfolio { get; set; }
        Button ButtonDeleteSelectedPortfolio { get; set; }
    }
}