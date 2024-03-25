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

    public AddPortfolioForm()
    {
        InitializeComponent();
        _controller = new AddPortfolioController(this, new AddPortfolioModel());

        InitializeComboBox?.Invoke(this, EventArgs.Empty);

    }

    public ComboBox ComboBoxStockSymbols { get => ComboBox_StockSymbols; set => ComboBox_StockSymbols = value; }


    private void TextBox_StockSearch_TextChanged(object sender, EventArgs e)
    {
        SearchStock?.Invoke(sender, EventArgs.Empty);


    }
}
