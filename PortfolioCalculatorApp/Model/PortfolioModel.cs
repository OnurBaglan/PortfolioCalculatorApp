

namespace PortfolioCalculatorApp.Model;

public class PortfolioModel
{
    public string Name { get; set; }
    public List<PurchaseModel> Purchases { get; set; }

    public decimal? PortfolioCost {  get; set; }

    public override string ToString()
    {
       return $"{Name} named portfolio, with {Purchases.Count} purchases";
    }
}
