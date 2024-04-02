using PortfolioCalculatorApp.Model.DTO;

public interface ICalculator
{
    Task<decimal> CalculatePortfolioCost(Portfolio portfolio, string currency);
    Task<decimal> CalculatePortfolioEarnLoss(Portfolio portfolio, string currency);
    Task<decimal> CalculatePortfoliWorthToday(Portfolio portfolio, string currency);
    Task<decimal> CalculatePurchaseCost(Purchase purchase, string currency);
}