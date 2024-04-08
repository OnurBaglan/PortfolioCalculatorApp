
using Csv;

await DownloadCsv();

Console.ReadKey();




//var value = ReadStockValue("AMZN", new DateTime(2022, 01, 16));

//decimal ReadStockValue(string stockSymbol, DateTime date)
//{
//    DownloadCsv(stockSymbol,date);

//    var value= ReturnValueInFile(stockSymbol,date);

//    return value;
//}

async Task DownloadCsv(/*string stockSymbol, DateTime date*/)
{
    var client = new HttpClient();

    var response = await client.GetStringAsync("https://query1.finance.yahoo.com/v7/finance/download/AMZN?period1=1712102400&period2=1712534400&interval=1d&events=history&includeAdjustedClose=true");

    var lines = response.Split("\n").ToList();

    lines.RemoveAt(0);

    var valuePairs = new Dictionary<string, string>();

    foreach (var line in lines)
    {
        var cells = line.Split(",");

        valuePairs.Add(cells[0], cells[4]); 
    }

    var result = valuePairs.OrderByDescending(pair => pair.Key).ToList().First().Value;


}