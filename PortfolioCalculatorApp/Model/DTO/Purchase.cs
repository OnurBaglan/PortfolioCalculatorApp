namespace PortfolioCalculatorApp.Model.DTO;

public class Purchase
{
    public string StockSymbol { get; set; }

    public int Lots { get; set; }

    public DateTime PurchaseDate { get; set; }

    public decimal? PurchaseCost { get; set; }

    public override string ToString()
    {
        return $"Stock symbol: {StockSymbol}, {Lots} lots, bought on {PurchaseDate.ToString("d")} ";
    }

}
