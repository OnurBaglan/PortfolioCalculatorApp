


var portfolio = new PortfolioModel("onur", new List<PurchaseModel>()
{
	new PurchaseModel("a",29,DateTime.Now),
	new PurchaseModel("a",29,DateTime.Now),
	new PurchaseModel("a",29,DateTime.Now),
	new PurchaseModel("a",29,DateTime.Now)
});

Console.WriteLine(portfolio.ToString());

Console.ReadKey();




public class PurchaseModel
{
	private readonly string _rawStockSymbol;
	public string StockSymbol { get; set; }
	public string StockName { get; set; }
	public int Lots { get; set; }
	public DateTime PurchaseDate { get; set; }


	public PurchaseModel(string rawStockSymbol, int lots, DateTime purchaseDate)
	{
		_rawStockSymbol = rawStockSymbol;
		Lots = lots;
		PurchaseDate = purchaseDate;

		StockSymbol = GetStockSymbol(_rawStockSymbol);
		StockName = GetStockName(_rawStockSymbol);
	}

	public PurchaseModel()
	{

	}

	private string GetStockName(string rawStockSymbol)
	{
		var result = rawStockSymbol.Split("----").Last();
		return result;
	}

	private string GetStockSymbol(string rawStockSymbol)
	{
		var result = rawStockSymbol.Split("----").First();
		return result;
	}
}

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
		return $"Portfolio name: {Name}, total transaction counts: {Purchases.Count}, total lot amount: {GetLotAmount()} ";
	}

	private string GetLotAmount()
	{
		var result = Purchases.Select(purchase => purchase.Lots).Sum().ToString();
		return result;
	}
}