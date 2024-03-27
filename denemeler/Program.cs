





var data = await Read();



Console.ReadKey();






async Task<string> Read()
{
    using HttpClient client = new HttpClient();
    {
        var data = await client.GetAsync("https://api.currencybeacon.com/v1/historical?base=USD&date=2020-01-01&symbols=TRY&api_key=vRe7MFHO3Akk2CAOEqo87Qx5tElGAbXn");

        data.EnsureSuccessStatusCode();

        var info = await data.Content.ReadAsStringAsync();

        return info;


    }
}