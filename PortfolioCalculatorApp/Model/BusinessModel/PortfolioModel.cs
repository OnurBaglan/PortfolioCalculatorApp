namespace PortfolioCalculatorApp.Model.BusinessModel;


internal class PortfolioModel
{
    private readonly string[] _stocks;
    public IEnumerable<string> StockList { get => _stocks; }

    public PortfolioModel()
    {
        var data = File.ReadAllLines("stocks.txt");

        _stocks = data.ToArray();
        
    }





}
