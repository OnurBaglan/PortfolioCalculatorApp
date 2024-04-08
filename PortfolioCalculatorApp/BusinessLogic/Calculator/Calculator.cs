using ExternalDataProvider.Services;
using PortfolioCalculatorApp.Misc;
using PortfolioCalculatorApp.Model;
using PortfolioCalculatorApp.Model.DTO;

namespace PortfolioCalculatorApp.BusinessLogic.Calculator;

public class Calculator : ICalculator
{

    private readonly ICurrencyConverter _currencyConverter;
    private readonly IStockValueProvider _stockValueProvider;
    private readonly IRedDayValidator _redDayValidator;

    public Calculator(ICurrencyConverter currencyConverter, IStockValueProvider stockValueProvider, IRedDayValidator redDayValidator)
    {

        _currencyConverter = currencyConverter;
        _stockValueProvider = stockValueProvider;
        _redDayValidator = redDayValidator;
    }

    public async Task<decimal> CalculatePurchaseCost(PurchaseModel purchase, string currency)
    {
        var stockSymbol = purchase.StockSymbol;
        var date = purchase.PurchaseDate;
        var costInUsd = await _stockValueProvider.Get(stockSymbol, date) * purchase.Lots;


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

    public async Task<decimal> CalculatePortfolioWorthToday(PortfolioModel portfolio, string currency)
    {


        var worthToday = default(decimal);


        foreach (var purchase in portfolio.Purchases)
        {

            var value = await _stockValueProvider.Get(purchase.StockSymbol, await SelectClosestNonRedWeekdayToNow(DateTime.Now)) * purchase.Lots;
            worthToday += value;
        }

        if (currency == "USD")
        {
            return worthToday;
        }

        if (currency == "GOLD")
        {
            return await _currencyConverter.GetUsdToGramGold(worthToday, await SelectClosestNonRedWeekdayToNow(DateTime.Now));
        }

        return await _currencyConverter.GetUsdToCurrency(worthToday, currency, await SelectClosestNonRedWeekdayToNow(DateTime.Now));


    }

    private async Task<DateTime> SelectClosestNonRedWeekdayToNow(DateTime now)
    {
        DateTime result = now;

        while (!now.IsWeekday() || await IsRedDay(now))
        {
            result.AddDays(-1);
        }

        return result;


    }

    private async Task<bool> IsRedDay(DateTime now)
    {
        return await _redDayValidator.IsRedDay(now);
    }

    public async Task<decimal> CalculatePortfolioEarnLoss(PortfolioModel portfolio, string currency)
    {
        var cost = await CalculatePortfolioCost(portfolio, currency);

        var worth = await CalculatePortfolioWorthToday(portfolio, currency);

        return (worth / cost - 1) * 100;

    }

}