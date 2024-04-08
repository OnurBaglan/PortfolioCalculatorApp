
namespace ExternalDataProvider.API
{
    public interface IApiReader
    {
        Task<string> ReadDayMarketStatus(IApiGetRequest request);
        Task<string> ReadRawData(IApiGetRequest request);
    }
}