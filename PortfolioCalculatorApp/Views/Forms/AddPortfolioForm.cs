using PortfolioCalculatorApp.Controller;
using PortfolioCalculatorApp.Views.Interfaces;
using PortfolioCalculatorApp.Model.BusinessModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfolioCalculatorApp;

public partial class AddPortfolioForm : Form, IAddPortfolioView
{
    private readonly AddPortfolioController _controller;


    public event EventHandler InitializeComboBox;
    public event EventHandler SearchStock;
    public event EventHandler ResetSelections;

    public AddPortfolioForm()
    {
        InitializeComponent();
        _controller = new AddPortfolioController(this, new AddPortfolioModel());

        InitializeComboBox?.Invoke(this, EventArgs.Empty);

    }

    public ComboBox ComboBoxStockSymbols { get => ComboBox_StockSymbols; set => ComboBox_StockSymbols = value; }

    public NumericUpDown NumericUpDownLots { get => NumericUpDown_Lots; set => NumericUpDown_Lots = value; }

    public DateTimePicker DateTimePickerPurchaseDate { get => DateTimePicker_PurchaseDate; set => DateTimePicker_PurchaseDate = value; }


    private void TextBox_StockSearch_TextChanged(object sender, EventArgs e)
    {
        SearchStock?.Invoke(sender, EventArgs.Empty);


    }

    private void Button_ResetSelections_Click(object sender, EventArgs e)
    {
        ResetSelections?.Invoke(this, EventArgs.Empty);

    }
}
