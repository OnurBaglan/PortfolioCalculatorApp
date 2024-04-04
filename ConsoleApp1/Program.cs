

using System.Text;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

var response =await new HttpClient().GetAsync("https://api.currencybeacon.com/v1/currencies?type=fiat&api_key=vRe7MFHO3Akk2CAOEqo87Qx5tElGAbXn");

var jsonData = await response.Content.ReadAsStringAsync();


JsonDocument jsonDoc = JsonDocument.Parse(jsonData);

JsonElement root = jsonDoc.RootElement;


JsonElement element = root
    .GetProperty("response");
var thing = element.GetRawText();

var result = JsonSerializer.Deserialize<List<Root>>(thing);

StringBuilder sb = new StringBuilder(); 

foreach(var item in result)
{
    sb.AppendLine($"{item.short_code}----{item.name}");
}

File.WriteAllText("currencies.txt",sb.ToString());

Console.ReadKey();







public class Root
{
    public int id { get; set; }
    public string name { get; set; }
    public string short_code { get; set; }
    public string code { get; set; }
    public int precision { get; set; }
    public int subunit { get; set; }
    public string symbol { get; set; }
    public bool symbol_first { get; set; }
    public string decimal_mark { get; set; }
    public string thousands_separator { get; set; }
}

