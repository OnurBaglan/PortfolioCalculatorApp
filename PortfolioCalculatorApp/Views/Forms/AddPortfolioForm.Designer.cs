
namespace PortfolioCalculatorApp;

partial class AddPortfolioForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        DateTimePicker_PurchaseDate = new DateTimePicker();
        ComboBox_StockSymbols = new ComboBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        Button_AddPurchase = new Button();
        Button_ResetSelections = new Button();
        Button_DeleteSelectedPurchase = new Button();
        Button_AddPortfolio = new Button();
        NumericUpDown_Lots = new NumericUpDown();
        TextBox_StockSearch = new TextBox();
        TextBox_PortfolioName = new TextBox();
        FixedLabelPortfolioName = new Label();
        errorProvider1 = new ErrorProvider(components);
        ListBox_AddedPurchases = new ListBox();
        ((System.ComponentModel.ISupportInitialize)NumericUpDown_Lots).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
        SuspendLayout();
        // 
        // DateTimePicker_PurchaseDate
        // 
        DateTimePicker_PurchaseDate.Location = new Point(557, 53);
        DateTimePicker_PurchaseDate.Name = "DateTimePicker_PurchaseDate";
        DateTimePicker_PurchaseDate.Size = new Size(200, 23);
        DateTimePicker_PurchaseDate.TabIndex = 0;
        // 
        // ComboBox_StockSymbols
        // 
        ComboBox_StockSymbols.FormattingEnabled = true;
        ComboBox_StockSymbols.Location = new Point(81, 82);
        ComboBox_StockSymbols.Name = "ComboBox_StockSymbols";
        ComboBox_StockSymbols.Size = new Size(317, 23);
        ComboBox_StockSymbols.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(81, 35);
        label1.Name = "label1";
        label1.Size = new Size(111, 15);
        label1.TabIndex = 3;
        label1.Text = "Select stock symbol";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(438, 35);
        label2.Name = "label2";
        label2.Size = new Size(29, 15);
        label2.TabIndex = 4;
        label2.Text = "Lots";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(676, 35);
        label3.Name = "label3";
        label3.Size = new Size(81, 15);
        label3.TabIndex = 5;
        label3.Text = "Purchase date";
        // 
        // Button_AddPurchase
        // 
        Button_AddPurchase.Location = new Point(438, 81);
        Button_AddPurchase.Name = "Button_AddPurchase";
        Button_AddPurchase.Size = new Size(319, 23);
        Button_AddPurchase.TabIndex = 6;
        Button_AddPurchase.Text = "Add the purchase";
        Button_AddPurchase.UseVisualStyleBackColor = true;
        Button_AddPurchase.Click += Button_AddPurchase_Click;
        // 
        // Button_ResetSelections
        // 
        Button_ResetSelections.Location = new Point(0, 51);
        Button_ResetSelections.Name = "Button_ResetSelections";
        Button_ResetSelections.Size = new Size(75, 23);
        Button_ResetSelections.TabIndex = 7;
        Button_ResetSelections.Text = "Reset";
        Button_ResetSelections.UseVisualStyleBackColor = true;
        Button_ResetSelections.Click += Button_ResetSelections_Click;
        // 
        // Button_DeleteSelectedPurchase
        // 
        Button_DeleteSelectedPurchase.Location = new Point(0, 151);
        Button_DeleteSelectedPurchase.Name = "Button_DeleteSelectedPurchase";
        Button_DeleteSelectedPurchase.Size = new Size(75, 59);
        Button_DeleteSelectedPurchase.TabIndex = 9;
        Button_DeleteSelectedPurchase.Text = "Delete selected purchase";
        Button_DeleteSelectedPurchase.UseVisualStyleBackColor = true;
        Button_DeleteSelectedPurchase.Click += Button_DeleteSelectedPurchase_Click;
        // 
        // Button_AddPortfolio
        // 
        Button_AddPortfolio.Location = new Point(571, 333);
        Button_AddPortfolio.Name = "Button_AddPortfolio";
        Button_AddPortfolio.Size = new Size(186, 23);
        Button_AddPortfolio.TabIndex = 10;
        Button_AddPortfolio.Text = "Add portfolio";
        Button_AddPortfolio.UseVisualStyleBackColor = true;
        Button_AddPortfolio.Click += Button_AddPortfolio_Click;
        // 
        // NumericUpDown_Lots
        // 
        NumericUpDown_Lots.Location = new Point(438, 53);
        NumericUpDown_Lots.Name = "NumericUpDown_Lots";
        NumericUpDown_Lots.Size = new Size(88, 23);
        NumericUpDown_Lots.TabIndex = 11;
        // 
        // TextBox_StockSearch
        // 
        TextBox_StockSearch.Location = new Point(81, 53);
        TextBox_StockSearch.Name = "TextBox_StockSearch";
        TextBox_StockSearch.Size = new Size(317, 23);
        TextBox_StockSearch.TabIndex = 12;
        TextBox_StockSearch.TextChanged += TextBox_StockSearch_TextChanged;
        // 
        // TextBox_PortfolioName
        // 
        TextBox_PortfolioName.Location = new Point(81, 333);
        TextBox_PortfolioName.Name = "TextBox_PortfolioName";
        TextBox_PortfolioName.Size = new Size(484, 23);
        TextBox_PortfolioName.TabIndex = 13;
        // 
        // FixedLabelPortfolioName
        // 
        FixedLabelPortfolioName.AutoSize = true;
        FixedLabelPortfolioName.Location = new Point(81, 315);
        FixedLabelPortfolioName.Name = "FixedLabelPortfolioName";
        FixedLabelPortfolioName.Size = new Size(102, 15);
        FixedLabelPortfolioName.TabIndex = 14;
        FixedLabelPortfolioName.Text = "Name of portfolio";
        // 
        // errorProvider1
        // 
        errorProvider1.ContainerControl = this;
        // 
        // ListBox_AddedPurchases
        // 
        ListBox_AddedPurchases.FormattingEnabled = true;
        ListBox_AddedPurchases.ItemHeight = 15;
        ListBox_AddedPurchases.Location = new Point(81, 151);
        ListBox_AddedPurchases.Name = "ListBox_AddedPurchases";
        ListBox_AddedPurchases.Size = new Size(676, 124);
        ListBox_AddedPurchases.TabIndex = 15;
        // 
        // AddPortfolioForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(ListBox_AddedPurchases);
        Controls.Add(FixedLabelPortfolioName);
        Controls.Add(TextBox_PortfolioName);
        Controls.Add(TextBox_StockSearch);
        Controls.Add(NumericUpDown_Lots);
        Controls.Add(Button_AddPortfolio);
        Controls.Add(Button_DeleteSelectedPurchase);
        Controls.Add(Button_ResetSelections);
        Controls.Add(Button_AddPurchase);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(ComboBox_StockSymbols);
        Controls.Add(DateTimePicker_PurchaseDate);
        Name = "AddPortfolioForm";
        Text = "Add a portfolio";
        FormClosed += AddPortfolioForm_FormClosed;
        ((System.ComponentModel.ISupportInitialize)NumericUpDown_Lots).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }



    #endregion

    private DateTimePicker DateTimePicker_PurchaseDate;
    private ComboBox ComboBox_StockSymbols;
    private Label label1;
    private Label label2;
    private Label label3;
    private Button Button_AddPurchase;
    private Button Button_ResetSelections;
    private Button Button_DeleteSelectedPurchase;
    private Button Button_AddPortfolio;
    private NumericUpDown NumericUpDown_Lots;
    private TextBox TextBox_StockSearch;
    private TextBox TextBox_PortfolioName;
    private Label FixedLabelPortfolioName;
    private ErrorProvider errorProvider1;
    private ListBox ListBox_AddedPurchases;
}