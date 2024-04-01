using ExternalDataProvider;
using PortfolioCalculatorApp.Controller;
using PortfolioCalculatorApp.Model.BusinessModel.API;
using PortfolioCalculatorApp.Views.Interfaces;
using System.Text.Json.Nodes;

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

		AddPortfolioFormController addPortfolioFormController = new AddPortfolioFormController(addPortfolioForm);
		MainAppFormController mainAppFormController = new MainAppFormController(mainAppForm, addPortfolioForm, apiValidator, calculator);

		Application.Run(mainAppForm);


		

		
	}
}