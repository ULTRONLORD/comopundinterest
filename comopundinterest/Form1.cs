namespace comopundinterest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double principal = double.Parse(principalTextBox1.Text);
            double rate = double.Parse(rateTextBox2.Text);
            double c = double.Parse(compoundingFrequencyTextBox3.Text);
            double time = double.Parse(timeTextBox4.Text);

            double amount = principal * Math.Pow(1 + (rate / c), c * time);

            resultTestBox5.Text = amount.ToString();


            
        }
    }
} 
