namespace PortfolioCalculatorApp.BusinessLogic;

public interface IStockListLoader
{
	IEnumerable<string> StockList { get; }
}