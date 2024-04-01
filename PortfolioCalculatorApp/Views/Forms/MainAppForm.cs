

using PortfolioCalculatorApp.Controller;
using PortfolioCalculatorApp.Model.DTO;
using PortfolioCalculatorApp.Model.BusinessModel;
using PortfolioCalculatorApp.Views.Interfaces;
using System.Security.Policy;
using System.Text.Json;
using System.Data;


namespace PortfolioCalculatorApp;

public partial class MainAppForm : Form, IMainAppFormView
{
    public string ApiKey1 { get => TextBox_ApiKey1.Text; set => TextBox_ApiKey1.Text = value; }
    public string ApiKey2 { get => TextBox_ApiKey2.Text; set => TextBox_ApiKey2.Text = value; }
    public string ApiKey3 { get => TextBox_ApiKey3.Text; set => TextBox_ApiKey3.Text = value; }
    public bool IsApiKey1Valid { get; set; }
    public bool IsApiKey2Valid { get; set; }
    public bool IsApiKey3Valid { get; set; }
    public string ApiKey1Status { get => Label_StatusApiKey1.Text; set => Label_StatusApiKey1.Text = value; }
    public string ApiKey2Status { get => Label_StatusApiKey2.Text; set => Label_StatusApiKey2.Text = value; }
    public string ApiKey3Status { get => Label_StatusApiKey3.Text; set => Label_StatusApiKey3.Text = value; }
    public string ApiKeyStatusStrip { get => ToolStripStatusLabel_ApiKey.Text; set => ToolStripStatusLabel_ApiKey.Text = value; }
    public string MainMenuStatusStrip { get => ToolStripStatusLabel_MainMenu.Text; set => ToolStripStatusLabel_MainMenu.Text = value; }
    public Label MainMenuBlockerLabel { get => MainMenuBlockLabel; set => MainMenuBlockLabel = value; }
    public Panel MainMenuBlockerPanel { get => MainMenuBlockPanel; set => MainMenuBlockPanel = value; }
    public ListBox ListBoxPortfolios { get => ListBox_Portfolios; set => ListBox_Portfolios = value; }
    public Button ButtonAddNewPortfolio { get => Button_AddNewPortfolio; set => Button_AddNewPortfolio = value; }
    public Button ButtonDeleteSelectedPortfolio { get => Button_DeleteSelectedPortfolio; set => Button_DeleteSelectedPortfolio = value; }
    public string LabelEarnLossRatio { get => Label_EarnLossRatio.Text; set => Label_EarnLossRatio.Text = value; }
    public string LabelTotalInvested { get => Label_TotalInvested.Text; set => Label_TotalInvested.Text = value; }
    public string LabelCurrentValue { get => Label_CurrentValue.Text; set => Label_CurrentValue.Text = value; }

    public event EventHandler ValidateApiKey;
    public event EventHandler SaveApiKey;
    public event EventHandler LoadApiKeys;
    public event EventHandler<ListBox> SavePortfolios;
    public event EventHandler<Portfolio> PortfolioSelected;
    public event EventHandler LoadSavedPortfolios;
    public event EventHandler OpenAddPortfolioForm;
    public event EventHandler<ListBox> DeleteSelectedItem;


    public MainAppForm()
    {


        InitializeComponent();


    }

    private void MainAppForm_Load(object sender, EventArgs e)
    {
        LoadSavedPortfolios?.Invoke(this, EventArgs.Empty);
        LoadApiKeys?.Invoke(this, EventArgs.Empty);
        ValidateApiKeys();
    }


    private void ValidateApiKeys()
    {
        Button_ValidateApiKey_Click(Button_ValidateApiKey1, EventArgs.Empty);
        Button_ValidateApiKey_Click(Button_ValidateApiKey2, EventArgs.Empty);
    }


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
        OpenAddPortfolioForm?.Invoke(this, EventArgs.Empty);
    }


    private void Button_DeleteSelectedPortfolio_Click(object sender, EventArgs e)
    {

        DeleteSelectedItem?.Invoke(sender, ListBoxPortfolios);

    }


    private void Button_SavePortfolios_Click(object sender, EventArgs e)
    {
        SavePortfolios?.Invoke(this, ListBoxPortfolios);

    }

    
}




//var selectedPortfolio = (Portfolio)ListBoxPortfolios.SelectedItems[0];

//PortfolioSelected?.Invoke(this, selectedPortfolio);

//DataTable table = new DataTable();
//table.Columns.Add("ID", typeof(int));
//table.Columns.Add("NAME", typeof(string));
//table.Columns.Add("CITY", typeof(string));

//table.Rows.Add(111, "Devesh", "Ghaziabad");
//table.Rows.Add(222, "ROLI", "KANPUR");
//table.Rows.Add(102, "ROLI", "MAINPURI");
//table.Rows.Add(212, "DEVESH", "KANPUR");

//dataGridView1.DataSource = table;
