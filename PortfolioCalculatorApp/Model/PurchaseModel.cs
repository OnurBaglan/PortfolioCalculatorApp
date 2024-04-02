using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioCalculatorApp.Model;

public class PurchaseModel
{
	private readonly string _rawStockSymbol;
	public string StockSymbol { get; }
	public string StockName { get; }
	public int Lots { get; }
	public DateTime PurchaseDate { get; }


	public PurchaseModel(string rawStockSymbol, int lots, DateTime purchaseDate)
	{
		_rawStockSymbol = rawStockSymbol;
		Lots = lots;
		PurchaseDate = purchaseDate;

		StockSymbol = GetStockSymbol(_rawStockSymbol);
		StockName = GetStockName(_rawStockSymbol);
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
