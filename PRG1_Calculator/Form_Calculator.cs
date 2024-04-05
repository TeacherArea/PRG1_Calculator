using System.Diagnostics;

namespace PRG1_Calculator
{
    public partial class Form_Calculator : Form
    {
        private double operand = 0;
        private double accumulator = 0;
        private string operation = "";
        private string numberInput = "";
        private string equalSign = "";

        public Form_Calculator()
        {
            InitializeComponent();
            txtB_Result.Text = "0";
        }

  
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            numberInput += button.Text;

            if (txtB_Calculations.Text == "0") txtB_Calculations.Text = "";

            txtB_Calculations.Text += button.Text;
            txtB_Result.Text = accumulator.ToString();
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(numberInput, out operand))
            {
                txtB_Result.Text = "Ogiltig inmatning";
                return;
            }

            if (accumulator != 0 && equalSign == "=")
            {
                operand = accumulator;
            }

            if (accumulator != 0 ||  operation != "")
            {
                Calculate();
            }
            else
            {
                accumulator = operand;
            }

            Button button = (Button)sender;
            operation = button.Text;

            numberInput = "0";
            operand = 0;
            equalSign = "";

            txtB_Calculations.Text += " " + operation + " ";
            txtB_Result.Text = accumulator.ToString();
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            equalSign = button.Text;

            if (!double.TryParse(numberInput, out operand))
            {
                txtB_Calculations.Text = "Ingen ny inmatning gjord.";
                return;
            }

            Calculate();

            txtB_Result.Text = accumulator.ToString();

            operation = "";
            numberInput = "0";
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
            numberInput = "";
            equalSign = "";
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
