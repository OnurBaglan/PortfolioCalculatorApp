
namespace PortfolioCalculatorApp.Model.BusinessModel
{
    public interface IStockListLoader
    {
        IEnumerable<string> StockList { get; }
    }
}