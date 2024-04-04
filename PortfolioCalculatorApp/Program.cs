using ExternalDataProvider;
using ExternalDataProvider.API;
using PortfolioCalculatorApp.BusinessLogic;
using PortfolioCalculatorApp.BusinessLogic.ModelAnalyzer;
using PortfolioCalculatorApp.BusinessModel;
using PortfolioCalculatorApp.BusinessModel.API;
using PortfolioCalculatorApp.Controller;



namespace PortfolioCalculatorApp;


internal static class Program
{
	/// <summary>
	///  The main entry point for the application.
	/// </summary>
	[STAThread]
	static void Main()
	{


		
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

			MainAppForm mainAppForm = new MainAppForm();
			AddPortfolioForm addPortfolioForm = new AddPortfolioForm();
			IApiValidator apiValidator = new ApiValidator();
			RedDayValidator redDayValidator = new RedDayValidator(new ApiReader());
			ICalculator calculator = new Calculator(new CurrencyConverter(), new StockValueProvider(), redDayValidator);
			IStockListLoader stockListLoader = new StockListLoader();
			ModelAnalyzer modelAnalyzer = new ModelAnalyzer(redDayValidator);

			AddPortfolioFormController addPortfolioFormController = new AddPortfolioFormController(addPortfolioForm, stockListLoader, modelAnalyzer);
			MainAppFormController mainAppFormController = new MainAppFormController(mainAppForm, addPortfolioForm, apiValidator, calculator);

			Application.Run(mainAppForm);







	}
}