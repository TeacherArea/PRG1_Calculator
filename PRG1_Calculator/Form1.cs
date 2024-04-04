namespace PRG1_Calculator
{
    /// <summary>
    /// Mycket �r gjort, men logiken haltar lite. Din uppgift blir att l�sa detta, efter 
    /// den gemensamma genomg�ngen! F�r att d�refter lyckas m�ste du anv�nda Breakpoints
    /// f�r att se vad som faktiskt finns i de globala variablerna. AI eller youtube �r bra,
    /// men inte helt perfekta f�r uppgiften ... Lycka till!
    /// </summary>
    public partial class Form_Calculator : Form
    {
        private double operand = 0;         // global variabel f�r inmatat nummer
        private string operation = "";      // global variabel f�r inmatat + - * eller /
        private double accumulator = 0;     // global variabel f�r resultatet av ber�knignar
        private string buttonInput = "";    // global variabel f�r ... ja, vad�?

        public Form_Calculator()
        {
            InitializeComponent();
            txtB_Result.Text = "0";
        }

  
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operand += Convert.ToDouble(button.Text); // �r det smart att g�ra detta h�r?

            txtB_Calculations.Text += button.Text;
            txtB_Result.Text = accumulator.ToString();
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            // f�r att f� minus och g�nger att fungera, d�r fr�mst accumulator initialt inte kan vara 0
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
        /// En egen funktion f�r sj�lva ber�kningen, och inget annat
        /// (f�rutom extra felhantering vid division).
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
        /// �r avsedd att hantera all nollst�llning av appens variabler, s� att 
        /// anv�ndaren inte ska beh�va starta om eller att m�rkliga logiska fel
        /// intr�ffar. Men den �r inte klar �n ...
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
