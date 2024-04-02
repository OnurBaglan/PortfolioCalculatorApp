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
        ComboBox_SelectedCurrency = new ComboBox();
        TabControl = new TabControl();
        TabPage1 = new TabPage();
        Button_ShowPortfolioDetails = new Button();
        MainMenuBlockPanel = new Panel();
        MainMenuBlockLabel = new Label();
        Button_SavePortfolios = new Button();
        statusStrip2 = new StatusStrip();
        ToolStripStatusLabel_MainMenu = new ToolStripStatusLabel();
        TabPage2 = new TabPage();
        Label_StatusApiKey3 = new Label();
        Button_SaveApiKey3 = new Button();
        Button_ValidateApiKey3 = new Button();
        FixedLabel_ApiKey3 = new Label();
        TextBox_ApiKey3 = new TextBox();
        Button_SaveApiKey2 = new Button();
        Button_SaveApiKey1 = new Button();
        Label_StatusApiKey2 = new Label();
        Label_StatusApiKey1 = new Label();
        ToolStripStatusLabel_ApiKeyTab = new StatusStrip();
        ToolStripStatusLabel_ApiKey = new ToolStripStatusLabel();
        Button_ValidateApiKey2 = new Button();
        Button_ValidateApiKey1 = new Button();
        FixedLabel_ApiKey2 = new Label();
        FixedLabel_ApiKey1 = new Label();
        TextBox_ApiKey2 = new TextBox();
        TextBox_ApiKey1 = new TextBox();
        GroupBox_PortfolioDetails.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)portfolioBindingSource1).BeginInit();
        GroupBox_EarnLossInfo.SuspendLayout();
        TabControl.SuspendLayout();
        TabPage1.SuspendLayout();
        MainMenuBlockPanel.SuspendLayout();
        statusStrip2.SuspendLayout();
        TabPage2.SuspendLayout();
        ToolStripStatusLabel_ApiKeyTab.SuspendLayout();
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
        dataGridView1.Size = new Size(902, 129);
        dataGridView1.TabIndex = 2;
        // 
        // column1
        // 
        column1.HeaderText = "Name";
        column1.Name = "column1";
        // 
        // column2
        // 
        column2.HeaderText = "Surname";
        column2.Name = "column2";
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
        portfolioBindingSource1.DataSource = typeof(Model.DTO.Portfolio);
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
        GroupBox_EarnLossInfo.Controls.Add(ComboBox_SelectedCurrency);
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
        // ComboBox_SelectedCurrency
        // 
        ComboBox_SelectedCurrency.FormattingEnabled = true;
        ComboBox_SelectedCurrency.Location = new Point(6, 46);
        ComboBox_SelectedCurrency.Name = "ComboBox_SelectedCurrency";
        ComboBox_SelectedCurrency.Size = new Size(121, 23);
        ComboBox_SelectedCurrency.TabIndex = 0;
        // 
        // TabControl
        // 
        TabControl.Controls.Add(TabPage1);
        TabControl.Controls.Add(TabPage2);
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
        TabPage1.Controls.Add(MainMenuBlockPanel);
        TabPage1.Controls.Add(Button_SavePortfolios);
        TabPage1.Controls.Add(statusStrip2);
        TabPage1.Controls.Add(GroupBox_EarnLossInfo);
        TabPage1.Controls.Add(FixedLabel_PortfolioList);
        TabPage1.Controls.Add(GroupBox_PortfolioDetails);
        TabPage1.Controls.Add(Button_DeleteSelectedPortfolio);
        TabPage1.Controls.Add(ListBox_Portfolios);
        TabPage1.Controls.Add(Button_AddNewPortfolio);
        TabPage1.Location = new Point(4, 24);
        TabPage1.Name = "TabPage1";
        TabPage1.Padding = new Padding(3);
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
        // 
        // MainMenuBlockPanel
        // 
        MainMenuBlockPanel.Controls.Add(MainMenuBlockLabel);
        MainMenuBlockPanel.Location = new Point(0, 505);
        MainMenuBlockPanel.Name = "MainMenuBlockPanel";
        MainMenuBlockPanel.Size = new Size(1362, 507);
        MainMenuBlockPanel.TabIndex = 0;
        // 
        // MainMenuBlockLabel
        // 
        MainMenuBlockLabel.AutoSize = true;
        MainMenuBlockLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
        MainMenuBlockLabel.Location = new Point(125, 202);
        MainMenuBlockLabel.Name = "MainMenuBlockLabel";
        MainMenuBlockLabel.Size = new Size(1066, 65);
        MainMenuBlockLabel.TabIndex = 0;
        MainMenuBlockLabel.Text = "Please enter valid api keys to use the program";
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
        // statusStrip2
        // 
        statusStrip2.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel_MainMenu });
        statusStrip2.Location = new Point(3, 505);
        statusStrip2.Name = "statusStrip2";
        statusStrip2.Size = new Size(1356, 22);
        statusStrip2.TabIndex = 6;
        statusStrip2.Text = "statusStrip2";
        // 
        // ToolStripStatusLabel_MainMenu
        // 
        ToolStripStatusLabel_MainMenu.Name = "ToolStripStatusLabel_MainMenu";
        ToolStripStatusLabel_MainMenu.Size = new Size(10, 17);
        ToolStripStatusLabel_MainMenu.Text = " ";
        // 
        // TabPage2
        // 
        TabPage2.Controls.Add(Label_StatusApiKey3);
        TabPage2.Controls.Add(Button_SaveApiKey3);
        TabPage2.Controls.Add(Button_ValidateApiKey3);
        TabPage2.Controls.Add(FixedLabel_ApiKey3);
        TabPage2.Controls.Add(TextBox_ApiKey3);
        TabPage2.Controls.Add(Button_SaveApiKey2);
        TabPage2.Controls.Add(Button_SaveApiKey1);
        TabPage2.Controls.Add(Label_StatusApiKey2);
        TabPage2.Controls.Add(Label_StatusApiKey1);
        TabPage2.Controls.Add(ToolStripStatusLabel_ApiKeyTab);
        TabPage2.Controls.Add(Button_ValidateApiKey2);
        TabPage2.Controls.Add(Button_ValidateApiKey1);
        TabPage2.Controls.Add(FixedLabel_ApiKey2);
        TabPage2.Controls.Add(FixedLabel_ApiKey1);
        TabPage2.Controls.Add(TextBox_ApiKey2);
        TabPage2.Controls.Add(TextBox_ApiKey1);
        TabPage2.Location = new Point(4, 24);
        TabPage2.Name = "TabPage2";
        TabPage2.Padding = new Padding(3);
        TabPage2.Size = new Size(1362, 530);
        TabPage2.TabIndex = 1;
        TabPage2.Text = "API Key";
        TabPage2.UseVisualStyleBackColor = true;
        // 
        // Label_StatusApiKey3
        // 
        Label_StatusApiKey3.AutoSize = true;
        Label_StatusApiKey3.Location = new Point(757, 129);
        Label_StatusApiKey3.Name = "Label_StatusApiKey3";
        Label_StatusApiKey3.Size = new Size(0, 15);
        Label_StatusApiKey3.TabIndex = 15;
        // 
        // Button_SaveApiKey3
        // 
        Button_SaveApiKey3.Location = new Point(643, 128);
        Button_SaveApiKey3.Name = "Button_SaveApiKey3";
        Button_SaveApiKey3.Size = new Size(75, 23);
        Button_SaveApiKey3.TabIndex = 14;
        Button_SaveApiKey3.Text = "Save";
        Button_SaveApiKey3.UseVisualStyleBackColor = true;
        Button_SaveApiKey3.Click += Button_SaveApiKey_Click;
        // 
        // Button_ValidateApiKey3
        // 
        Button_ValidateApiKey3.Location = new Point(495, 128);
        Button_ValidateApiKey3.Name = "Button_ValidateApiKey3";
        Button_ValidateApiKey3.Size = new Size(132, 23);
        Button_ValidateApiKey3.TabIndex = 13;
        Button_ValidateApiKey3.Text = "Validate";
        Button_ValidateApiKey3.UseVisualStyleBackColor = true;
        Button_ValidateApiKey3.Click += Button_ValidateApiKey_Click;
        // 
        // FixedLabel_ApiKey3
        // 
        FixedLabel_ApiKey3.AutoSize = true;
        FixedLabel_ApiKey3.Location = new Point(19, 132);
        FixedLabel_ApiKey3.Name = "FixedLabel_ApiKey3";
        FixedLabel_ApiKey3.Size = new Size(105, 15);
        FixedLabel_ApiKey3.TabIndex = 12;
        FixedLabel_ApiKey3.Text = "MetalsDev API Key";
        // 
        // TextBox_ApiKey3
        // 
        TextBox_ApiKey3.Location = new Point(168, 129);
        TextBox_ApiKey3.Name = "TextBox_ApiKey3";
        TextBox_ApiKey3.Size = new Size(311, 23);
        TextBox_ApiKey3.TabIndex = 11;
        // 
        // Button_SaveApiKey2
        // 
        Button_SaveApiKey2.Location = new Point(643, 87);
        Button_SaveApiKey2.Name = "Button_SaveApiKey2";
        Button_SaveApiKey2.Size = new Size(75, 23);
        Button_SaveApiKey2.TabIndex = 10;
        Button_SaveApiKey2.Text = "Save";
        Button_SaveApiKey2.UseVisualStyleBackColor = true;
        Button_SaveApiKey2.Click += Button_SaveApiKey_Click;
        // 
        // Button_SaveApiKey1
        // 
        Button_SaveApiKey1.Location = new Point(643, 47);
        Button_SaveApiKey1.Name = "Button_SaveApiKey1";
        Button_SaveApiKey1.Size = new Size(75, 23);
        Button_SaveApiKey1.TabIndex = 9;
        Button_SaveApiKey1.Text = "Save";
        Button_SaveApiKey1.UseVisualStyleBackColor = true;
        Button_SaveApiKey1.Click += Button_SaveApiKey_Click;
        // 
        // Label_StatusApiKey2
        // 
        Label_StatusApiKey2.AutoSize = true;
        Label_StatusApiKey2.Location = new Point(747, 94);
        Label_StatusApiKey2.Name = "Label_StatusApiKey2";
        Label_StatusApiKey2.Size = new Size(0, 15);
        Label_StatusApiKey2.TabIndex = 8;
        // 
        // Label_StatusApiKey1
        // 
        Label_StatusApiKey1.AutoSize = true;
        Label_StatusApiKey1.Location = new Point(748, 51);
        Label_StatusApiKey1.Name = "Label_StatusApiKey1";
        Label_StatusApiKey1.Size = new Size(0, 15);
        Label_StatusApiKey1.TabIndex = 7;
        // 
        // ToolStripStatusLabel_ApiKeyTab
        // 
        ToolStripStatusLabel_ApiKeyTab.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel_ApiKey });
        ToolStripStatusLabel_ApiKeyTab.Location = new Point(3, 505);
        ToolStripStatusLabel_ApiKeyTab.Name = "ToolStripStatusLabel_ApiKeyTab";
        ToolStripStatusLabel_ApiKeyTab.Size = new Size(1356, 22);
        ToolStripStatusLabel_ApiKeyTab.TabIndex = 6;
        // 
        // ToolStripStatusLabel_ApiKey
        // 
        ToolStripStatusLabel_ApiKey.Name = "ToolStripStatusLabel_ApiKey";
        ToolStripStatusLabel_ApiKey.Size = new Size(10, 17);
        ToolStripStatusLabel_ApiKey.Text = " ";
        // 
        // Button_ValidateApiKey2
        // 
        Button_ValidateApiKey2.Location = new Point(495, 86);
        Button_ValidateApiKey2.Name = "Button_ValidateApiKey2";
        Button_ValidateApiKey2.Size = new Size(132, 23);
        Button_ValidateApiKey2.TabIndex = 5;
        Button_ValidateApiKey2.Text = "Validate";
        Button_ValidateApiKey2.UseVisualStyleBackColor = true;
        Button_ValidateApiKey2.Click += Button_ValidateApiKey_Click;
        // 
        // Button_ValidateApiKey1
        // 
        Button_ValidateApiKey1.Location = new Point(495, 47);
        Button_ValidateApiKey1.Name = "Button_ValidateApiKey1";
        Button_ValidateApiKey1.Size = new Size(132, 23);
        Button_ValidateApiKey1.TabIndex = 4;
        Button_ValidateApiKey1.Text = "Validate";
        Button_ValidateApiKey1.UseVisualStyleBackColor = true;
        Button_ValidateApiKey1.Click += Button_ValidateApiKey_Click;
        // 
        // FixedLabel_ApiKey2
        // 
        FixedLabel_ApiKey2.AutoSize = true;
        FixedLabel_ApiKey2.Location = new Point(19, 95);
        FixedLabel_ApiKey2.Name = "FixedLabel_ApiKey2";
        FixedLabel_ApiKey2.Size = new Size(137, 15);
        FixedLabel_ApiKey2.TabIndex = 3;
        FixedLabel_ApiKey2.Text = "CurrencyBeacon API Key";
        // 
        // FixedLabel_ApiKey1
        // 
        FixedLabel_ApiKey1.AutoSize = true;
        FixedLabel_ApiKey1.Location = new Point(19, 50);
        FixedLabel_ApiKey1.Name = "FixedLabel_ApiKey1";
        FixedLabel_ApiKey1.Size = new Size(111, 15);
        FixedLabel_ApiKey1.TabIndex = 2;
        FixedLabel_ApiKey1.Text = "MarketData API Key";
        // 
        // TextBox_ApiKey2
        // 
        TextBox_ApiKey2.Location = new Point(168, 87);
        TextBox_ApiKey2.Name = "TextBox_ApiKey2";
        TextBox_ApiKey2.Size = new Size(311, 23);
        TextBox_ApiKey2.TabIndex = 1;
        // 
        // TextBox_ApiKey1
        // 
        TextBox_ApiKey1.Location = new Point(168, 47);
        TextBox_ApiKey1.Name = "TextBox_ApiKey1";
        TextBox_ApiKey1.Size = new Size(311, 23);
        TextBox_ApiKey1.TabIndex = 0;
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
        MainMenuBlockPanel.ResumeLayout(false);
        MainMenuBlockPanel.PerformLayout();
        statusStrip2.ResumeLayout(false);
        statusStrip2.PerformLayout();
        TabPage2.ResumeLayout(false);
        TabPage2.PerformLayout();
        ToolStripStatusLabel_ApiKeyTab.ResumeLayout(false);
        ToolStripStatusLabel_ApiKeyTab.PerformLayout();
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
	private ComboBox ComboBox_SelectedCurrency;
	private Label Label_CurrentValue;
	private Label FixedTable_CurrentValue;
	private Label Label_TotalInvested;
	private Label FixedLabel_TotalInvested;
	private TabControl TabControl;
	private TabPage TabPage1;
	private TabPage TabPage2;
	private StatusStrip ToolStripStatusLabel_ApiKeyTab;
	private ToolStripStatusLabel ToolStripStatusLabel_ApiKey;
	private Button Button_ValidateApiKey2;
	private Button Button_ValidateApiKey1;
	private Label FixedLabel_ApiKey2;
	private Label FixedLabel_ApiKey1;
	private TextBox TextBox_ApiKey2;
	private TextBox TextBox_ApiKey1;
	private StatusStrip statusStrip2;
	private ToolStripStatusLabel ToolStripStatusLabel_MainMenu;
	private Label Label_StatusApiKey2;
	private Label Label_StatusApiKey1;
	private LinkLabel linkLabel1;
	private Button Button_SaveApiKey2;
	private Button Button_SaveApiKey1;
	private Panel MainMenuBlockPanel;
	private Label MainMenuBlockLabel;
    private Button Button_SavePortfolios;
    private Button Button_SaveApiKey3;
    private Button Button_ValidateApiKey3;
    private Label FixedLabel_ApiKey3;
    private TextBox TextBox_ApiKey3;
    private Label Label_StatusApiKey3;
    private Label label1;
    private DataGridView dataGridView1;
    private BindingSource portfolioBindingSource1;
    private DataGridViewTextBoxColumn column1;
    private DataGridViewTextBoxColumn column2;
    private Button Button_ShowPortfolioDetails;
}
