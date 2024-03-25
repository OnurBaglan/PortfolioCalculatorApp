

using PortfolioCalculatorApp.Controller;
using PortfolioCalculatorApp.Model.BusinessModel;
using PortfolioCalculatorApp.Views.Interfaces;


namespace PortfolioCalculatorApp;

public partial class MainAppForm : Form, IMainAppFormView
{

    private readonly MainAppFormController _mainAppFormController;
    private readonly AddPortfolioFormController _addPortfolioFormController;
    private readonly IAddPortfolioFormView _addPortfolioForm;

    public event EventHandler ValidateApiKey;
    public event EventHandler SaveApiKey;
    public event EventHandler LoadApiKeys;


    public MainAppForm(IAddPortfolioFormView addPortfolioForm)
    {
        InitializeComponent();


        //Todo: this section is painfully awful, even though it works. Think of better way.
        LoadApiKeys?.Invoke(this, EventArgs.Empty);
        Button_ValidateApiKey_Click(Button_ValidateApiKey1, EventArgs.Empty);
        Button_ValidateApiKey_Click(Button_ValidateApiKey2, EventArgs.Empty);



        _addPortfolioForm = addPortfolioForm;
        _mainAppFormController = new MainAppFormController(this,_addPortfolioForm);
        _addPortfolioFormController = new AddPortfolioFormController(_addPortfolioForm);
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

    
    public ListBox ListBoxPortfolios { get => ListBox_Portfolios; set => ListBox_Portfolios = value; }
    public Button ButtonAddNewPortfolio { get => Button_AddNewPortfolio; set => Button_AddNewPortfolio = value; }
    public Button ButtonDeleteSelectedPortfolio { get => Button_DeleteSelectedPortfolio; set => Button_DeleteSelectedPortfolio = value; }

    private void Button_ValidateApiKey_Click(object sender, EventArgs e)
    {

        ValidateApiKey?.Invoke(sender, e);

    }

    private void Button_SaveApiKey_Click(object sender, EventArgs e)
    {
        SaveApiKey?.Invoke(sender, e);
    }

    private void Button_AddNewPortfolio_Click(object sender, EventArgs e)
    {
        _addPortfolioForm.ShowDialogWrapper();
    }
}
