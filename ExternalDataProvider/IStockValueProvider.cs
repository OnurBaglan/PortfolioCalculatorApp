
namespace ExternalDataProvider
{
    public interface IStockValueProvider
    {
        Task<decimal> Get(string stockSymbol, DateTime date);
    }
}