using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Calculator2._0
{
    public partial class Calculator : Form
    {
        private string currentInput = "0";
        private bool hasDecimal = false;
        private bool isErrorState = false;
        private bool isMouseDown = false;
        private int mouseX, mouseY;

        public Calculator()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.MouseUp += new MouseEventHandler(Form_MouseUp);
        }

        private void UpdateDisplay()
        {
            TxtBox.Text = currentInput;
        }

        private void AppendInput(string value)
        {
            if (isErrorState) return;

            if (currentInput == "0" && value != ".")
            {
                currentInput = value;
            }
            else
            {
                currentInput += value;
            }
            UpdateDisplay();
        }

        private void ClearInput()
        {
            currentInput = "0";
            hasDecimal = false;
            isErrorState = false;
            EnableButtons(true);
            UpdateDisplay();
        }

        private void EnableButtons(bool enable)
        {
            // Enable or disable all number and operator buttons
            ZeroBtn.Enabled = enable;
            OneBtn.Enabled = enable;
            TwoBtn.Enabled = enable;
            ThreeBtn.Enabled = enable;
            FourBtn.Enabled = enable;
            FiveBtn.Enabled = enable;
            SixBtn.Enabled = enable;
            SevenBtn.Enabled = enable;
            EightBtn.Enabled = enable;
            NineBtn.Enabled = enable;
            AddBtn.Enabled = enable;
            SubtractBtn.Enabled = enable;
            MultiplyBtn.Enabled = enable;
            DivideBtn.Enabled = enable;
            DecimalBtn.Enabled = enable;
            ChangeSignBtn.Enabled = enable;
            BackspaceBtn.Enabled = enable;
        }

        private bool IsValidInput(string input)
        {
            string validPattern = @"^[0-9+\-*/.]*$";
            return Regex.IsMatch(input, validPattern);
        }

        private bool IsValidOperatorSequence(string input)
        {
            string operatorPattern = @"[+\-*/]{2,}(?![-+0-9])";
            return !Regex.IsMatch(input, operatorPattern);
        }

        private bool IsValidDecimal(string input)
        {
            string decimalPattern = @"\.\d*$";
            return Regex.Matches(input, decimalPattern).Count <= 1;
        }

        private bool IsValidDivision(string input)
        {
            return !input.Contains("/0");
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (currentInput != "0" && !isErrorState)
            {
                AppendInput("0");
            }
        }

        private void OneBtn_Click(object sender, EventArgs e) => AppendInput("1");

        private void TwoBtn_Click(object sender, EventArgs e) => AppendInput("2");

        private void ThreeBtn_Click(object sender, EventArgs e) => AppendInput("3");

        private void FourBtn_Click(object sender, EventArgs e) => AppendInput("4");

        private void FiveBtn_Click(object sender, EventArgs e) => AppendInput("5");

        private void SixBtn_Click(object sender, EventArgs e) => AppendInput("6");

        private void SevenBtn_Click(object sender, EventArgs e) => AppendInput("7");

        private void EightBtn_Click(object sender, EventArgs e) => AppendInput("8");

        private void NineBtn_Click(object sender, EventArgs e) => AppendInput("9");

        private void DecimalBtn_Click(object sender, EventArgs e)
        {
            if (!hasDecimal && !isErrorState)
            {
                hasDecimal = true;
                AppendInput(".");
            }
        }

        private void AddBtn_Click(object sender, EventArgs e) => AddOperator("+");

        private void SubtractBtn_Click(object sender, EventArgs e) => AddOperator("-");

        private void MultiplyBtn_Click(object sender, EventArgs e) => AddOperator("*");

        private void DivideBtn_Click(object sender, EventArgs e) => AddOperator("/");

        private void AddOperator(string operatorSymbol)
        {
            if (Regex.IsMatch(currentInput, @"[+\-*/]$"))
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 1) + operatorSymbol;
            }
            else
            {
                currentInput += operatorSymbol;
            }
            hasDecimal = false;
            UpdateDisplay();
        }

        private void ChangeSignBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBox.Text) && TxtBox.Text != "0")
            {
                string text = TxtBox.Text;
                int lastNumberStart = -1;
                int lastNumberEnd = -1;

                for (int i = text.Length - 1; i >= 0; i--)
                {
                    if (char.IsDigit(text[i]) || text[i] == '.' || text[i] == '-')
                    {
                        if (lastNumberEnd == -1) lastNumberEnd = i;
                        lastNumberStart = i;

                        while (lastNumberStart > 0 &&
                               (char.IsDigit(text[lastNumberStart - 1]) || text[lastNumberStart - 1] == '.' ||
                                (text[lastNumberStart - 1] == '-' && (lastNumberStart - 1 == 0 || "+-*/()".Contains(text[lastNumberStart - 2])))))
                        {
                            lastNumberStart--;
                        }
                        break;
                    }
                }

                if (lastNumberStart != -1 && lastNumberEnd != -1)
                {
                    string beforeNumber = text.Substring(0, lastNumberStart);
                    string numberPart = text.Substring(lastNumberStart, lastNumberEnd - lastNumberStart + 1);

                    if (numberPart.StartsWith("-"))
                    {
                        numberPart = numberPart.Substring(1);
                    }
                    else
                    {
                        numberPart = "-" + numberPart;
                    }

                    TxtBox.Text = beforeNumber + numberPart + text.Substring(lastNumberEnd + 1);
                    currentInput = TxtBox.Text;
                }
            }
        }

        private void BackspaceBtn_Click(object sender, EventArgs e)
        {
            if (isErrorState) return;

            if (currentInput.Length > 1)
            {
                if (currentInput.EndsWith("."))
                {
                    hasDecimal = false;
                }
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
            }
            else
            {
                currentInput = "0";
            }
            UpdateDisplay();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            if (isErrorState) return;

            if (!IsValidInput(currentInput))
            {
                currentInput = "Error: Invalid Input";
                isErrorState = true;
                EnableButtons(false);
                UpdateDisplay();
                return;
            }

            if (!IsValidOperatorSequence(currentInput))
            {
                currentInput = "Error: Invalid Operator Sequence";
                isErrorState = true;
                EnableButtons(false);
                UpdateDisplay();
                return;
            }

            if (!IsValidDecimal(currentInput))
            {
                currentInput = "Error: Invalid Decimal Usage";
                isErrorState = true;
                EnableButtons(false);
                UpdateDisplay();
                return;
            }

            if (!IsValidDivision(currentInput))
            {
                currentInput = "Error: Division by Zero";
                isErrorState = true;
                EnableButtons(false);
                UpdateDisplay();
                return;
            }

            try
            {
                string sanitizedInput = Regex.Replace(currentInput, @"[^0-9+\-*/().]", "");
                DataTable table = new DataTable();
                object result = table.Compute(sanitizedInput, string.Empty);

                double resultValue = Convert.ToDouble(result);
                if (resultValue % 1 == 0)
                {
                    currentInput = resultValue.ToString("0");
                }
                else
                {
                    currentInput = resultValue.ToString("0.####");
                }

                if (currentInput.Contains("."))
                {
                    hasDecimal = true;
                }
                else
                {
                    hasDecimal = false;
                }
                UpdateDisplay();
            }
            catch
            {
                currentInput = "Error: Invalid Expression";
                isErrorState = true;
                EnableButtons(false);
                UpdateDisplay();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
    }
}
