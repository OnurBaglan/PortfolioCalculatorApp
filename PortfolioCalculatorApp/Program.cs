using ExternalDataProvider;
using PortfolioCalculatorApp.BusinessLogic;
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
		ICalculator calculator = new Calculator(new CurrencyConverter(), new StockValueProvider());
		IStockListLoader stockListLoader = new StockListLoader();

		AddPortfolioFormController addPortfolioFormController = new AddPortfolioFormController(addPortfolioForm, stockListLoader);
		MainAppFormController mainAppFormController = new MainAppFormController(mainAppForm, addPortfolioForm, apiValidator, calculator);

		Application.Run(mainAppForm);


		

		
	}
}