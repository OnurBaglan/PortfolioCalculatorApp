using PortfolioCalculatorApp.BusinessLogic;
using PortfolioCalculatorApp.BusinessLogic.ModelAnalyzer;
using PortfolioCalculatorApp.Model;
using PortfolioCalculatorApp.Model.DTO;
using PortfolioCalculatorApp.Views.Interfaces;

namespace PortfolioCalculatorApp.Controller;

public class AddPortfolioFormController
{
	private readonly IAddPortfolioFormView _addPortfolioFormView;
	private readonly IStockListLoader _stockListLoaderModel;
	private readonly List<PurchaseModel> _purchases = new();
	private readonly ModelAnalyzer _modelAnalyzer;

	public static event EventHandler<PortfolioModel> AddValidPortfolio;

	public AddPortfolioFormController(IAddPortfolioFormView addPortfolioFormView, IStockListLoader stockListLoaderModel, ModelAnalyzer modelAnalyzer)
	{


		_addPortfolioFormView = addPortfolioFormView;
		_stockListLoaderModel = stockListLoaderModel;
		_modelAnalyzer = modelAnalyzer;

		_addPortfolioFormView.InitializeComboBox += OnInitializeComboBox;
		_addPortfolioFormView.SearchStock += OnSearchStock;
		_addPortfolioFormView.ResetSelections += OnResetSelections;
		_addPortfolioFormView.AddPurchase += OnAddPurchase;
		_addPortfolioFormView.RemovePurchase += OnRemovePurchase;
		_addPortfolioFormView.AddPortfolio += OnAddPortfolio;
		_addPortfolioFormView.AddPortfolioFormClosed += OnFormClosed;
	}

	private void OnFormClosed(object? sender, EventArgs e)
	{
		_addPortfolioFormView.ComboBoxStockSymbols.SelectedItem = null;
		_addPortfolioFormView.TextBoxPortfolioName.Text = null;
		_addPortfolioFormView.NumericUpDownLots.Value = 0;
		_addPortfolioFormView.DateTimePickerPurchaseDate.Value = DateTime.Now;
		_addPortfolioFormView.ListBoxAddedPurchases.Items.Clear();


	}

	private void OnAddPortfolio(object? sender, EventArgs e)
	{
		while (!DoesAddingMakeSense())
		{
			MessageBox.Show(@"Make sure you entered a valid portfolio name and have at least one purchase added");
			return;
		}



		var portfolio = new PortfolioModel()
		{
			Purchases = _purchases,
			Name = _addPortfolioFormView.TextBoxPortfolioName.Text
		};

		_addPortfolioFormView.CloseWrapperWithMessage("Portfolio added.");

		AddValidPortfolio?.Invoke(this, portfolio);

	}

   
	private bool DoesAddingMakeSense()
	{
		//a more in depth validation is needed in future not to duplicate names
		return !string.IsNullOrEmpty(_addPortfolioFormView.TextBoxPortfolioName.Text) &&
			_addPortfolioFormView.ListBoxAddedPurchases.Items.Count != 0;
	}

	private void OnRemovePurchase(object? sender, EventArgs e)
	{
		if (_addPortfolioFormView.ListBoxAddedPurchases.SelectedItem is not null)
		{
			var purchaseToDelete = (PurchaseModel)_addPortfolioFormView.ListBoxAddedPurchases.SelectedItem;
			_addPortfolioFormView.ListBoxAddedPurchases.Items.Remove(purchaseToDelete);
			_purchases.Remove(purchaseToDelete);

		}
	}

	private async void OnAddPurchase(object? sender, PurchaseModel purchaseModel)
	{
		var analyzeResult = await _modelAnalyzer.Analyze(purchaseModel);

		if (!analyzeResult.IsModelValid)
		{
			analyzeResult.ShowErrors();
			return;
		}
		else
		{		

			_purchases.Add(purchaseModel);

			_addPortfolioFormView.ListBoxAddedPurchases.Items.Add(purchaseModel);
		}
						

	}
	 

	private void OnResetSelections(object? sender, EventArgs e)
	{
		_addPortfolioFormView.ComboBoxStockSymbols.SelectedItem = null;

		_addPortfolioFormView.NumericUpDownLots.Value = 0;

		_addPortfolioFormView.DateTimePickerPurchaseDate.Value = DateTime.Now;
	}

	public void OnInitializeComboBox(object? sender, EventArgs? e)
	{



		var stockList = _stockListLoaderModel.StockList.ToArray();
		_addPortfolioFormView.ComboBoxStockSymbols.Items.AddRange(stockList);
		_addPortfolioFormView.ComboBoxStockSymbols.DropDownStyle = ComboBoxStyle.DropDownList;
	}

	public void OnSearchStock(object? sender, EventArgs? e)
	{

		_addPortfolioFormView.ComboBoxStockSymbols.Items.Clear();

		var data = _stockListLoaderModel.StockList.Where(item => item.ToUpper().Contains(GetTextOfTextBox(sender).ToUpper())).ToArray();
		_addPortfolioFormView.ComboBoxStockSymbols.Items.AddRange(data);
		_addPortfolioFormView.ComboBoxStockSymbols.SelectedItem = data.FirstOrDefault();



		if (string.IsNullOrEmpty(GetTextOfTextBox(sender)))
		{
			_addPortfolioFormView.ComboBoxStockSymbols.SelectedItem = null;
		}
	}

	private string? GetTextOfTextBox(object? sender)
	{
		return (string)sender.GetType().GetProperty("Text").GetValue(sender);
	}
}
