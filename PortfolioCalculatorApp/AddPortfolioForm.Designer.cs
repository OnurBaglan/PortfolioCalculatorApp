
namespace PortfolioCalculatorApp
{
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
			dateTimePicker1 = new DateTimePicker();
			comboBox1 = new ComboBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			button1 = new Button();
			button2 = new Button();
			listView1 = new ListView();
			button3 = new Button();
			button4 = new Button();
			numericUpDown1 = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			SuspendLayout();
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(360, 47);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(200, 23);
			dateTimePicker1.TabIndex = 0;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(101, 47);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(121, 23);
			comboBox1.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(101, 29);
			label1.Name = "label1";
			label1.Size = new Size(111, 15);
			label1.TabIndex = 3;
			label1.Text = "Select stock symbol";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(239, 29);
			label2.Name = "label2";
			label2.Size = new Size(29, 15);
			label2.TabIndex = 4;
			label2.Text = "Lots";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(360, 29);
			label3.Name = "label3";
			label3.Size = new Size(81, 15);
			label3.TabIndex = 5;
			label3.Text = "Purchase date";
			// 
			// button1
			// 
			button1.Location = new Point(101, 76);
			button1.Name = "button1";
			button1.Size = new Size(167, 23);
			button1.TabIndex = 6;
			button1.Text = "Add the purchase";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(485, 76);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 7;
			button2.Text = "Reset";
			button2.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			listView1.Location = new Point(81, 181);
			listView1.Name = "listView1";
			listView1.Size = new Size(676, 97);
			listView1.TabIndex = 8;
			listView1.UseCompatibleStateImageBehavior = false;
			// 
			// button3
			// 
			button3.Location = new Point(0, 181);
			button3.Name = "button3";
			button3.Size = new Size(75, 59);
			button3.TabIndex = 9;
			button3.Text = "Delete selected purchase";
			button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			button4.Location = new Point(81, 284);
			button4.Name = "button4";
			button4.Size = new Size(676, 23);
			button4.TabIndex = 10;
			button4.Text = "Save portfolio";
			button4.UseVisualStyleBackColor = true;
			button4.Click += this.button4_Click;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(234, 47);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(88, 23);
			numericUpDown1.TabIndex = 11;
			// 
			// AddPortfolioForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(numericUpDown1);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(listView1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(comboBox1);
			Controls.Add(dateTimePicker1);
			Name = "AddPortfolioForm";
			Text = "Form2";
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		

		#endregion

		private DateTimePicker dateTimePicker1;
		private ComboBox comboBox1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button button1;
		private Button button2;
		private ListView listView1;
		private Button button3;
		private Button button4;
		private NumericUpDown numericUpDown1;
	}
}