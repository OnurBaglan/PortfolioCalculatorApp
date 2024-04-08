

using PortfolioCalculatorApp.Views.Interfaces;
using PortfolioCalculatorApp.Model;

namespace PortfolioCalculatorApp;

public partial class MainAppForm : Form, IMainAppFormView
{

    public ListBox ListBoxPortfolios { get => ListBox_Portfolios; set => ListBox_Portfolios = value; }
    public Button ButtonAddNewPortfolio { get => Button_AddNewPortfolio; set => Button_AddNewPortfolio = value; }
    public Button ButtonDeleteSelectedPortfolio { get => Button_DeleteSelectedPortfolio; set => Button_DeleteSelectedPortfolio = value; }
    public string LabelEarnLossRatio { get => Label_EarnLossRatio.Text; set => Label_EarnLossRatio.Text = value; }
    public string LabelTotalInvested { get => Label_TotalInvested.Text; set => Label_TotalInvested.Text = value; }
    public string LabelCurrentValue { get => Label_CurrentValue.Text; set => Label_CurrentValue.Text = value; }
    public ComboBox ComboBoxCurrencies { get => ComboBox_Currencies; }



    public event EventHandler<ListBox> SavePortfolios;
    public event EventHandler<PortfolioModel> PortfolioSelected;
    public event EventHandler LoadSavedPortfolios;
    public event EventHandler OpenAddPortfolioForm;
    public event EventHandler<ListBox> DeleteSelectedItem;
    public event EventHandler<PortfolioModel> CalculatePortfolio;
    public event EventHandler<ComboBox> InitializeCurrencyComboBox;


    public MainAppForm()
    {

        InitializeComponent();

    }



    private void MainAppForm_Load(object sender, EventArgs e)
    {
        LoadSavedPortfolios?.Invoke(this, EventArgs.Empty);

        InitializeCurrencyComboBox?.Invoke(this, ComboBox_Currencies);


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

    private void Button_ShowPortfolioDetails_Click(object sender, EventArgs e)
    {
        var portfolioModel = ListBox_Portfolios.SelectedItem as PortfolioModel;
        if (portfolioModel is null)
        {
            MessageBox.Show("Please select a portfolio");
        }
        else
        {
            CalculatePortfolio?.Invoke(this, portfolioModel);
        }

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
