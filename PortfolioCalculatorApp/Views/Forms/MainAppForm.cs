

using PortfolioCalculatorApp.EventArguments;
using PortfolioCalculatorApp.Views.Interfaces;


namespace PortfolioCalculatorApp;

public partial class MainAppForm : Form, IApiKeyTabView
{

	private readonly ApiKeyTabController _apiKeyTabController;

	public event EventHandler<ValidateApiEventArgs> ValidateApiKey;

	public MainAppForm()
	{
		InitializeComponent();
		_apiKeyTabController = new ApiKeyTabController(this, new ApiKeyValidatorModel());


	}

	public string ApiKey1
	{
		get => TextBox_ApiKey1.Text;
		set => TextBox_ApiKey1.Text = value;
	}
	public string ApiKey2
	{
		get => TextBox_ApiKey2.Text;
		set => TextBox_ApiKey2.Text = value;
	}
	public bool IsApiKey1Valid { get; set; }
	public bool IsApiKey2Valid { get; set; }
	public string ApiKey1Status
	{
		get => Label_StatusApiKey1.Text;
		set => Label_StatusApiKey1.Text = value;

	}
	public string ApiKey2Status
	{
		get => Label_StatusApiKey2.Text;
		set => Label_StatusApiKey2.Text = value;

	}

	private void Button_ValidateApiKey_Click(object sender, EventArgs e)
	{
		int apiSourceId = int.Parse(((string)sender.GetType().GetProperty("Name").GetValue(sender)).Last().ToString());

		ValidateApiKey?.Invoke(this, new ValidateApiEventArgs(apiSourceId));

	}
}
