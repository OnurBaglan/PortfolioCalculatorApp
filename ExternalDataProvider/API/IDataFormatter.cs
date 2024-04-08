namespace ExternalDataProvider.API
{
    public interface IDataFormatter
    {
       
        string GetValueFromCsvString(string response);
        bool IsRedDay(string response, string dateInFormat);
    }
}