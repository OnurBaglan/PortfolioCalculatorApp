

using PortfolioCalculatorApp.EventArguments;
using PortfolioCalculatorApp.Views.Interfaces;


namespace PortfolioCalculatorApp;

public partial class MainAppForm : Form, IApiKeyTabView
{

	private readonly ApiKeyTabController _apiKeyTabController;

	public event EventHandler ValidateApiKey;

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
	public string ApiKeyStatusStrip
	{
		get => ToolStripStatusLabel_ApiKey.Text;

		set => ToolStripStatusLabel_ApiKey.Text = value;
	}
	public string MainMenuStatusStrip
	{
		get => ToolStripStatusLabel_MainMenu.Text;

		set => ToolStripStatusLabel_MainMenu.Text = value;
	}

	public Label MainMenuBlockerLabel { get => MainMenuBlockLabel; set => MainMenuBlockLabel = value; }

	public Panel MainMenuBlockerPanel { get => MainMenuBlockPanel; set => MainMenuBlockPanel = value; }


	private void Button_ValidateApiKey_Click(object sender, EventArgs e)
	{

		ValidateApiKey?.Invoke(sender, e);

	}
}
