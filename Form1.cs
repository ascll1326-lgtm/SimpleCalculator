

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
        private void NumberButton_Click(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button btn)
            {
                currentNumber += btn.Text;
                txtCalculation.Text += btn.Text;
            }
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;

            num1 = double.Parse(currentNumber);
            op = btn.Text;

            txtCalculation.Text += " " + op + " ";
            currentNumber = "";
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
                
            }
            txtCalculation.Text += " = " + result.ToString();
            txtResult.Text = result.ToString();
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
