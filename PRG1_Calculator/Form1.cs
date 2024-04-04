namespace PRG1_Calculator
{
    public partial class Form_Calculator : Form
    {
        private double accumulator = 0;
        private string operation = "";
        private string buttonInput = "";
        private double operand = 0;

        public Form_Calculator()
        {
            InitializeComponent();
            txtB_Result.Text = "0";
        }

  
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            buttonInput += button.Text;

            if (txtB_Calculations.Text == "0") txtB_Calculations.Text = "";

            txtB_Calculations.Text += button.Text;
            txtB_Result.Text = accumulator.ToString();
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            if(accumulator != 0)
            {
                operand = accumulator;
            }
            else if (!double.TryParse(buttonInput, out operand))
            {
                txtB_Result.Text = "Ogiltig inmatning";
                return;
            }

            if (accumulator != 0 ||  operation != "")
            {
                Calculate();
            }
            else
            {
                accumulator = operand; // för att få minus och gånger att fungera, där accumulator initialt inte kan vara 0
            }

            Button button = (Button)sender;
            operation = button.Text;

            buttonInput = "";
            operand = 0;

            txtB_Calculations.Text += " " + operation + " ";
            txtB_Result.Text = accumulator.ToString();
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(buttonInput, out operand))
            {
                txtB_Calculations.Text = "Ingen ny inmatning gjord.";
                return;
            }

            Calculate();

            txtB_Result.Text = accumulator.ToString();

            operation = "";
            buttonInput = "";
            operand = 0;
        }

        private void Calculate()
        {
            switch (operation)
            {
                case "+":
                    accumulator += operand;
                    break;
                case "-":
                    accumulator -= operand;
                    break;
                case "/":
                    if (operand == 0)
                    {
                        MessageBox.Show("Fel!", "Division med noll", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btn_clear.PerformClick();
                        return;
                    }
                    accumulator /= operand;
                    break;
                case "*":
                    accumulator *= operand;
                    break;
            }
            operand = 0;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtB_Calculations.Text = "";
            txtB_Result.Text = "0";
            operand = 0;
            accumulator = 0;
            operation = "";
            buttonInput = "";
        }

        private void btn_storeInMemory_Click(object sender, EventArgs e)
        {
            txtB_Calculations.Text = "Kommande funktion";
        }

        private void btn_catchFromMemory_Click(object sender, EventArgs e)
        {
            txtB_Calculations.Text = "Kommande funktion";
        }
    }
}
