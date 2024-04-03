

namespace ExternalDataProvider
{
    public interface IRedDayValidator
    {
      
        Task<bool> IsRedDay(DateTime date);
    }
}