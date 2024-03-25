using PortfolioCalculatorApp.Views.Interfaces;

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


        IAddPortfolioView addPortfolioForm  = new AddPortfolioForm();




		Application.Run(new MainAppForm(addPortfolioForm));
	}
}