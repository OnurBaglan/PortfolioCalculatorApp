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

public partial class AddPortfolioForm : Form
{
    private readonly string[] _stockList;

    public AddPortfolioForm()
    {
        InitializeComponent();

        _stockList = File.ReadAllLines("stocks.txt");

        InitializeComboBox_StockSymbols();

    }

    private async Task InitializeComboBox_StockSymbols()
    {
        ComboBox_StockSymbols.Items.AddRange(_stockList);
        ComboBox_StockSymbols.DropDownStyle = ComboBoxStyle.DropDownList;
    }

 
    private void TextBox_StockSearch_TextChanged(object sender, EventArgs e)
    {
        ComboBox_StockSymbols.Items.Clear();

        var data = _stockList.Where(item => item.ToUpper().Contains(TextBox_StockSearch.Text.ToUpper())).ToArray();

        ComboBox_StockSymbols.Items.AddRange(data);

        ComboBox_StockSymbols.SelectedItem = data.FirstOrDefault();

        if (string.IsNullOrEmpty(TextBox_StockSearch.Text))
        {
            ComboBox_StockSymbols.SelectedItem = null;
        }
    }
}
