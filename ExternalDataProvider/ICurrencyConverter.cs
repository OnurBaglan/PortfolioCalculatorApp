
namespace ExternalDataProvider
{
    public interface ICurrencyConverter
    {
        Task<decimal> GetUsdToCurrency(decimal usdAmount, string currencySymbol, DateTime date);
        Task<decimal> GetUsdToGramGold(decimal usdAmount, DateTime date);
    }
}