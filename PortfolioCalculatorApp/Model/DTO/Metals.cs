using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioCalculatorApp.Model.DTO
{
    public class _20230101
    {
        public Currencies currencies { get; set; }
        public string date { get; set; }
        public Metals metals { get; set; }
    }

    public class Currencies
    {
        public double AUD { get; set; }
        public double BRL { get; set; }
        public double CAD { get; set; }
        public double CHF { get; set; }
        public double CNY { get; set; }
        public double EUR { get; set; }
        public double GBP { get; set; }
        public double HKD { get; set; }
        public double INR { get; set; }
        public double JPY { get; set; }
        public double SGD { get; set; }
        public int USD { get; set; }
    }

    public class Metals
    {
        public double gold { get; set; }
        public double palladium { get; set; }
        public double platinum { get; set; }
        public double silver { get; set; }
    }

    public class Rates2
    {
        public Dictionary<string, _20230101> RatesByDate { get; set; }
    }

    public class Root2
    {
        public string status { get; set; }
        public string currency { get; set; }
        public string unit { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public Rates2 rates { get; set; }
    }
}
