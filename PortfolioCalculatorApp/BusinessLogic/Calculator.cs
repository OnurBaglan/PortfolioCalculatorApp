using ExternalDataProvider;
using PortfolioCalculatorApp.Model.DTO;

namespace PortfolioCalculatorApp.BusinessLogic;

public class Calculator : ICalculator
{

	private readonly ICurrencyConverter _currencyConverter;
	private readonly IStockValueProvider _stockValueProvider;

	public Calculator(ICurrencyConverter currencyConverter, IStockValueProvider stockValueProvider)
	{

		_currencyConverter = currencyConverter;
		_stockValueProvider = stockValueProvider;
	}

	public async Task<decimal> CalculatePurchaseCost(Purchase purchase, string currency)
	{
		var stockSymbol = purchase.StockSymbol;
		var date = purchase.PurchaseDate;
		var costInUsd = await _stockValueProvider.Get(stockSymbol, date);


		if (currency == "USD")
		{
			return costInUsd;
		}

		if (currency == "GOLD")
		{
			return await _currencyConverter.GetUsdToGramGold(costInUsd, date);
		}
		return await _currencyConverter.GetUsdToCurrency(costInUsd, currency, date);
	}



	public async Task<decimal> CalculatePortfolioCost(PortfolioModel portfolio, string currency)
	{

		var totalCost = default(decimal);

		foreach (var purchase in portfolio.Purchases)
		{

			totalCost += await CalculatePurchaseCost(purchase, currency);
		}

		return totalCost;
	}

	public async Task<decimal> CalculatePortfoliWorthToday(PortfolioModel portfolio, string currency)
	{


		var worthToday = default(decimal);


		foreach (var purchase in portfolio.Purchases)
		{

			var value = await _stockValueProvider.Get(purchase.StockSymbol, SelectClosestWeekdayToNow(DateTime.Now)) * purchase.Lots;
			worthToday += value;
		}

		if (currency == "USD")
		{
			return worthToday;
		}

		if (currency == "GOLD")
		{
			return await _currencyConverter.GetUsdToGramGold(worthToday, SelectClosestWeekdayToNow(DateTime.Now));
		}

		return await _currencyConverter.GetUsdToCurrency(worthToday, currency, SelectClosestWeekdayToNow(DateTime.Now));


	}

	private DateTime SelectClosestWeekdayToNow(DateTime now)
	{
		if (now.DayOfWeek == DayOfWeek.Saturday)
		{
			var result = new DateTime(now.Year, now.Month, now.Day - 1);
			return result;
		}

		if (now.DayOfWeek == DayOfWeek.Sunday)
		{
			var result = new DateTime(now.Year, now.Month, now.Day - 2);
			return result;
		}

		return now;


	}

	public async Task<decimal> CalculatePortfolioEarnLoss(PortfolioModel portfolio, string currency)
	{
		var cost = await CalculatePortfolioCost(portfolio, currency);

		var worth = await CalculatePortfoliWorthToday(portfolio, currency);

		return worth / cost - 1;


	}



}