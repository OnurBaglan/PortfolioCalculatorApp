namespace PortfolioCalculatorApp;

partial class MainAppForm
{
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        ListBox_Portfolios = new ListBox();
        Button_AddNewPortfolio = new Button();
        Button_DeleteSelectedPortfolio = new Button();
        FixedLabel_PortfolioList = new Label();
        GroupBox_PortfolioDetails = new GroupBox();
        dataGridView1 = new DataGridView();
        column1 = new DataGridViewTextBoxColumn();
        column2 = new DataGridViewTextBoxColumn();
        label1 = new Label();
        portfolioBindingSource1 = new BindingSource(components);
        GroupBox_EarnLossInfo = new GroupBox();
        Label_CurrentValue = new Label();
        FixedTable_CurrentValue = new Label();
        Label_TotalInvested = new Label();
        FixedLabel_TotalInvested = new Label();
        Label_EarnLossRatio = new Label();
        FixedLabel_Ratio = new Label();
        FixedLabel_SelectedCurrency = new Label();
        ComboBox_Currencies = new ComboBox();
        TabControl = new TabControl();
        TabPage1 = new TabPage();
        Button_ShowPortfolioDetails = new Button();
        Button_SavePortfolios = new Button();
        GroupBox_PortfolioDetails.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)portfolioBindingSource1).BeginInit();
        GroupBox_EarnLossInfo.SuspendLayout();
        TabControl.SuspendLayout();
        TabPage1.SuspendLayout();
        SuspendLayout();
        // 
        // ListBox_Portfolios
        // 
        ListBox_Portfolios.FormattingEnabled = true;
        ListBox_Portfolios.ItemHeight = 15;
        ListBox_Portfolios.Location = new Point(989, 36);
        ListBox_Portfolios.Name = "ListBox_Portfolios";
        ListBox_Portfolios.Size = new Size(368, 214);
        ListBox_Portfolios.TabIndex = 0;
        // 
        // Button_AddNewPortfolio
        // 
        Button_AddNewPortfolio.Location = new Point(989, 256);
        Button_AddNewPortfolio.Name = "Button_AddNewPortfolio";
        Button_AddNewPortfolio.Size = new Size(109, 43);
        Button_AddNewPortfolio.TabIndex = 1;
        Button_AddNewPortfolio.Text = "Add New Portfolio";
        Button_AddNewPortfolio.UseVisualStyleBackColor = true;
        Button_AddNewPortfolio.Click += Button_AddNewPortfolio_Click;
        // 
        // Button_DeleteSelectedPortfolio
        // 
        Button_DeleteSelectedPortfolio.Location = new Point(1260, 256);
        Button_DeleteSelectedPortfolio.Name = "Button_DeleteSelectedPortfolio";
        Button_DeleteSelectedPortfolio.Size = new Size(99, 42);
        Button_DeleteSelectedPortfolio.TabIndex = 2;
        Button_DeleteSelectedPortfolio.Text = "Delete Selected Portfolio";
        Button_DeleteSelectedPortfolio.UseVisualStyleBackColor = true;
        Button_DeleteSelectedPortfolio.Click += Button_DeleteSelectedPortfolio_Click;
        // 
        // FixedLabel_PortfolioList
        // 
        FixedLabel_PortfolioList.AutoSize = true;
        FixedLabel_PortfolioList.Location = new Point(1283, 18);
        FixedLabel_PortfolioList.Name = "FixedLabel_PortfolioList";
        FixedLabel_PortfolioList.Size = new Size(74, 15);
        FixedLabel_PortfolioList.TabIndex = 3;
        FixedLabel_PortfolioList.Text = "Portfolio List";
        // 
        // GroupBox_PortfolioDetails
        // 
        GroupBox_PortfolioDetails.Controls.Add(dataGridView1);
        GroupBox_PortfolioDetails.Controls.Add(label1);
        GroupBox_PortfolioDetails.Location = new Point(8, 31);
        GroupBox_PortfolioDetails.Name = "GroupBox_PortfolioDetails";
        GroupBox_PortfolioDetails.Size = new Size(952, 219);
        GroupBox_PortfolioDetails.TabIndex = 4;
        GroupBox_PortfolioDetails.TabStop = false;
        GroupBox_PortfolioDetails.Text = "Portfolio Details";
        // 
        // dataGridView1
        // 
        dataGridView1.BackgroundColor = SystemColors.ButtonFace;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { column1, column2 });
        dataGridView1.Cursor = Cursors.Hand;
        dataGridView1.Location = new Point(25, 37);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(902, 129);
        dataGridView1.TabIndex = 2;
        // 
        // column1
        // 
        column1.HeaderText = "Name";
        column1.MinimumWidth = 6;
        column1.Name = "column1";
        column1.Width = 125;
        // 
        // column2
        // 
        column2.HeaderText = "Surname";
        column2.MinimumWidth = 6;
        column2.Name = "column2";
        column2.Width = 125;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(25, 19);
        label1.Name = "label1";
        label1.Size = new Size(113, 15);
        label1.TabIndex = 0;
        label1.Text = "Name of portfolio - ";
        // 
        // portfolioBindingSource1
        // 
        portfolioBindingSource1.DataSource = typeof(Model.PortfolioModel);
        // 
        // GroupBox_EarnLossInfo
        // 
        GroupBox_EarnLossInfo.Controls.Add(Label_CurrentValue);
        GroupBox_EarnLossInfo.Controls.Add(FixedTable_CurrentValue);
        GroupBox_EarnLossInfo.Controls.Add(Label_TotalInvested);
        GroupBox_EarnLossInfo.Controls.Add(FixedLabel_TotalInvested);
        GroupBox_EarnLossInfo.Controls.Add(Label_EarnLossRatio);
        GroupBox_EarnLossInfo.Controls.Add(FixedLabel_Ratio);
        GroupBox_EarnLossInfo.Controls.Add(FixedLabel_SelectedCurrency);
        GroupBox_EarnLossInfo.Controls.Add(ComboBox_Currencies);
        GroupBox_EarnLossInfo.Location = new Point(8, 256);
        GroupBox_EarnLossInfo.Name = "GroupBox_EarnLossInfo";
        GroupBox_EarnLossInfo.Size = new Size(952, 221);
        GroupBox_EarnLossInfo.TabIndex = 5;
        GroupBox_EarnLossInfo.TabStop = false;
        GroupBox_EarnLossInfo.Text = "Earn/Loss Info";
        // 
        // Label_CurrentValue
        // 
        Label_CurrentValue.AutoSize = true;
        Label_CurrentValue.Location = new Point(627, 54);
        Label_CurrentValue.Name = "Label_CurrentValue";
        Label_CurrentValue.Size = new Size(81, 15);
        Label_CurrentValue.TabIndex = 9;
        Label_CurrentValue.Text = "156151 dollars";
        // 
        // FixedTable_CurrentValue
        // 
        FixedTable_CurrentValue.AutoSize = true;
        FixedTable_CurrentValue.Location = new Point(605, 31);
        FixedTable_CurrentValue.Name = "FixedTable_CurrentValue";
        FixedTable_CurrentValue.Size = new Size(132, 15);
        FixedTable_CurrentValue.TabIndex = 8;
        FixedTable_CurrentValue.Text = "Current Value as of date";
        // 
        // Label_TotalInvested
        // 
        Label_TotalInvested.AutoSize = true;
        Label_TotalInvested.Location = new Point(415, 54);
        Label_TotalInvested.Name = "Label_TotalInvested";
        Label_TotalInvested.Size = new Size(81, 15);
        Label_TotalInvested.TabIndex = 7;
        Label_TotalInvested.Text = "123456 dollars";
        // 
        // FixedLabel_TotalInvested
        // 
        FixedLabel_TotalInvested.AutoSize = true;
        FixedLabel_TotalInvested.Location = new Point(417, 31);
        FixedLabel_TotalInvested.Name = "FixedLabel_TotalInvested";
        FixedLabel_TotalInvested.Size = new Size(79, 15);
        FixedLabel_TotalInvested.TabIndex = 6;
        FixedLabel_TotalInvested.Text = "Total invested";
        // 
        // Label_EarnLossRatio
        // 
        Label_EarnLossRatio.AutoSize = true;
        Label_EarnLossRatio.Location = new Point(187, 54);
        Label_EarnLossRatio.Name = "Label_EarnLossRatio";
        Label_EarnLossRatio.Size = new Size(29, 15);
        Label_EarnLossRatio.TabIndex = 5;
        Label_EarnLossRatio.Text = "%30";
        // 
        // FixedLabel_Ratio
        // 
        FixedLabel_Ratio.AutoSize = true;
        FixedLabel_Ratio.Location = new Point(187, 31);
        FixedLabel_Ratio.Name = "FixedLabel_Ratio";
        FixedLabel_Ratio.Size = new Size(115, 15);
        FixedLabel_Ratio.TabIndex = 2;
        FixedLabel_Ratio.Text = "Your Earn/Loss Ratio";
        // 
        // FixedLabel_SelectedCurrency
        // 
        FixedLabel_SelectedCurrency.AutoSize = true;
        FixedLabel_SelectedCurrency.Location = new Point(6, 28);
        FixedLabel_SelectedCurrency.Name = "FixedLabel_SelectedCurrency";
        FixedLabel_SelectedCurrency.Size = new Size(89, 15);
        FixedLabel_SelectedCurrency.TabIndex = 1;
        FixedLabel_SelectedCurrency.Text = "Select Currency";
        // 
        // ComboBox_Currencies
        // 
        ComboBox_Currencies.FormattingEnabled = true;
        ComboBox_Currencies.Location = new Point(6, 46);
        ComboBox_Currencies.Name = "ComboBox_Currencies";
        ComboBox_Currencies.Size = new Size(121, 23);
        ComboBox_Currencies.TabIndex = 0;
        // 
        // TabControl
        // 
        TabControl.Controls.Add(TabPage1);
        TabControl.Dock = DockStyle.Fill;
        TabControl.Location = new Point(0, 0);
        TabControl.Name = "TabControl";
        TabControl.SelectedIndex = 0;
        TabControl.Size = new Size(1370, 558);
        TabControl.TabIndex = 6;
        TabControl.TabStop = false;
        // 
        // TabPage1
        // 
        TabPage1.BackColor = Color.Transparent;
        TabPage1.Controls.Add(Button_ShowPortfolioDetails);
        TabPage1.Controls.Add(Button_SavePortfolios);
        TabPage1.Controls.Add(GroupBox_EarnLossInfo);
        TabPage1.Controls.Add(FixedLabel_PortfolioList);
        TabPage1.Controls.Add(GroupBox_PortfolioDetails);
        TabPage1.Controls.Add(Button_DeleteSelectedPortfolio);
        TabPage1.Controls.Add(ListBox_Portfolios);
        TabPage1.Controls.Add(Button_AddNewPortfolio);
        TabPage1.Location = new Point(4, 24);
        TabPage1.Name = "TabPage1";
        TabPage1.Padding = new Padding(3, 3, 3, 3);
        TabPage1.Size = new Size(1362, 530);
        TabPage1.TabIndex = 0;
        TabPage1.Text = "Main Menu";
        // 
        // Button_ShowPortfolioDetails
        // 
        Button_ShowPortfolioDetails.Location = new Point(991, 305);
        Button_ShowPortfolioDetails.Name = "Button_ShowPortfolioDetails";
        Button_ShowPortfolioDetails.Size = new Size(368, 74);
        Button_ShowPortfolioDetails.TabIndex = 3;
        Button_ShowPortfolioDetails.Text = "Show details of selected portfolio";
        Button_ShowPortfolioDetails.UseVisualStyleBackColor = true;
        Button_ShowPortfolioDetails.Click += Button_ShowPortfolioDetails_Click;
        // 
        // Button_SavePortfolios
        // 
        Button_SavePortfolios.Location = new Point(1104, 256);
        Button_SavePortfolios.Name = "Button_SavePortfolios";
        Button_SavePortfolios.Size = new Size(150, 42);
        Button_SavePortfolios.TabIndex = 7;
        Button_SavePortfolios.Text = "Save Portfolios";
        Button_SavePortfolios.UseVisualStyleBackColor = true;
        Button_SavePortfolios.Click += Button_SavePortfolios_Click;
        // 
        // MainAppForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        AutoSize = true;
        BackColor = SystemColors.AppWorkspace;
        ClientSize = new Size(1370, 558);
        Controls.Add(TabControl);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "MainAppForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Porftolio Calculator App";
        Load += MainAppForm_Load;
        GroupBox_PortfolioDetails.ResumeLayout(false);
        GroupBox_PortfolioDetails.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)portfolioBindingSource1).EndInit();
        GroupBox_EarnLossInfo.ResumeLayout(false);
        GroupBox_EarnLossInfo.PerformLayout();
        TabControl.ResumeLayout(false);
        TabPage1.ResumeLayout(false);
        TabPage1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private ListBox ListBox_Portfolios;
	private Button Button_AddNewPortfolio;
	private Button Button_DeleteSelectedPortfolio;
	private Label FixedLabel_PortfolioList;
	private GroupBox GroupBox_PortfolioDetails;
	private GroupBox GroupBox_EarnLossInfo;
	private Label Label_EarnLossRatio;
	private Label FixedLabel_Ratio;
	private Label FixedLabel_SelectedCurrency;
	private ComboBox ComboBox_Currencies;
	private Label Label_CurrentValue;
	private Label FixedTable_CurrentValue;
	private Label Label_TotalInvested;
	private Label FixedLabel_TotalInvested;
	private TabControl TabControl;
	private TabPage TabPage1;
	private LinkLabel linkLabel1;
    private Button Button_SavePortfolios;
    private Label label1;
    private DataGridView dataGridView1;
    private BindingSource portfolioBindingSource1;
    private DataGridViewTextBoxColumn column1;
    private DataGridViewTextBoxColumn column2;
    private Button Button_ShowPortfolioDetails;
}
