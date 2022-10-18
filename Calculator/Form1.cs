namespace Calculator
{
    public partial class Form1 : Form
    {
        double num1 = 0, num2 = 0;
        char Operator;
         public Form1()
        {
            InitializeComponent();
        }
        private void addnumber(object sender, EventArgs e)
        {
            var btn = ((Button)sender);
            if (txtResult.Text == "0")
            {
                txtResult.Text = "";
            }
            txtResult.Text += btn.Text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(txtResult.Text);
            if (Operator == '+')
            {
                txtResult.Text = (num1 + num2).ToString();
                num1 = Convert.ToDouble(txtResult.Text);
            }
            else if (Operator == '-')
            {
                txtResult.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(txtResult.Text);
            }
            else if (Operator == 'X')
            {
                txtResult.Text = (num1 * num2).ToString();
                num1 = Convert.ToDouble(txtResult.Text);
            }
            else if (Operator == '/')
            {
                if (txtResult.Text != "0")
                {
                    txtResult.Text = (num1 / num2).ToString();
                    num1 = Convert.ToDouble(txtResult.Text);
                }
                else
                {
                    MessageBox.Show("No se puede dividir por ceso!");
                }
            }
        }

        private void btnPutoff_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 1)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
            else
            {
                txtResult.Text = "0";
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            Operator = '\0';
            txtResult.Text = "0";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains(","))
            {
                txtResult.Text += ",";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtResult.Text);
            num1 *= -1;
            txtResult.Text = num1.ToString();
        }

        private void clickOperator(object sender, EventArgs e)
        {
            var btn = ((Button)sender);
            num1 = Convert.ToDouble(txtResult.Text);
            Operator = Convert.ToChar(btn.Tag);

            if (Operator == '²')
            {
                num1 = Math.Pow(num1, 2);
                txtResult.Text = num1.ToString();
            }
            else if (Operator == '√')
            {
                num1 = Math.Sqrt(num1);
                txtResult.Text = num1.ToString();
            }
            else
            {
                txtResult.Text = "0";
            }
        }
    }
}