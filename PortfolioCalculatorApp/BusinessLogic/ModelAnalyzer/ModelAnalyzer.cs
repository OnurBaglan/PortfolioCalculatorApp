using ExternalDataProvider;
using PortfolioCalculatorApp.Model;
using PortfolioCalculatorApp.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioCalculatorApp.BusinessLogic.ModelAnalyzer
{
	public class ModelAnalyzer
	{
		private readonly IRedDayValidator _redDayValidator;

		public ModelAnalyzer(IRedDayValidator redDayValidator)
		{
			_redDayValidator = redDayValidator;
		}

		public async Task<PurchaseAnalyzeResult> Analyze(PurchaseModel purchaseModel)
		{
			var isPurchaseValid =
				!string.IsNullOrEmpty(purchaseModel.StockName)&&
				purchaseModel.Lots != 0 &&
				IsWeekday(purchaseModel.PurchaseDate) &&
				!await IsRedDay(purchaseModel.PurchaseDate) &&
				purchaseModel.PurchaseDate<=DateTime.Now;

			var errors = new List<string>();

			if (!isPurchaseValid)
			{
				if (string.IsNullOrEmpty(purchaseModel.StockName))
				{
					errors.Add("-Please select a stock symbol");
				}
				if (purchaseModel.Lots <= 0)
				{
					errors.Add("-Please select at least one lot");

				}
				if (!IsWeekday(purchaseModel.PurchaseDate))
				{
					errors.Add("-Please make sure you selected a week day");

				}
				if (await IsRedDay(purchaseModel.PurchaseDate) && IsWeekday(purchaseModel.PurchaseDate))
				{
					errors.Add("-Please make sure you did not selected a red day");

				}
				if(purchaseModel.PurchaseDate > DateTime.Now)
				{
					errors.Add("-You cannot select a date from future");

				}
			}

			var resultObject = new PurchaseAnalyzeResult(isPurchaseValid, errors);
			return resultObject;


		}

		private async Task<bool> IsRedDay(DateTime purchaseDate)
		{
			var result = await _redDayValidator.IsRedDay(purchaseDate);
			return result;
		}

		private bool IsWeekday(DateTime purchaseDate)
		{
			return
				purchaseDate.DayOfWeek != DayOfWeek.Sunday &&
				purchaseDate.DayOfWeek != DayOfWeek.Saturday;

		}
	}
}
