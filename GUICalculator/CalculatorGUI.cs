using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class CalculatorForm : Form
    {
        private double firstNumber = 0;
        private string operation = "";
        private bool isNewNumber = true;
        private TextBox displayTextBox;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "C# Calculator";
            this.Size = new Size(300, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Display TextBox
            displayTextBox = new TextBox
            {
                Location = new Point(10, 10),
                Size = new Size(260, 30),
                Font = new Font("Arial", 14),
                TextAlign = HorizontalAlignment.Right,
                ReadOnly = true,
                Text = "0"
            };

            // Button layout
            string[,] buttonLabels = {
                {"C", "±", "%", "÷"},
                {"7", "8", "9", "×"},
                {"4", "5", "6", "-"},
                {"1", "2", "3", "+"},
                {"0", ".", "=", ""}
            };

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (row == 4 && col == 3) continue; // Skip the last empty button

                    Button button = new Button
                    {
                        Text = buttonLabels[row, col],
                        Location = new Point(10 + col * 65, 50 + row * 50),
                        Size = new Size(60, 45),
                        Font = new Font("Arial", 12, FontStyle.Bold)
                    };

                    if (buttonLabels[row, col] == "0")
                    {
                        button.Size = new Size(130, 45); // Make zero button wider
                    }

                    // Set button colors
                    if (IsOperator(buttonLabels[row, col]))
                    {
                        button.BackColor = Color.Orange;
                        button.ForeColor = Color.White;
                    }
                    else if (buttonLabels[row, col] == "C")
                    {
                        button.BackColor = Color.LightGray;
                    }
                    else if (buttonLabels[row, col] == "=")
                    {
                        button.BackColor = Color.Orange;
                        button.ForeColor = Color.White;
                    }

                    button.Click += Button_Click;
                    this.Controls.Add(button);
                }
            }

            this.Controls.Add(displayTextBox);
        }

        private bool IsOperator(string text)
        {
            return text == "+" || text == "-" || text == "×" || text == "÷" || text == "%";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;

            switch (buttonText)
            {
                case "C":
                    Clear();
                    break;
                case "±":
                    Negate();
                    break;
                case "=":
                    Calculate();
                    break;
                case "+":
                case "-":
                case "×":
                case "÷":
                case "%":
                    SetOperation(buttonText);
                    break;
                default:
                    AddDigit(buttonText);
                    break;
            }
        }

        private void Clear()
        {
            displayTextBox.Text = "0";
            firstNumber = 0;
            operation = "";
            isNewNumber = true;
        }

        private void Negate()
        {
            if (double.TryParse(displayTextBox.Text, out double number))
            {
                displayTextBox.Text = (-number).ToString();
            }
        }

        private void AddDigit(string digit)
        {
            if (isNewNumber)
            {
                displayTextBox.Text = digit;
                isNewNumber = false;
            }
            else
            {
                if (digit == "." && !displayTextBox.Text.Contains("."))
                {
                    displayTextBox.Text += digit;
                }
                else if (digit != ".")
                {
                    displayTextBox.Text += digit;
                }
            }
        }

        private void SetOperation(string op)
        {
            if (double.TryParse(displayTextBox.Text, out double number))
            {
                firstNumber = number;
                operation = op;
                isNewNumber = true;
            }
        }

        private void Calculate()
        {
            if (string.IsNullOrEmpty(operation)) return;

            if (double.TryParse(displayTextBox.Text, out double secondNumber))
            {
                double result = 0;
                bool validOperation = true;

                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "×":
                        result = firstNumber * secondNumber;
                        break;
                    case "÷":
                        if (secondNumber != 0)
                            result = firstNumber / secondNumber;
                        else
                        {
                            MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            validOperation = false;
                        }
                        break;
                    case "%":
                        if (secondNumber != 0)
                            result = firstNumber % secondNumber;
                        else
                        {
                            MessageBox.Show("Cannot calculate modulo with zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            validOperation = false;
                        }
                        break;
                }

                if (validOperation)
                {
                    displayTextBox.Text = result.ToString();
                    operation = "";
                    isNewNumber = true;
                }
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorForm());
        }
    }
}