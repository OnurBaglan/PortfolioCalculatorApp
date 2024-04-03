using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioCalculatorApp.BusinessLogic.ModelAnalyzer
{
    public class PurchaseAnalyzeResult
    {
        public bool IsModelValid { get; }

        private readonly IEnumerable<string> _errors;

        public PurchaseAnalyzeResult(bool isModelValid, IEnumerable<string> errors)
        {
            IsModelValid = isModelValid;
            _errors = errors;
        }

        public void ShowErrors()
        {

            StringBuilder sb = new StringBuilder();
            foreach (string error in _errors)
            {
                sb.AppendLine(error);
            }

            MessageBox.Show(sb.ToString());


        }
    }
}
