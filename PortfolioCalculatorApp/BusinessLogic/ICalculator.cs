﻿using PortfolioCalculatorApp.Model.DTO;

public interface ICalculator
{
    Task<decimal> CalculatePortfolioCost(PortfolioModel portfolio, string currency);
    Task<decimal> CalculatePortfolioEarnLoss(PortfolioModel portfolio, string currency);
    Task<decimal> CalculatePortfoliWorthToday(PortfolioModel portfolio, string currency);
    Task<decimal> CalculatePurchaseCost(Purchase purchase, string currency);
}