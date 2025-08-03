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
        private bool hasDecimal = false;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "C# Calculator";
            this.Size = new Size(350, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(45, 45, 45);
            this.ForeColor = Color.White;

            // Display
            TextBox display = new TextBox();
            display.Name = "display";
            display.Location = new Point(20, 20);
            display.Size = new Size(300, 50);
            display.Font = new Font("Arial", 20, FontStyle.Bold);
            display.TextAlign = HorizontalAlignment.Right;
            display.ReadOnly = true;
            display.BackColor = Color.FromArgb(60, 60, 60);
            display.ForeColor = Color.White;
            display.Text = "0";
            this.Controls.Add(display);

            // Button layout
            string[,] buttonLabels = {
                {"C", "±", "%", "÷"},
                {"7", "8", "9", "×"},
                {"4", "5", "6", "-"},
                {"1", "2", "3", "+"},
                {"0", ".", "=", "^"}
            };

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Button button = new Button();
                    button.Text = buttonLabels[row, col];
                    button.Location = new Point(20 + col * 75, 90 + row * 70);
                    button.Size = new Size(70, 65);
                    button.Font = new Font("Arial", 16, FontStyle.Bold);
                    button.Click += Button_Click;

                    // Set button colors
                    if (buttonLabels[row, col] == "=")
                    {
                        button.BackColor = Color.FromArgb(255, 149, 0);
                        button.ForeColor = Color.White;
                    }
                    else if (buttonLabels[row, col] == "C")
                    {
                        button.BackColor = Color.FromArgb(255, 59, 48);
                        button.ForeColor = Color.White;
                    }
                    else if ("÷×+-^".Contains(buttonLabels[row, col]))
                    {
                        button.BackColor = Color.FromArgb(255, 149, 0);
                        button.ForeColor = Color.White;
                    }
                    else
                    {
                        button.BackColor = Color.FromArgb(80, 80, 80);
                        button.ForeColor = Color.White;
                    }

                    this.Controls.Add(button);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            TextBox display = (TextBox)this.Controls["display"];

            switch (button.Text)
            {
                case "C":
                    Clear();
                    break;
                case "±":
                    Negate();
                    break;
                case "%":
                    Percentage();
                    break;
                case "÷":
                case "×":
                case "-":
                case "+":
                case "^":
                    SetOperation(button.Text);
                    break;
                case "=":
                    Calculate();
                    break;
                case ".":
                    AddDecimal();
                    break;
                default:
                    AddDigit(button.Text);
                    break;
            }
        }

        private void Clear()
        {
            TextBox display = (TextBox)this.Controls["display"];
            display.Text = "0";
            firstNumber = 0;
            operation = "";
            isNewNumber = true;
            hasDecimal = false;
        }

        private void Negate()
        {
            TextBox display = (TextBox)this.Controls["display"];
            if (double.TryParse(display.Text, out double number))
            {
                display.Text = (-number).ToString();
            }
        }

        private void Percentage()
        {
            TextBox display = (TextBox)this.Controls["display"];
            if (double.TryParse(display.Text, out double number))
            {
                display.Text = (number / 100).ToString();
            }
        }

        private void SetOperation(string op)
        {
            TextBox display = (TextBox)this.Controls["display"];
            if (double.TryParse(display.Text, out double number))
            {
                firstNumber = number;
                operation = op;
                isNewNumber = true;
                hasDecimal = false;
            }
        }

        private void Calculate()
        {
            TextBox display = (TextBox)this.Controls["display"];
            if (double.TryParse(display.Text, out double secondNumber))
            {
                double result = 0;
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
                            return;
                        }
                        break;
                    case "^":
                        result = Math.Pow(firstNumber, secondNumber);
                        break;
                }
                display.Text = result.ToString();
                firstNumber = result;
                isNewNumber = true;
                hasDecimal = false;
            }
        }

        private void AddDecimal()
        {
            TextBox display = (TextBox)this.Controls["display"];
            if (!hasDecimal)
            {
                if (isNewNumber)
                {
                    display.Text = "0.";
                    isNewNumber = false;
                }
                else
                {
                    display.Text += ".";
                }
                hasDecimal = true;
            }
        }

        private void AddDigit(string digit)
        {
            TextBox display = (TextBox)this.Controls["display"];
            if (isNewNumber)
            {
                display.Text = digit;
                isNewNumber = false;
            }
            else
            {
                display.Text += digit;
            }
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorForm());
        }
    }
}