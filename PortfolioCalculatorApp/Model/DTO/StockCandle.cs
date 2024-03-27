
namespace PortfolioCalculatorApp.Model.DTO;

public class StockCandle
{
    public string s { get; set; }
    public List<int> t { get; set; }
    public List<double> o { get; set; }
    public List<double> h { get; set; }
    public List<double> l { get; set; }
    public List<double> c { get; set; }
    public List<int> v { get; set; }
}
