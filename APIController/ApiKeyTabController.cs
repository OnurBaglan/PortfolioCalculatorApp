using APIKeyOperations;
using PortfolioCalculatorApp.Views;

namespace Controller.APIController;

public class ApiKeyTabController
{
	private readonly IApiKeyTabView _view;
	private readonly ApiKeyValidator _model;

	public ApiKeyTabController(IApiKeyTabView view, ApiKeyValidator model)
	{
		_view = view;
		_model = model;
	}



}