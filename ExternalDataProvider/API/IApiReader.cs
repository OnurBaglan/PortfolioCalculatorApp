
namespace ExternalDataProvider.API
{
    public interface IApiReader
    {
        Task<bool> ReadDayMarketStatus(IApiGetRequest request);
        Task<string> ReadData(IApiGetRequest request);
    }
}