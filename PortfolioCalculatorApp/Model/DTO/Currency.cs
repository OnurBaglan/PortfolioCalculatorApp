using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioCalculatorApp.Model.DTO;

public class Meta
{
    public int code { get; set; }
    public string disclaimer { get; set; }
}

public class Rates
{
    public double TRY { get; set; }
}

public class Response
{
    public string date { get; set; }
    public string @base { get; set; }
    public Rates rates { get; set; }
}

public class Currency
{
    public Meta meta { get; set; }
    public Response response { get; set; }
    public string date { get; set; }
    public string @base { get; set; }
    public Rates rates { get; set; }
}
