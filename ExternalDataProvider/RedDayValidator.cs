﻿

using ExternalDataProvider.API;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.Json;
using ExternalDataProvider.DTO;

namespace ExternalDataProvider;

public class RedDayValidator : IRedDayValidator
{
    private readonly IApiReader _apiReader;

    public RedDayValidator(IApiReader apiReader)
    {
        _apiReader = apiReader;
    }
    public async Task<bool> IsRedDay(DateTime date)
    {
        var request = new ApiGetRequest(QueryType.QuoteStock, date, null, null);

        var rawResult = await _apiReader.ReadDayMarketStatus(request);

        //this can be an extension method
        var result = ExtractBoolFromRawResult(rawResult);   

        return result;
    }

    private bool ExtractBoolFromRawResult(string rawResult)
    {
      
        RedDayStatusDTO statusObject = JsonSerializer.Deserialize<RedDayStatusDTO>(rawResult);

        var resultText = statusObject.status.First();

        return resultText == "closed";

    }

    }
