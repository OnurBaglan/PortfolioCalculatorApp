using PortfolioCalculatorApp.Model.BusinessModel.API;
using PortfolioCalculatorApp.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calculator
{

    private readonly ApiReader _apiReader;

    public Calculator(ApiReader apiReader)
    {
        _apiReader = apiReader;
    }

    public async Task<decimal> CalculatePurchaseCost(Purchase purchase, string currency)
    {
        var rawValue = await _apiReader.GetStockValue(purchase.StockSymbol, purchase.PurchaseDate) * purchase.Lots;


        if(currency == "USD")
        {
            return rawValue;
        }
        return await _apiReader.ConvertTo(currency, rawValue, purchase.PurchaseDate);
    }

   

    public async Task<decimal> CalculatePortfolioCost(Portfolio portfolio, string currency)
    {
       
        var totalCost = default(decimal);

        foreach(var purchase in portfolio.Purchases)
        {
            
            totalCost += await CalculatePurchaseCost(purchase, currency);
        }

        return totalCost;
    }

    public async Task<decimal> CalculatePortfoliWorthToday(Portfolio portfolio, string currency) 
    {
        var worthToday = default(decimal);


        foreach (var purchase in portfolio.Purchases)
        {

            var value = await _apiReader.GetStockValue(purchase.StockSymbol,DateTime.Now) * purchase.Lots;
            worthToday += value;
        }

        if (currency == "USD")
        {
            return worthToday;
        }

        return await _apiReader.ConvertTo(currency, worthToday, DateTime.Now);


    }

    public async Task<decimal> CalculatePortfolioEarnLoss(Portfolio portfolio, string currency)
    {
       var cost = await CalculatePortfolioCost(portfolio, currency);

        var worth = await CalculatePortfoliWorthToday(portfolio, currency);

        return (worth / cost) - 1;


    }



}


