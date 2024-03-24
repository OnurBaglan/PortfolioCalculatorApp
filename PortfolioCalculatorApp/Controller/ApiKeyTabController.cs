using PortfolioCalculatorApp.Views.Interfaces;

public class ApiKeyTabController
{
	private readonly IApiKeyTabView _view;
	private readonly ApiKeyValidatorModel _model;

	public ApiKeyTabController(IApiKeyTabView view, ApiKeyValidatorModel model)
	{
		_view = view;
		_model = model;
	}

	public async Task<bool> OnValidate(ApiSources apiSource)
	{
		return await _model.IsKeyValid(_view.ApiKey1, apiSource);
	}

	internal void OnKeyStatusUpdate()
	{
		
	}
}