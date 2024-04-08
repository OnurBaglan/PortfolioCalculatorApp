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
        statusStrip2.SuspendLayout();
        TabPage2.SuspendLayout();
        ToolStripStatusLabel_ApiKeyTab.SuspendLayout();
        SuspendLayout();
        // 
        // ListBox_Portfolios
        // 
        ListBox_Portfolios.FormattingEnabled = true;
        ListBox_Portfolios.Location = new Point(1130, 48);
        ListBox_Portfolios.Margin = new Padding(3, 4, 3, 4);
        ListBox_Portfolios.Name = "ListBox_Portfolios";
        ListBox_Portfolios.Size = new Size(420, 284);
        ListBox_Portfolios.TabIndex = 0;
        // 
        // Button_AddNewPortfolio
        // 
        Button_AddNewPortfolio.Location = new Point(1130, 341);
        Button_AddNewPortfolio.Margin = new Padding(3, 4, 3, 4);
        Button_AddNewPortfolio.Name = "Button_AddNewPortfolio";
        Button_AddNewPortfolio.Size = new Size(125, 57);
        Button_AddNewPortfolio.TabIndex = 1;
        Button_AddNewPortfolio.Text = "Add New Portfolio";
        Button_AddNewPortfolio.UseVisualStyleBackColor = true;
        Button_AddNewPortfolio.Click += Button_AddNewPortfolio_Click;
        // 
        // Button_DeleteSelectedPortfolio
        // 
        Button_DeleteSelectedPortfolio.Location = new Point(1440, 341);
        Button_DeleteSelectedPortfolio.Margin = new Padding(3, 4, 3, 4);
        Button_DeleteSelectedPortfolio.Name = "Button_DeleteSelectedPortfolio";
        Button_DeleteSelectedPortfolio.Size = new Size(113, 56);
        Button_DeleteSelectedPortfolio.TabIndex = 2;
        Button_DeleteSelectedPortfolio.Text = "Delete Selected Portfolio";
        Button_DeleteSelectedPortfolio.UseVisualStyleBackColor = true;
        Button_DeleteSelectedPortfolio.Click += Button_DeleteSelectedPortfolio_Click;
        // 
        // FixedLabel_PortfolioList
        // 
        FixedLabel_PortfolioList.AutoSize = true;
        FixedLabel_PortfolioList.Location = new Point(1466, 24);
        FixedLabel_PortfolioList.Name = "FixedLabel_PortfolioList";
        FixedLabel_PortfolioList.Size = new Size(92, 20);
        FixedLabel_PortfolioList.TabIndex = 3;
        FixedLabel_PortfolioList.Text = "Portfolio List";
        // 
        // GroupBox_PortfolioDetails
        // 
        GroupBox_PortfolioDetails.Controls.Add(dataGridView1);
        GroupBox_PortfolioDetails.Controls.Add(label1);
        GroupBox_PortfolioDetails.Location = new Point(9, 41);
        GroupBox_PortfolioDetails.Margin = new Padding(3, 4, 3, 4);
        GroupBox_PortfolioDetails.Name = "GroupBox_PortfolioDetails";
        GroupBox_PortfolioDetails.Padding = new Padding(3, 4, 3, 4);
        GroupBox_PortfolioDetails.Size = new Size(1088, 292);
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
        dataGridView1.Location = new Point(29, 49);
        dataGridView1.Margin = new Padding(3, 4, 3, 4);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(1031, 172);
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
        label1.Location = new Point(29, 25);
        label1.Name = "label1";
        label1.Size = new Size(144, 20);
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
        GroupBox_EarnLossInfo.Location = new Point(9, 341);
        GroupBox_EarnLossInfo.Margin = new Padding(3, 4, 3, 4);
        GroupBox_EarnLossInfo.Name = "GroupBox_EarnLossInfo";
        GroupBox_EarnLossInfo.Padding = new Padding(3, 4, 3, 4);
        GroupBox_EarnLossInfo.Size = new Size(1088, 295);
        GroupBox_EarnLossInfo.TabIndex = 5;
        GroupBox_EarnLossInfo.TabStop = false;
        GroupBox_EarnLossInfo.Text = "Earn/Loss Info";
        // 
        // Label_CurrentValue
        // 
        Label_CurrentValue.AutoSize = true;
        Label_CurrentValue.Location = new Point(717, 72);
        Label_CurrentValue.Name = "Label_CurrentValue";
        Label_CurrentValue.Size = new Size(106, 20);
        Label_CurrentValue.TabIndex = 9;
        Label_CurrentValue.Text = "156151 dollars";
        // 
        // FixedTable_CurrentValue
        // 
        FixedTable_CurrentValue.AutoSize = true;
        FixedTable_CurrentValue.Location = new Point(691, 41);
        FixedTable_CurrentValue.Name = "FixedTable_CurrentValue";
        FixedTable_CurrentValue.Size = new Size(167, 20);
        FixedTable_CurrentValue.TabIndex = 8;
        FixedTable_CurrentValue.Text = "Current Value as of date";
        // 
        // Label_TotalInvested
        // 
        Label_TotalInvested.AutoSize = true;
        Label_TotalInvested.Location = new Point(474, 72);
        Label_TotalInvested.Name = "Label_TotalInvested";
        Label_TotalInvested.Size = new Size(106, 20);
        Label_TotalInvested.TabIndex = 7;
        Label_TotalInvested.Text = "123456 dollars";
        // 
        // FixedLabel_TotalInvested
        // 
        FixedLabel_TotalInvested.AutoSize = true;
        FixedLabel_TotalInvested.Location = new Point(477, 41);
        FixedLabel_TotalInvested.Name = "FixedLabel_TotalInvested";
        FixedLabel_TotalInvested.Size = new Size(101, 20);
        FixedLabel_TotalInvested.TabIndex = 6;
        FixedLabel_TotalInvested.Text = "Total invested";
        // 
        // Label_EarnLossRatio
        // 
        Label_EarnLossRatio.AutoSize = true;
        Label_EarnLossRatio.Location = new Point(214, 72);
        Label_EarnLossRatio.Name = "Label_EarnLossRatio";
        Label_EarnLossRatio.Size = new Size(37, 20);
        Label_EarnLossRatio.TabIndex = 5;
        Label_EarnLossRatio.Text = "%30";
        // 
        // FixedLabel_Ratio
        // 
        FixedLabel_Ratio.AutoSize = true;
        FixedLabel_Ratio.Location = new Point(214, 41);
        FixedLabel_Ratio.Name = "FixedLabel_Ratio";
        FixedLabel_Ratio.Size = new Size(144, 20);
        FixedLabel_Ratio.TabIndex = 2;
        FixedLabel_Ratio.Text = "Your Earn/Loss Ratio";
        // 
        // FixedLabel_SelectedCurrency
        // 
        FixedLabel_SelectedCurrency.AutoSize = true;
        FixedLabel_SelectedCurrency.Location = new Point(7, 37);
        FixedLabel_SelectedCurrency.Name = "FixedLabel_SelectedCurrency";
        FixedLabel_SelectedCurrency.Size = new Size(110, 20);
        FixedLabel_SelectedCurrency.TabIndex = 1;
        FixedLabel_SelectedCurrency.Text = "Select Currency";
        // 
        // ComboBox_Currencies
        // 
        ComboBox_Currencies.FormattingEnabled = true;
        ComboBox_Currencies.Location = new Point(7, 61);
        ComboBox_Currencies.Margin = new Padding(3, 4, 3, 4);
        ComboBox_Currencies.Name = "ComboBox_Currencies";
        ComboBox_Currencies.Size = new Size(138, 28);
        ComboBox_Currencies.TabIndex = 0;
        // 
        // TabControl
        // 
        TabControl.Controls.Add(TabPage1);
        TabControl.Controls.Add(TabPage2);
        TabControl.Dock = DockStyle.Fill;
        TabControl.Location = new Point(0, 0);
        TabControl.Margin = new Padding(3, 4, 3, 4);
        TabControl.Name = "TabControl";
        TabControl.SelectedIndex = 0;
        TabControl.Size = new Size(1566, 744);
        TabControl.TabIndex = 6;
        TabControl.TabStop = false;
        // 
        // TabPage1
        // 
        TabPage1.BackColor = Color.Transparent;
        TabPage1.Controls.Add(Button_ShowPortfolioDetails);
        TabPage1.Controls.Add(Button_SavePortfolios);
        TabPage1.Controls.Add(statusStrip2);
        TabPage1.Controls.Add(GroupBox_EarnLossInfo);
        TabPage1.Controls.Add(FixedLabel_PortfolioList);
        TabPage1.Controls.Add(GroupBox_PortfolioDetails);
        TabPage1.Controls.Add(Button_DeleteSelectedPortfolio);
        TabPage1.Controls.Add(ListBox_Portfolios);
        TabPage1.Controls.Add(Button_AddNewPortfolio);
        TabPage1.Location = new Point(4, 29);
        TabPage1.Margin = new Padding(3, 4, 3, 4);
        TabPage1.Name = "TabPage1";
        TabPage1.Padding = new Padding(3, 4, 3, 4);
        TabPage1.Size = new Size(1558, 711);
        TabPage1.TabIndex = 0;
        TabPage1.Text = "Main Menu";
        // 
        // Button_ShowPortfolioDetails
        // 
        Button_ShowPortfolioDetails.Location = new Point(1133, 407);
        Button_ShowPortfolioDetails.Margin = new Padding(3, 4, 3, 4);
        Button_ShowPortfolioDetails.Name = "Button_ShowPortfolioDetails";
        Button_ShowPortfolioDetails.Size = new Size(421, 99);
        Button_ShowPortfolioDetails.TabIndex = 3;
        Button_ShowPortfolioDetails.Text = "Show details of selected portfolio";
        Button_ShowPortfolioDetails.UseVisualStyleBackColor = true;
        Button_ShowPortfolioDetails.Click += Button_ShowPortfolioDetails_Click;
        // 
        // Button_SavePortfolios
        // 
        Button_SavePortfolios.Location = new Point(1262, 341);
        Button_SavePortfolios.Margin = new Padding(3, 4, 3, 4);
        Button_SavePortfolios.Name = "Button_SavePortfolios";
        Button_SavePortfolios.Size = new Size(171, 56);
        Button_SavePortfolios.TabIndex = 7;
        Button_SavePortfolios.Text = "Save Portfolios";
        Button_SavePortfolios.UseVisualStyleBackColor = true;
        Button_SavePortfolios.Click += Button_SavePortfolios_Click;
        // 
        // statusStrip2
        // 
        statusStrip2.ImageScalingSize = new Size(20, 20);
        statusStrip2.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel_MainMenu });
        statusStrip2.Location = new Point(3, 681);
        statusStrip2.Name = "statusStrip2";
        statusStrip2.Padding = new Padding(1, 0, 16, 0);
        statusStrip2.Size = new Size(1552, 26);
        statusStrip2.TabIndex = 6;
        statusStrip2.Text = "statusStrip2";
        // 
        // ToolStripStatusLabel_MainMenu
        // 
        ToolStripStatusLabel_MainMenu.Name = "ToolStripStatusLabel_MainMenu";
        ToolStripStatusLabel_MainMenu.Size = new Size(13, 20);
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
        TabPage2.Location = new Point(4, 29);
        TabPage2.Margin = new Padding(3, 4, 3, 4);
        TabPage2.Name = "TabPage2";
        TabPage2.Padding = new Padding(3, 4, 3, 4);
        TabPage2.Size = new Size(1558, 711);
        TabPage2.TabIndex = 1;
        TabPage2.Text = "API Key";
        TabPage2.UseVisualStyleBackColor = true;
        // 
        // Label_StatusApiKey3
        // 
        Label_StatusApiKey3.AutoSize = true;
        Label_StatusApiKey3.Location = new Point(865, 172);
        Label_StatusApiKey3.Name = "Label_StatusApiKey3";
        Label_StatusApiKey3.Size = new Size(0, 20);
        Label_StatusApiKey3.TabIndex = 15;
        // 
        // Button_SaveApiKey3
        // 
        Button_SaveApiKey3.Location = new Point(735, 171);
        Button_SaveApiKey3.Margin = new Padding(3, 4, 3, 4);
        Button_SaveApiKey3.Name = "Button_SaveApiKey3";
        Button_SaveApiKey3.Size = new Size(86, 31);
        Button_SaveApiKey3.TabIndex = 14;
        Button_SaveApiKey3.Text = "Save";
        Button_SaveApiKey3.UseVisualStyleBackColor = true;
        Button_SaveApiKey3.Click += Button_SaveApiKey_Click;
        // 
        // Button_ValidateApiKey3
        // 
        Button_ValidateApiKey3.Location = new Point(566, 171);
        Button_ValidateApiKey3.Margin = new Padding(3, 4, 3, 4);
        Button_ValidateApiKey3.Name = "Button_ValidateApiKey3";
        Button_ValidateApiKey3.Size = new Size(151, 31);
        Button_ValidateApiKey3.TabIndex = 13;
        Button_ValidateApiKey3.Text = "Validate";
        Button_ValidateApiKey3.UseVisualStyleBackColor = true;
        Button_ValidateApiKey3.Click += Button_ValidateApiKey_Click;
        // 
        // FixedLabel_ApiKey3
        // 
        FixedLabel_ApiKey3.AutoSize = true;
        FixedLabel_ApiKey3.Location = new Point(22, 176);
        FixedLabel_ApiKey3.Name = "FixedLabel_ApiKey3";
        FixedLabel_ApiKey3.Size = new Size(133, 20);
        FixedLabel_ApiKey3.TabIndex = 12;
        FixedLabel_ApiKey3.Text = "MetalsDev API Key";
        // 
        // TextBox_ApiKey3
        // 
        TextBox_ApiKey3.Location = new Point(192, 172);
        TextBox_ApiKey3.Margin = new Padding(3, 4, 3, 4);
        TextBox_ApiKey3.Name = "TextBox_ApiKey3";
        TextBox_ApiKey3.Size = new Size(355, 27);
        TextBox_ApiKey3.TabIndex = 11;
        // 
        // Button_SaveApiKey2
        // 
        Button_SaveApiKey2.Location = new Point(735, 116);
        Button_SaveApiKey2.Margin = new Padding(3, 4, 3, 4);
        Button_SaveApiKey2.Name = "Button_SaveApiKey2";
        Button_SaveApiKey2.Size = new Size(86, 31);
        Button_SaveApiKey2.TabIndex = 10;
        Button_SaveApiKey2.Text = "Save";
        Button_SaveApiKey2.UseVisualStyleBackColor = true;
        Button_SaveApiKey2.Click += Button_SaveApiKey_Click;
        // 
        // Button_SaveApiKey1
        // 
        Button_SaveApiKey1.Location = new Point(735, 63);
        Button_SaveApiKey1.Margin = new Padding(3, 4, 3, 4);
        Button_SaveApiKey1.Name = "Button_SaveApiKey1";
        Button_SaveApiKey1.Size = new Size(86, 31);
        Button_SaveApiKey1.TabIndex = 9;
        Button_SaveApiKey1.Text = "Save";
        Button_SaveApiKey1.UseVisualStyleBackColor = true;
        Button_SaveApiKey1.Click += Button_SaveApiKey_Click;
        // 
        // Label_StatusApiKey2
        // 
        Label_StatusApiKey2.AutoSize = true;
        Label_StatusApiKey2.Location = new Point(854, 125);
        Label_StatusApiKey2.Name = "Label_StatusApiKey2";
        Label_StatusApiKey2.Size = new Size(0, 20);
        Label_StatusApiKey2.TabIndex = 8;
        // 
        // Label_StatusApiKey1
        // 
        Label_StatusApiKey1.AutoSize = true;
        Label_StatusApiKey1.Location = new Point(855, 68);
        Label_StatusApiKey1.Name = "Label_StatusApiKey1";
        Label_StatusApiKey1.Size = new Size(0, 20);
        Label_StatusApiKey1.TabIndex = 7;
        // 
        // ToolStripStatusLabel_ApiKeyTab
        // 
        ToolStripStatusLabel_ApiKeyTab.ImageScalingSize = new Size(20, 20);
        ToolStripStatusLabel_ApiKeyTab.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel_ApiKey });
        ToolStripStatusLabel_ApiKeyTab.Location = new Point(3, 681);
        ToolStripStatusLabel_ApiKeyTab.Name = "ToolStripStatusLabel_ApiKeyTab";
        ToolStripStatusLabel_ApiKeyTab.Padding = new Padding(1, 0, 16, 0);
        ToolStripStatusLabel_ApiKeyTab.Size = new Size(1552, 26);
        ToolStripStatusLabel_ApiKeyTab.TabIndex = 6;
        // 
        // ToolStripStatusLabel_ApiKey
        // 
        ToolStripStatusLabel_ApiKey.Name = "ToolStripStatusLabel_ApiKey";
        ToolStripStatusLabel_ApiKey.Size = new Size(13, 20);
        ToolStripStatusLabel_ApiKey.Text = " ";
        // 
        // Button_ValidateApiKey2
        // 
        Button_ValidateApiKey2.Location = new Point(566, 115);
        Button_ValidateApiKey2.Margin = new Padding(3, 4, 3, 4);
        Button_ValidateApiKey2.Name = "Button_ValidateApiKey2";
        Button_ValidateApiKey2.Size = new Size(151, 31);
        Button_ValidateApiKey2.TabIndex = 5;
        Button_ValidateApiKey2.Text = "Validate";
        Button_ValidateApiKey2.UseVisualStyleBackColor = true;
        Button_ValidateApiKey2.Click += Button_ValidateApiKey_Click;
        // 
        // Button_ValidateApiKey1
        // 
        Button_ValidateApiKey1.Location = new Point(566, 63);
        Button_ValidateApiKey1.Margin = new Padding(3, 4, 3, 4);
        Button_ValidateApiKey1.Name = "Button_ValidateApiKey1";
        Button_ValidateApiKey1.Size = new Size(151, 31);
        Button_ValidateApiKey1.TabIndex = 4;
        Button_ValidateApiKey1.Text = "Validate";
        Button_ValidateApiKey1.UseVisualStyleBackColor = true;
        Button_ValidateApiKey1.Click += Button_ValidateApiKey_Click;
        // 
        // FixedLabel_ApiKey2
        // 
        FixedLabel_ApiKey2.AutoSize = true;
        FixedLabel_ApiKey2.Location = new Point(22, 127);
        FixedLabel_ApiKey2.Name = "FixedLabel_ApiKey2";
        FixedLabel_ApiKey2.Size = new Size(169, 20);
        FixedLabel_ApiKey2.TabIndex = 3;
        FixedLabel_ApiKey2.Text = "CurrencyBeacon API Key";
        // 
        // FixedLabel_ApiKey1
        // 
        FixedLabel_ApiKey1.AutoSize = true;
        FixedLabel_ApiKey1.Location = new Point(22, 67);
        FixedLabel_ApiKey1.Name = "FixedLabel_ApiKey1";
        FixedLabel_ApiKey1.Size = new Size(141, 20);
        FixedLabel_ApiKey1.TabIndex = 2;
        FixedLabel_ApiKey1.Text = "MarketData API Key";
        // 
        // TextBox_ApiKey2
        // 
        TextBox_ApiKey2.Location = new Point(192, 116);
        TextBox_ApiKey2.Margin = new Padding(3, 4, 3, 4);
        TextBox_ApiKey2.Name = "TextBox_ApiKey2";
        TextBox_ApiKey2.Size = new Size(355, 27);
        TextBox_ApiKey2.TabIndex = 1;
        // 
        // TextBox_ApiKey1
        // 
        TextBox_ApiKey1.Location = new Point(192, 63);
        TextBox_ApiKey1.Margin = new Padding(3, 4, 3, 4);
        TextBox_ApiKey1.Name = "TextBox_ApiKey1";
        TextBox_ApiKey1.Size = new Size(355, 27);
        TextBox_ApiKey1.TabIndex = 0;
        // 
        // MainAppForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        AutoSize = true;
        BackColor = SystemColors.AppWorkspace;
        ClientSize = new Size(1566, 744);
        Controls.Add(TabControl);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Margin = new Padding(3, 4, 3, 4);
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
	private ComboBox ComboBox_Currencies;
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
