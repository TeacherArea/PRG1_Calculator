namespace PRG1_Calculator
{
    public partial class Form_Calc : Form
    {
        private double accumulator = 0;
        private string currentInput = "";
        private string operation = "";

        public Form_Calc()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtB_Show.Text = currentInput;
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            if (currentInput == "")
            {
                txtB_Show.Text = "Ange ett nummer först";
                return;
            }

            Button button = (Button)sender;
            operation = button.Text;
            if (!double.TryParse(currentInput, out accumulator))
            {
                txtB_Show.Text = "Ogiltig inmatning";
                return;
            }
            currentInput = "";
            txtB_Show.Text += button.Text;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            double secondOperand;
            if (!double.TryParse(currentInput, out secondOperand))
            {
                txtB_Show.Text = "Ogiltig inmatning";
                return;
            }

            switch (operation)
            {
                case "+":
                    accumulator += secondOperand;
                    break;
                case "-":
                    accumulator -= secondOperand;
                    break;
                case "/":
                    if (secondOperand == 0)
                    {
                        txtB_Show.Text = "Fel: Division med noll";
                        return;
                    }
                    accumulator /= secondOperand;
                    break;
                case "*":
                    accumulator *= secondOperand;
                    break;
            }

            txtB_Show.Text = accumulator.ToString();
            currentInput = "";
            accumulator = 0;
            operation = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            currentInput = "";
            accumulator = 0;
            operation = "";
            txtB_Show.Text = "0";
        }
    }
}
