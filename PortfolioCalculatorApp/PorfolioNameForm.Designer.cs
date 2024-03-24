namespace PortfolioCalculatorApp
{
	partial class PorfolioNameForm
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
			TextBox_PortfolioName = new TextBox();
			Button_SavePortfolioName = new Button();
			label1 = new Label();
			ToolStripStatusLabel_SavePortfolioName = new ToolStripStatusLabel();
			statusStrip1 = new StatusStrip();
			FixedLabel_EnterPortfolioName = new Label();
			statusStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// TextBox_PortfolioName
			// 
			TextBox_PortfolioName.Location = new Point(97, 41);
			TextBox_PortfolioName.Name = "TextBox_PortfolioName";
			TextBox_PortfolioName.Size = new Size(174, 23);
			TextBox_PortfolioName.TabIndex = 0;
			// 
			// Button_SavePortfolioName
			// 
			Button_SavePortfolioName.Location = new Point(145, 70);
			Button_SavePortfolioName.Name = "Button_SavePortfolioName";
			Button_SavePortfolioName.Size = new Size(75, 23);
			Button_SavePortfolioName.TabIndex = 1;
			Button_SavePortfolioName.Text = "Save";
			Button_SavePortfolioName.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 94);
			label1.Name = "label1";
			label1.Size = new Size(38, 15);
			label1.TabIndex = 2;
			label1.Text = "label1";
			// 
			// ToolStripStatusLabel_SavePortfolioName
			// 
			ToolStripStatusLabel_SavePortfolioName.Name = "ToolStripStatusLabel_SavePortfolioName";
			ToolStripStatusLabel_SavePortfolioName.Size = new Size(65, 17);
			ToolStripStatusLabel_SavePortfolioName.Text = "Save status";
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel_SavePortfolioName });
			statusStrip1.Location = new Point(0, 96);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(371, 22);
			statusStrip1.TabIndex = 3;
			statusStrip1.Text = "statusStrip1";
			// 
			// FixedLabel_EnterPortfolioName
			// 
			FixedLabel_EnterPortfolioName.AutoSize = true;
			FixedLabel_EnterPortfolioName.Location = new Point(126, 23);
			FixedLabel_EnterPortfolioName.Name = "FixedLabel_EnterPortfolioName";
			FixedLabel_EnterPortfolioName.Size = new Size(116, 15);
			FixedLabel_EnterPortfolioName.TabIndex = 4;
			FixedLabel_EnterPortfolioName.Text = "Enter portfolio name";
			// 
			// PorfolioNameForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(371, 118);
			Controls.Add(FixedLabel_EnterPortfolioName);
			Controls.Add(statusStrip1);
			Controls.Add(label1);
			Controls.Add(Button_SavePortfolioName);
			Controls.Add(TextBox_PortfolioName);
			Name = "PorfolioNameForm";
			Text = "PorfolioNameForm";
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox TextBox_PortfolioName;
		private Button Button_SavePortfolioName;
		private Label label1;
		private ToolStripStatusLabel ToolStripStatusLabel_SavePortfolioName;
		private StatusStrip statusStrip1;
		private Label FixedLabel_EnterPortfolioName;
	}
}