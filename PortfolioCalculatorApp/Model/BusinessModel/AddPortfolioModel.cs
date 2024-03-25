namespace PortfolioCalculatorApp.Model.BusinessModel;


internal class AddPortfolioModel
{
    private readonly string[] _stocks;
    public IEnumerable<string> StockList { get => _stocks; }

    public AddPortfolioModel()
    {
        var data = File.ReadAllLines("stocks.txt");

        _stocks = data.ToArray();
        
    }





}
