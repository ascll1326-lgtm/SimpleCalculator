

using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1, num2 = 0;
        string op = "";
        string currentNumber = "";
        bool isNewNumber = false;
        private void NumberButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            if (isNewNumber)
                {
                    currentNumber = btn.Text;
                    isNewNumber = false;
                }
                else
                {
                    currentNumber += btn.Text;
                }

                txtCalculation.Text += btn.Text;
            txtResult.Text += btn.Text;
                
            
            
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;

            

            num1 = double.Parse(currentNumber);
            op = btn.Text;

            txtCalculation.Text += " " + op + " ";

            txtResult.Text = "";

            isNewNumber = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(currentNumber);

            double result = 0;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "×":
                    result = num1 * num2;
                    break;
                case "÷":
                    if (num2 == 0)
                    {
                        MessageBox.Show("0으로 나눌 수 없습니다!");
                        return;
                    }
                    result = num1 / num2;
                    break;

            }
            txtCalculation.Text += " = " + result.ToString();
            txtResult.Text = result.ToString();
            currentNumber = result.ToString();
            isNewNumber = true;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }
        private void txtCalculation_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNumber1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
