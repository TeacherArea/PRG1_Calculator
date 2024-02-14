namespace PRG1_Calculator
{
    public partial class Form1 : Form
    {
        private double accumulator = 0;
        private string userInput = "";
        private string operation = "";
        private float originalFontSizeTextBox, originalFontSizeButton, originalFormWidth, originalFormHeight;

        public Form1()
        {
            InitializeComponent();
            // ClientSize.Height och ClientSize.Width ger storleken på formuläret utan titel och fönsterram
            originalFormHeight = this.ClientSize.Height;
            originalFormWidth = this.ClientSize.Width;
            this.Resize += new EventHandler(Form_Resize);
            InitializeFontSizes();
        }

        #region hanterar fontstorlekar
        // Responsiva fonter finns inte i Windows Forms, som hos MAUI, WPF eller andra senare gränssnitt.
        // Man kan ändå simulera detta, om än ganska omständigt.
        private void Form_Resize(object sender, EventArgs e)
        {
            // this.Height och this.Width ger storleken på formuläret inklusive titel och fönsterram
            float scaleFactor = Math.Max(this.Width / (float)originalFormWidth, this.Height / (float)originalFormHeight);
            AdjustControlFonts(this.Controls, scaleFactor);
        }

        private void InitializeFontSizes()
        {
            originalFontSizeTextBox = txtB_Show.Font.Size;
            originalFontSizeButton = FindButtonFontSize(this.Controls);
        }

        /// <summary>
        /// När knappar och textbox (två Controllers) placeras i en tableLayoutPanel, blir de en del av 
        /// TableLayoutPanel:s ControlCollection, därav "omvägen" till Control.ControlCollection.
        /// Fontens storlek görs alltså beroende av den dymansiak storleken för vår tableLayoutPanel,
        /// som i sin tur är beroende av formulärets storlek.
        /// </summary>
        /// <param name="controls">The controls.</param>
        /// <returns></returns>
        private float FindButtonFontSize(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is Button btn)
                {
                    return btn.Font.Size; // Returnerar fontstorleken på den första hittade knappen
                }
                else if (ctrl.HasChildren)
                {
                    float size = FindButtonFontSize(ctrl.Controls);
                    if (size != 0) return size;
                }
            }
            return 0; // Om ingen knapp hittades
        }

        private void AdjustControlFonts(Control.ControlCollection controls, float scaleFactor)
        {
            foreach (Control control in controls)
            {
                if (control is Button btn)
                {
                    btn.Font = new Font(btn.Font.FontFamily, originalFontSizeButton * scaleFactor, btn.Font.Style);
                }
                else if (control is TextBox txtB)
                {
                    txtB.Font = new Font(txtB.Font.FontFamily, originalFontSizeTextBox * scaleFactor, txtB.Font.Style);
                }
                // Rekursivt anrop för barnkontroller om några
                if (control.HasChildren)
                {
                    AdjustControlFonts(control.Controls, scaleFactor);
                }
            }
        }

        #endregion

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            userInput += button.Text;
            txtB_Show.Text = userInput;
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            if (userInput == "")
            {
                txtB_Show.Text = "Ange ett nummer först";
                return;
            }

            Button button = (Button)sender;
            operation = button.Text;

            // lägg märke till att ett korrekt userInput (ett valt räknesätt) framöver heter "accumulator"
            if (!double.TryParse(userInput, out accumulator))
            {
                txtB_Show.Text = "Ogiltig inmatning";
                return;
            }
            userInput = "";
            txtB_Show.Text += button.Text;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            double operand;
            // lägg märke till att ett korrekt userInput framöver heter "operand"
            if (!double.TryParse(userInput, out operand))
            {
                txtB_Show.Text = "Ogiltig inmatning";
                return;
            }

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
                        txtB_Show.Text = "Fel: Division med noll";
                        return;
                    }
                    accumulator /= operand;
                    break;
                case "*":
                    accumulator *= operand;
                    break;
            }

            txtB_Show.Text = accumulator.ToString();
            userInput = "";
            accumulator = 0;
            operation = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            userInput = "";
            accumulator = 0;
            operation = "";
            txtB_Show.Text = "0";
        }

        private void btn_storeInMemory_Click(object sender, EventArgs e)
        {
            txtB_Show.Text = "Kommande funktion";
        }

        private void btn_catchFromMemory_Click(object sender, EventArgs e)
        {
            txtB_Show.Text = "Kommande funktion";
        }
    }
}
