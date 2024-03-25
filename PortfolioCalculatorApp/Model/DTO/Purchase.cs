using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioCalculatorApp.Model.DTO
{
    class Purchase
    {
        public string StockSymbol { get; set; }

        public int Lots { get; set; }

        public DateTime PurchaseDate { get; set; }

        public string CurrencySymbol { get; set; }

        public decimal PurchaseCost { get; set; }

    }
}
