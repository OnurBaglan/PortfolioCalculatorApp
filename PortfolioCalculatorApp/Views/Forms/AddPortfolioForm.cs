using PortfolioCalculatorApp.Views.Interfaces;


namespace PortfolioCalculatorApp;

public partial class AddPortfolioForm : Form, IAddPortfolioFormView
{

    public event EventHandler InitializeComboBox;
    public event EventHandler SearchStock;
    public event EventHandler ResetSelections;
    public event EventHandler AddPurchase;
    public event EventHandler RemovePurchase;
    public event EventHandler SavePortfolio;

    public AddPortfolioForm()
    {
        InitializeComponent();
    }

    public ComboBox ComboBoxStockSymbols { get => ComboBox_StockSymbols; set => ComboBox_StockSymbols = value; }

    public NumericUpDown NumericUpDownLots { get => NumericUpDown_Lots; set => NumericUpDown_Lots = value; }

    public DateTimePicker DateTimePickerPurchaseDate { get => DateTimePicker_PurchaseDate; set => DateTimePicker_PurchaseDate = value; }

    public ListBox ListBoxAddedPurchases { get => ListBox_AddedPurchases; set => ListBox_AddedPurchases = value; }

    public TextBox TextBoxPortfolioName { get => TextBox_PortfolioName; set => TextBox_PortfolioName = value; }


    private void TextBox_StockSearch_TextChanged(object sender, EventArgs e)
    {
        SearchStock?.Invoke(sender, EventArgs.Empty);


    }

    private void Button_ResetSelections_Click(object sender, EventArgs e)
    {
        ResetSelections?.Invoke(this, EventArgs.Empty);


    }

    private void Button_AddPurchase_Click(object sender, EventArgs e)
    {
        AddPurchase?.Invoke(this, EventArgs.Empty);
    }

    private void Button_DeleteSelectedPurchase_Click(object sender, EventArgs e)
    {
        RemovePurchase?.Invoke(this, EventArgs.Empty);

    }

    private void Button_SavePortfolio_Click(object sender, EventArgs e)
    {

        SavePortfolio?.Invoke(this, EventArgs.Empty);
    }

    public void ShowDialogWrapper()
    {
        InitializeComboBox?.Invoke(this, EventArgs.Empty);
        ShowDialog();
    }
}
