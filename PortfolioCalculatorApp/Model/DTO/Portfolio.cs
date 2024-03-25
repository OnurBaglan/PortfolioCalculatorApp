

namespace PortfolioCalculatorApp.Model.DTO;

public class Portfolio
{
    public string Name { get; set; }
    public List<Purchase> Purchases { get; set; }

    public decimal? PortfolioCost {  get; set; }

    public void CalculatePortfolioCost()
    {

    }

    public override string ToString()
    {
       return $"{Name} named portfolio, with {Purchases.Count} purchases";
    }
}
