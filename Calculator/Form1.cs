namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSoa.Text);
            double b = double.Parse(txtSob.Text);
            double c = a + b;
            txtKetQua.Text = c.ToString();
        }
    }
}