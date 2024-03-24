
using PortfolioCalculatorApp.Views.Interfaces;


namespace PortfolioCalculatorApp;

public partial class MainAppForm : Form, IApiKeyTabView
{
	AddPortfolioForm addPortfolioForm;
	private readonly ApiKeyTabController _apiKeyTabController;

	public event EventHandler ValidateApiKey1;

	public MainAppForm()
	{
		InitializeComponent();
		_apiKeyTabController = new ApiKeyTabController(this, new ApiKeyValidatorModel());


	}

	public string ApiKey1
	{
		get => TextBox_APIKey1.Text;
		set => TextBox_APIKey1.Text = value;
	}

	public string ApiKey2
	{
		get => TextBox_APIKey2.Text;
		set => TextBox_APIKey2.Text = value;
	}

	public bool IsApiKey1Valid { get; set; }
	public bool IsApiKey2Valid { get; set; }

	public string ApiKey1Status
	{
		get => Label_APIKey1Status.Text;
		set => Label_APIKey1Status.Text = value;

	}
	public string ApiKey2Status
	{
		get => Label_APIKey2Status.Text;
		set => Label_APIKey2Status.Text = value;

	}

	private async void Button_APIKeyValidate1_Click(object sender, EventArgs e)
	{
		var apiSource = ApiSources.MarketDataApp;

		IsApiKey1Valid = await _apiKeyTabController.OnValidate(apiSource);

		_apiKeyTabController.OnKeyStatusUpdate();
	}

	private async void Button_APIKeyValidate2_Click(object sender, EventArgs e)
	{
		var apiSource = ApiSources.CurrencyBeacon;

		IsApiKey2Valid = await _apiKeyTabController.OnValidate(apiSource);
	}
}
