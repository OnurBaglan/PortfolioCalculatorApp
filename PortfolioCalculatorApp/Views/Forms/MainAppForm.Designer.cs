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
		ListBox_Portfolios = new ListBox();
		Button_AddNewPortfolio = new Button();
		Button_DeleteSelectedPortfolio = new Button();
		FixedLabel_PortfolioList = new Label();
		GroupBox_PortfolioDetails = new GroupBox();
		linkLabel1 = new LinkLabel();
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
		statusStrip2 = new StatusStrip();
		ToolStripStatusLabel_MainMenu = new ToolStripStatusLabel();
		TabPage2 = new TabPage();
		Button_APIKeySave2 = new Button();
		Button_APIKeySave1 = new Button();
		Label_APIKey2Status = new Label();
		Label_APIKey1Status = new Label();
		statusStrip1 = new StatusStrip();
		ToolStripStatusLabel_APIKey = new ToolStripStatusLabel();
		Button_APIKeyValidate2 = new Button();
		Button_APIKeyValidate1 = new Button();
		FixedLabel_APIKey2 = new Label();
		FixedLabel_APIKey1 = new Label();
		TextBox_APIKey2 = new TextBox();
		TextBox_APIKey1 = new TextBox();
		GroupBox_EarnLossInfo.SuspendLayout();
		TabControl.SuspendLayout();
		TabPage1.SuspendLayout();
		statusStrip2.SuspendLayout();
		TabPage2.SuspendLayout();
		statusStrip1.SuspendLayout();
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
		Button_AddNewPortfolio.Size = new Size(75, 68);
		Button_AddNewPortfolio.TabIndex = 1;
		Button_AddNewPortfolio.Text = "Add New Portfolio";
		Button_AddNewPortfolio.UseVisualStyleBackColor = true;
		// 
		// Button_DeleteSelectedPortfolio
		// 
		Button_DeleteSelectedPortfolio.Location = new Point(1282, 256);
		Button_DeleteSelectedPortfolio.Name = "Button_DeleteSelectedPortfolio";
		Button_DeleteSelectedPortfolio.Size = new Size(75, 68);
		Button_DeleteSelectedPortfolio.TabIndex = 2;
		Button_DeleteSelectedPortfolio.Text = "Delete Selected Portfolio";
		Button_DeleteSelectedPortfolio.UseVisualStyleBackColor = true;
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
		GroupBox_PortfolioDetails.Location = new Point(8, 31);
		GroupBox_PortfolioDetails.Name = "GroupBox_PortfolioDetails";
		GroupBox_PortfolioDetails.Size = new Size(952, 219);
		GroupBox_PortfolioDetails.TabIndex = 4;
		GroupBox_PortfolioDetails.TabStop = false;
		GroupBox_PortfolioDetails.Text = "Portfolio Details";
		// 
		// linkLabel1
		// 
		linkLabel1.AutoSize = true;
		linkLabel1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
		linkLabel1.Location = new Point(308, -55);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new Size(784, 86);
		linkLabel1.TabIndex = 1;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "Please enter valid API keys";
		linkLabel1.Visible = false;
		// 
		// GroupBox_EarnLossInfo
		// 
		GroupBox_EarnLossInfo.Controls.Add(linkLabel1);
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
		ToolStripStatusLabel_MainMenu.Size = new Size(117, 17);
		ToolStripStatusLabel_MainMenu.Text = "API Keys status show";
		// 
		// TabPage2
		// 
		TabPage2.Controls.Add(Button_APIKeySave2);
		TabPage2.Controls.Add(Button_APIKeySave1);
		TabPage2.Controls.Add(Label_APIKey2Status);
		TabPage2.Controls.Add(Label_APIKey1Status);
		TabPage2.Controls.Add(statusStrip1);
		TabPage2.Controls.Add(Button_APIKeyValidate2);
		TabPage2.Controls.Add(Button_APIKeyValidate1);
		TabPage2.Controls.Add(FixedLabel_APIKey2);
		TabPage2.Controls.Add(FixedLabel_APIKey1);
		TabPage2.Controls.Add(TextBox_APIKey2);
		TabPage2.Controls.Add(TextBox_APIKey1);
		TabPage2.Location = new Point(4, 24);
		TabPage2.Name = "TabPage2";
		TabPage2.Padding = new Padding(3);
		TabPage2.Size = new Size(1362, 530);
		TabPage2.TabIndex = 1;
		TabPage2.Text = "API Key";
		TabPage2.UseVisualStyleBackColor = true;
		// 
		// Button_APIKeySave2
		// 
		Button_APIKeySave2.Location = new Point(643, 87);
		Button_APIKeySave2.Name = "Button_APIKeySave2";
		Button_APIKeySave2.Size = new Size(75, 23);
		Button_APIKeySave2.TabIndex = 10;
		Button_APIKeySave2.Text = "Save";
		Button_APIKeySave2.UseVisualStyleBackColor = true;
		// 
		// Button_APIKeySave1
		// 
		Button_APIKeySave1.Location = new Point(643, 47);
		Button_APIKeySave1.Name = "Button_APIKeySave1";
		Button_APIKeySave1.Size = new Size(75, 23);
		Button_APIKeySave1.TabIndex = 9;
		Button_APIKeySave1.Text = "Save";
		Button_APIKeySave1.UseVisualStyleBackColor = true;
		// 
		// Label_APIKey2Status
		// 
		Label_APIKey2Status.AutoSize = true;
		Label_APIKey2Status.Location = new Point(747, 94);
		Label_APIKey2Status.Name = "Label_APIKey2Status";
		Label_APIKey2Status.Size = new Size(61, 15);
		Label_APIKey2Status.TabIndex = 8;
		Label_APIKey2Status.Text = "Key Status";
		// 
		// Label_APIKey1Status
		// 
		Label_APIKey1Status.AutoSize = true;
		Label_APIKey1Status.Location = new Point(748, 51);
		Label_APIKey1Status.Name = "Label_APIKey1Status";
		Label_APIKey1Status.Size = new Size(60, 15);
		Label_APIKey1Status.TabIndex = 7;
		Label_APIKey1Status.Text = "Key status";
		// 
		// statusStrip1
		// 
		statusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel_APIKey });
		statusStrip1.Location = new Point(3, 505);
		statusStrip1.Name = "statusStrip1";
		statusStrip1.Size = new Size(1356, 22);
		statusStrip1.TabIndex = 6;
		// 
		// ToolStripStatusLabel_APIKey
		// 
		ToolStripStatusLabel_APIKey.Name = "ToolStripStatusLabel_APIKey";
		ToolStripStatusLabel_APIKey.Size = new Size(117, 17);
		ToolStripStatusLabel_APIKey.Text = "API Keys status show";
		// 
		// Button_APIKeyValidate2
		// 
		Button_APIKeyValidate2.Location = new Point(495, 86);
		Button_APIKeyValidate2.Name = "Button_APIKeyValidate2";
		Button_APIKeyValidate2.Size = new Size(132, 23);
		Button_APIKeyValidate2.TabIndex = 5;
		Button_APIKeyValidate2.Text = "Validate";
		Button_APIKeyValidate2.UseVisualStyleBackColor = true;
		Button_APIKeyValidate2.Click += Button_APIKeyValidate2_Click;
		// 
		// Button_APIKeyValidate1
		// 
		Button_APIKeyValidate1.Location = new Point(495, 47);
		Button_APIKeyValidate1.Name = "Button_APIKeyValidate1";
		Button_APIKeyValidate1.Size = new Size(132, 23);
		Button_APIKeyValidate1.TabIndex = 4;
		Button_APIKeyValidate1.Text = "Validate";
		Button_APIKeyValidate1.UseVisualStyleBackColor = true;
		Button_APIKeyValidate1.Click += Button_APIKeyValidate1_Click;
		// 
		// FixedLabel_APIKey2
		// 
		FixedLabel_APIKey2.AutoSize = true;
		FixedLabel_APIKey2.Location = new Point(19, 95);
		FixedLabel_APIKey2.Name = "FixedLabel_APIKey2";
		FixedLabel_APIKey2.Size = new Size(137, 15);
		FixedLabel_APIKey2.TabIndex = 3;
		FixedLabel_APIKey2.Text = "CurrencyBeacon API Key";
		// 
		// FixedLabel_APIKey1
		// 
		FixedLabel_APIKey1.AutoSize = true;
		FixedLabel_APIKey1.Location = new Point(19, 50);
		FixedLabel_APIKey1.Name = "FixedLabel_APIKey1";
		FixedLabel_APIKey1.Size = new Size(111, 15);
		FixedLabel_APIKey1.TabIndex = 2;
		FixedLabel_APIKey1.Text = "MarketData API Key";
		// 
		// TextBox_APIKey2
		// 
		TextBox_APIKey2.Location = new Point(168, 87);
		TextBox_APIKey2.Name = "TextBox_APIKey2";
		TextBox_APIKey2.Size = new Size(311, 23);
		TextBox_APIKey2.TabIndex = 1;
		// 
		// TextBox_APIKey1
		// 
		TextBox_APIKey1.Location = new Point(168, 47);
		TextBox_APIKey1.Name = "TextBox_APIKey1";
		TextBox_APIKey1.Size = new Size(311, 23);
		TextBox_APIKey1.TabIndex = 0;
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
		GroupBox_EarnLossInfo.ResumeLayout(false);
		GroupBox_EarnLossInfo.PerformLayout();
		TabControl.ResumeLayout(false);
		TabPage1.ResumeLayout(false);
		TabPage1.PerformLayout();
		statusStrip2.ResumeLayout(false);
		statusStrip2.PerformLayout();
		TabPage2.ResumeLayout(false);
		TabPage2.PerformLayout();
		statusStrip1.ResumeLayout(false);
		statusStrip1.PerformLayout();
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
	private StatusStrip statusStrip1;
	private ToolStripStatusLabel ToolStripStatusLabel_APIKey;
	private Button Button_APIKeyValidate2;
	private Button Button_APIKeyValidate1;
	private Label FixedLabel_APIKey2;
	private Label FixedLabel_APIKey1;
	private TextBox TextBox_APIKey2;
	private TextBox TextBox_APIKey1;
	private StatusStrip statusStrip2;
	private ToolStripStatusLabel ToolStripStatusLabel_MainMenu;
	private Label Label_APIKey2Status;
	private Label Label_APIKey1Status;
	private LinkLabel linkLabel1;
	private Button Button_APIKeySave2;
	private Button Button_APIKeySave1;
}
