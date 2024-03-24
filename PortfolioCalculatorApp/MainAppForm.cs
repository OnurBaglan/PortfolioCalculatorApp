namespace PortfolioCalculatorApp
{
	public partial class MainAppForm : Form
	{
		AddPortfolioForm addPortfolioForm;

		public MainAppForm()
		{
			InitializeComponent();


		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{


		}

		private void button1_Click(object sender, EventArgs e)
		{
			addPortfolioForm = new AddPortfolioForm();
			addPortfolioForm.Show();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}
	}
}
