namespace PortfolioCalculatorApp.Model.BusinessModel;


public class StockListLoader : IStockListLoader
{
    private readonly string[] _stocks;
    public IEnumerable<string> StockList { get => _stocks; }

    public StockListLoader()
    {
        var data = File.ReadAllLines("stocks.txt");

        _stocks = data.ToArray();

    }


}
