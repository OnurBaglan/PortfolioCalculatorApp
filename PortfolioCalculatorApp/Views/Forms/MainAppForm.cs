

using PortfolioCalculatorApp.Controller;
using PortfolioCalculatorApp.Model.BusinessModel;
using PortfolioCalculatorApp.Model.DTO;
using PortfolioCalculatorApp.Views.Interfaces;


namespace PortfolioCalculatorApp;

public partial class MainAppForm : Form, IMainAppFormView
{

    private MainAppFormController _mainAppFormController;
    private AddPortfolioFormController _addPortfolioFormController;
    private readonly IAddPortfolioFormView _addPortfolioFormView;

    public event EventHandler ValidateApiKey;
    public event EventHandler SaveApiKey;
    public event EventHandler LoadApiKeys;
    public event EventHandler<List<Portfolio>> SavePortfolios;


    public MainAppForm(IAddPortfolioFormView addPortfolioFormView)
    {
        _addPortfolioFormView = addPortfolioFormView;


        InitializeComponent();

        //todo: there needs to be a better way to 'initialize services'
        //initialize api keys is all over the place (half the job done by controller and the other is by view)
        InitializeApiKeys();

        InitializeControllers();

        



    }

    private void InitializeControllers()
    {
        _mainAppFormController = new MainAppFormController(this, _addPortfolioFormView);
        _addPortfolioFormController = new AddPortfolioFormController(_addPortfolioFormView);
    }

    private void InitializeApiKeys()
    {
        LoadApiKeys?.Invoke(this, EventArgs.Empty);
        ValidateApiKeys();
    }

    private void ValidateApiKeys()
    {
        Button_ValidateApiKey_Click(Button_ValidateApiKey1, EventArgs.Empty);
        Button_ValidateApiKey_Click(Button_ValidateApiKey2, EventArgs.Empty);
    }

    public string ApiKey1 { get => TextBox_ApiKey1.Text; set => TextBox_ApiKey1.Text = value; }
    public string ApiKey2 { get => TextBox_ApiKey2.Text; set => TextBox_ApiKey2.Text = value; }
    public bool IsApiKey1Valid { get; set; }
    public bool IsApiKey2Valid { get; set; }
    public string ApiKey1Status { get => Label_StatusApiKey1.Text; set => Label_StatusApiKey1.Text = value; }
    public string ApiKey2Status { get => Label_StatusApiKey2.Text; set => Label_StatusApiKey2.Text = value; }
    public string ApiKeyStatusStrip { get => ToolStripStatusLabel_ApiKey.Text; set => ToolStripStatusLabel_ApiKey.Text = value; }
    public string MainMenuStatusStrip { get => ToolStripStatusLabel_MainMenu.Text; set => ToolStripStatusLabel_MainMenu.Text = value; }
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
        ShowAddPortfolioView();
    }


    private void Button_DeleteSelectedPortfolio_Click(object sender, EventArgs e)
    {

        var itemToDelete = ListBoxPortfolios.SelectedItem;

        if (itemToDelete == null) return;

        ListBoxPortfolios.Items.Remove(itemToDelete);


    }

    private void ShowAddPortfolioView()
    {
        _addPortfolioFormView.ShowDialogWrapper();
    }

    private void Button_SavePortfolios_Click(object sender, EventArgs e)
    {
        List<Portfolio> portfoliosToSave = new();

        foreach(var item in ListBox_Portfolios.Items)
        {
            portfoliosToSave.Add((Portfolio)item);
        }

        if(portfoliosToSave.Count==0) { return; }

        SavePortfolios?.Invoke(this, portfoliosToSave);

    }
}
