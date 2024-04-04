namespace PRG1_Calculator
{
    /// <summary>
    /// Mycket är gjort, men logiken haltar lite. Din uppgift blir att lösa detta, efter 
    /// den gemensamma genomgången! För att därefter lyckas måste du använda Breakpoints
    /// för att se vad som faktiskt finns i de globala variablerna. AI eller youtube är bra,
    /// men inte helt perfekta för uppgiften ... Lycka till!
    /// </summary>
    public partial class Form_Calculator : Form
    {
        private double operand = 0;         // global variabel för inmatat nummer
        private string operation = "";      // global variabel för inmatat + - * eller /
        private double accumulator = 0;     // global variabel för resultatet av beräknignar
        private string buttonInput = "";    // global variabel för ... ja, vadå?

        public Form_Calculator()
        {
            InitializeComponent();
            txtB_Result.Text = "0";
        }

  
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operand += Convert.ToDouble(button.Text); // är det smart att göra detta här?

            txtB_Calculations.Text += button.Text;
            txtB_Result.Text = accumulator.ToString();
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            // för att få minus och gånger att fungera, där främst accumulator initialt inte kan vara 0
            if (accumulator != 0 || operation != "")
            {
                Calculate();
            }
            else
            {
                accumulator = operand;
            }

            Button button = (Button)sender;
            operation = button.Text;
           
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            Calculate();

            txtB_Result.Text = accumulator.ToString();
        }

        /// <summary>
        /// En egen funktion för själva beräkningen, och inget annat
        /// (förutom extra felhantering vid division).
        /// </summary>
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

        /// <summary>
        /// Är avsedd att hantera all nollställning av appens variabler, så att 
        /// användaren inte ska behöva starta om eller att märkliga logiska fel
        /// inträffar. Men den är inte klar än ...
        /// </summary>
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtB_Calculations.Text = "";
            txtB_Result.Text = "0";
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
