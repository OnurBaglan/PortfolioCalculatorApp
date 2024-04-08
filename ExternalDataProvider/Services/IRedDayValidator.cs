namespace ExternalDataProvider.Services
{
    public interface IRedDayValidator
    {

        Task<bool> IsRedDay(DateTime date);
    }
}