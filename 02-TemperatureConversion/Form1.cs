namespace _02_TemperatureConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNumber_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtInput.Text += btn.Text;
        }
        private void rbtnCtoF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnFtoC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtInput.Text, out double value))
            {
                double result;
                string output = "";

                if (rbtnCtoF.Checked)
                {
                    result = (9.0 / 5.0) * value + 32;
                    output = $"{value}℃ = {result:F1}℉";
                }
                else if (rbtnFtoC.Checked)
                {
                    result = (value - 32) * 5.0 / 9.0;
                    output = $"{value}℉ = {result:F1}℃";
                }

                lblResult.Text = "結果：" + output;
            }
            else
            {
                MessageBox.Show("請輸入有效數字！");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}