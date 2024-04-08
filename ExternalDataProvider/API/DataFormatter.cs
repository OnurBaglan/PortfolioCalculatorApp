namespace ExternalDataProvider.API;

public class DataFormatter : IDataFormatter
{
    public string GetValueFromCsvString(string response)
    {

        var lines = response.Split("\n").ToList();

        lines.RemoveAt(0);

        var valuePairs = new Dictionary<string, string>();

        foreach (var line in lines)
        {
            var cells = line.Split(",");

            valuePairs.Add(cells[0], cells[4]);
        }

        var result = valuePairs.OrderByDescending(pair => pair.Key).ToList().First().Value;

        return result;
    }

    public bool IsRedDay(string response, string dateInFormat)
    {
        var lines = response.Split("\n").ToList();

        lines.RemoveAt(0);

        var valuePairs = new Dictionary<string, string>();

        foreach (var line in lines)
        {
            var cells = line.Split(",");

            valuePairs.Add(cells[0], cells[4]);
        }

        return valuePairs.OrderByDescending(pair => pair.Key).ToList().First().Key == dateInFormat ? true : false;

       
    }
}