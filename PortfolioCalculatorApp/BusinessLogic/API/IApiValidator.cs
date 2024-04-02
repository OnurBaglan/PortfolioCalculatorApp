namespace PortfolioCalculatorApp.BusinessModel.API
{
    public interface IApiValidator
    {
        Task<bool> IsApiKeyValid(string apiKey, ApiSources apiSource);
        string? LoadApiKey(ApiSources apiSource);
        void SaveApiKey(string apiKey, ApiSources apiSource);
    }
}