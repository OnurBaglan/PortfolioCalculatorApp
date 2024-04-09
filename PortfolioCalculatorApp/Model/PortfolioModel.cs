


namespace PortfolioCalculatorApp.Model;

public class PortfolioModel
{
    public string Name { get; set; }
    public List<PurchaseModel> Purchases { get; set; }

	public PortfolioModel(string name, List<PurchaseModel> purchases)
	{
		Name = name;
		Purchases = purchases;
	}


	public override string ToString()
    {
       return $"Portfolio name: {Name}, total transactions: {Purchases.Count}, total lot amount: {GetLotAmount()} ";
    }

	private string GetLotAmount()
	{
		var result = Purchases.Select(purchase=>purchase.Lots).Sum().ToString();
		return result;
	}
}
