namespace WinFormsApp2
{
    public partial class Analizer : Form
    {

        public Analizer()
        {
            InitializeComponent();
        }

        private void analizeButton_Click(object sender, EventArgs e)
        {
            Stats stats = new Stats(textBox.Text);
            resultTextBox.Clear();

            resultTextBox.Text = stats.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            resultTextBox.Clear();
        }
    }
}
