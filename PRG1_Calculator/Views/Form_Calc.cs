using Newtonsoft.Json.Linq;
using PRG1_Calculator.Services;
using System.Diagnostics;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PRG1_Calculator
{
    public partial class Form_Calc : Form
    {
        private bool calculationCompleted = false;
        private double accumulator = 0;
        private string userInput = "";
        private string operation = "";
        private double operand = 0;
        private float originalFontSizeTextBox, originalFontSizeButton, originalFormWidth, originalFormHeight;

        public Form_Calc()
        {
            InitializeComponent();
            originalFormHeight = this.ClientSize.Height;
            originalFormWidth = this.ClientSize.Width;
            this.Resize += new EventHandler(Form_Resize);
            InitializeFontSizes();
        }

        #region hanterar fontstorlekar
        // Responsiva fonter finns inte i Windows Forms, som hos MAUI, WPF eller andra senare gränssnitt.
        // Se tidigare branch "step1/basicCalculator" för ytterligare förklaringar
        private void Form_Resize(object sender, EventArgs e)
        {
            float scaleFactor = Math.Max(this.Width / (float)originalFormWidth, this.Height / (float)originalFormHeight);
            AdjustControlFonts(this.Controls, scaleFactor);
        }

        private void InitializeFontSizes()
        {
            originalFontSizeTextBox = txtB_Show.Font.Size;
            originalFontSizeButton = FindButtonFontSize(this.Controls);
        }

        private float FindButtonFontSize(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is Button btn)
                {
                    return btn.Font.Size;
                }
                else if (ctrl.HasChildren)
                {
                    float size = FindButtonFontSize(ctrl.Controls);
                    if (size != 0) return size;
                }
            }
            return 0;
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
                if (control.HasChildren)
                {
                    AdjustControlFonts(control.Controls, scaleFactor);
                }
            }
        }

        #endregion
        #region hanterar tangentbordsknappar
        private void Form_Calc_KeyDown(object sender, KeyEventArgs e)
        {
            Button? pressedKey = null;

            switch (e.KeyCode)
            {
                //nummerknapparna
                case Keys.NumPad0:
                case Keys.D0:
                    pressedKey = btn_0;
                    break;
                case Keys.NumPad1:
                case Keys.D1:
                    pressedKey = btn_1;
                    break;
                case Keys.NumPad2:
                case Keys.D2:
                    pressedKey = btn_2;
                    break;
                case Keys.NumPad3:
                case Keys.D3:
                    pressedKey = btn_3;
                    break;
                case Keys.NumPad4:
                case Keys.D4:
                    pressedKey = btn_4;
                    break;
                case Keys.NumPad5:
                case Keys.D5:
                    pressedKey = btn_5;
                    break;
                case Keys.NumPad6:
                case Keys.D6:
                    pressedKey = btn_6;
                    break;
                case Keys.NumPad7:
                case Keys.D7:
                    pressedKey = btn_7;
                    break;
                case Keys.NumPad8:
                case Keys.D8:
                    pressedKey = btn_8;
                    break;
                case Keys.NumPad9:
                case Keys.D9:
                    pressedKey = btn_9;
                    break;

                //andra knappar
                case Keys.Add:
                    pressedKey = btn_plus;
                    break;
                case Keys.Subtract:
                    pressedKey = btn_minus;
                    break;
                case Keys.Multiply:
                    pressedKey = btn_multiply;
                    break;
                case Keys.Divide:
                    pressedKey = btn_divided;
                    break;
                case Keys.Enter:
                    btn_equal.PerformClick();
                    break;
                case Keys.Delete:
                    btn_clear.PerformClick();
                    break;
                case Keys.Decimal:
                case Keys.OemPeriod:
                    UpdateInput(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                    break;
                case Keys.F1:
                    pressedKey = btn_catchFromMemory;
                    break;
                case Keys.F2:
                    pressedKey = btn_storeInMemory;
                    break;
            }

            if (pressedKey != null)
            {
                UpdateInput(pressedKey.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        #endregion

        /// <summary>
        /// Uppdaterar det som står i textboxen högst upp, och
        /// placerar värdet i userInput. Orsaken är inte skriva samma kod på flera ställen
        /// </summary>
        /// <param name="value">Vad som står på knapparna.</param>
        private void UpdateInput(string value)
        {
            if (calculationCompleted && !"+-*/".Contains(value))
            {
                btn_clear.PerformClick();
                txtB_Show.Text = "";
                calculationCompleted = false;
            }

            if (txtB_Show.Text == "0" && value != "." && !"+-*/C".Contains(value))
            {
                txtB_Show.Text = "";
            }

            if (value == "+" || value == "-" || value == "*" || value == "/")
            {
                if (!string.IsNullOrEmpty(operation) && !string.IsNullOrEmpty(userInput))
                {
                    btn_equal.PerformClick();
                }
                else if (!string.IsNullOrEmpty(userInput))
                {
                    operand = double.Parse(userInput);
                    accumulator = operand;
                    userInput = "";
                }
                operation = value;
                txtB_Show.Text += "" + value + "";
            }

            else if (value == "Spara")
            {
                btn_storeInMemory.PerformClick();
            }
            else if (value == "Hämta")
            {
                btn_catchFromMemory.PerformClick();
            }
            else if (value == "C")
            {
                btn_clear.PerformClick();
            }
            else
            {
                userInput += value;
                txtB_Show.Text += value;
            }
        }


        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "-/+")
            {
                if (double.TryParse(txtB_Show.Text, out double operand))
                {
                    operand *= -1;
                    UpdateInput(operand.ToString());
                 }
                else if (string.IsNullOrEmpty(txtB_Show.Text))
                {
                    MessageBox.Show("Fel!");
                }
            }
            else
            {
                UpdateInput(button.Text);
            }
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string selectedOperation = button.Text;

            if (!string.IsNullOrEmpty(userInput))
            {
                if (!double.TryParse(userInput, out operand))
                {
                    txtB_Show.Text = "Ogiltig inmatning";
                    return;
                }

                if (!string.IsNullOrEmpty(operation))
                {
                    Calculate();
                }
                else
                {
                    accumulator = operand;
                }
                operation = selectedOperation;
                userInput = "";
            }
            else if (accumulator != 0)
            {
                operation = selectedOperation;
            }
            else
            {
                txtB_Show.Text = "Ange ett nummer först";
            }
            txtB_Show.Text = accumulator + "" + operation + "";

            calculationCompleted = false;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userInput))
            {
                if (!double.TryParse(userInput, out operand))
                {
                    txtB_Show.Text = "Ogiltig inmatning";
                    return;
                }
            }
            else if (accumulator != 0 && !string.IsNullOrEmpty(operation))
            {
                operand = accumulator;
            }
            else
            {
                return;
            }

            Calculate();

            txtB_Show.Text = accumulator.ToString();
            userInput = ""; 
            operation = "";

            calculationCompleted = true;
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
                        txtB_Show.Text = "Fel: Division med noll";
                        return;
                    }
                    accumulator /= operand;
                    break;
                case "*":
                    accumulator *= operand;
                    break;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            userInput = "";
            operation = "";
            txtB_Show.Text = "0";
            operand = 0;
            accumulator = 0;
            calculationCompleted = false;
        }

        private void btn_storeInMemory_Click(object sender, EventArgs e)
        {
            DataManager manager = new();
            if (double.TryParse(txtB_Show.Text, out accumulator))
            {
                DataContainer save = new(accumulator);
                manager.SaveData(save);
                UpdateInput("");
            }
            else
            {
                MessageBox.Show("Värdet kan inte sparas,\nenbart siffror är giltiga", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_catchFromMemory_Click(object sender, EventArgs e)
        {
            DataManager manager = new();
            DataContainer data = manager.LoadData();
            if (data.Value == 0)
            {
                MessageBox.Show("Inget sparat värde hittades", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UpdateInput(data.Value.ToString());
                calculationCompleted = true;
            }
        }
    }
}

// Debug.WriteLine($"Resultat: accumulator = {accumulator}, userInput = '{userInput}', operation = '{operation}'");