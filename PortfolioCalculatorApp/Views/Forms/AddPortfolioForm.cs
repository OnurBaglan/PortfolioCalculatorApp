using PortfolioCalculatorApp.Model;
using PortfolioCalculatorApp.Views.Interfaces;


namespace PortfolioCalculatorApp;

public partial class AddPortfolioForm : Form, IAddPortfolioFormView
{

    public event EventHandler InitializeComboBox;
    public event EventHandler SearchStock;
    public event EventHandler ResetSelections;
    public event EventHandler RemovePurchase;
    public event EventHandler AddPortfolio;
    public event EventHandler<PurchaseModel> AddPurchase;
    public event EventHandler AddPortfolioFormClosed;

    public AddPortfolioForm()
    {
        InitializeComponent();
    }

    public ComboBox ComboBoxStockSymbols { get => ComboBox_StockSymbols; set => ComboBox_StockSymbols = value; }
    public string SelectedStockText { get => ComboBox_StockSymbols.SelectedText; }    
    public NumericUpDown NumericUpDownLots { get => NumericUpDown_Lots; set => NumericUpDown_Lots = value; }
    public int SelectedLots { get => (int)NumericUpDown_Lots.Value; }
    public DateTimePicker DateTimePickerPurchaseDate { get => DateTimePicker_PurchaseDate; set => DateTimePicker_PurchaseDate = value; }
    public DateTime SelectedDateTime { get => DateTimePicker_PurchaseDate.Value; }
    public ListBox ListBoxAddedPurchases { get => ListBox_AddedPurchases; set => ListBox_AddedPurchases = value; }
    public TextBox TextBoxPortfolioName { get => TextBox_PortfolioName; set => TextBox_PortfolioName = value; }


    private void TextBox_StockSearch_TextChanged(object sender, EventArgs e)
    {
        SearchStock?.Invoke(sender, EventArgs.Empty);

    }

    private void Button_AddPurchase_Click(object sender, EventArgs e)
    {
        var purchaseModel = new PurchaseModel(SelectedStockText, SelectedLots, SelectedDateTime);
        AddPurchase?.Invoke(null, purchaseModel);
    }

    private void Button_ResetSelections_Click(object sender, EventArgs e)
    {
        ResetSelections?.Invoke(this, EventArgs.Empty);

    }


    private void Button_DeleteSelectedPurchase_Click(object sender, EventArgs e)
    {
        RemovePurchase?.Invoke(this, EventArgs.Empty);

    }
    private void Button_AddPortfolio_Click(object sender, EventArgs e)
    {
        AddPortfolio?.Invoke(this, EventArgs.Empty);

    }

    private void AddPortfolioForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        AddPortfolioFormClosed?.Invoke(this, e);
    }

    public void ShowDialogWrapper()
    {
        InitializeComboBox?.Invoke(this, EventArgs.Empty);
        ShowDialog();
    }
    public void CloseWrapperWithMessage(string message)
    {
        MessageBox.Show(message);
        Close();
    }



    

}
