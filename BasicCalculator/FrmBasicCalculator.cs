using System;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            cbOperator.SelectedIndex = 0;
        }
        private void btnCompute_Click(object sender, EventArgs e)
        {
            float FirstNum;
            float SecondNum;

            if (!float.TryParse(txtFirstNumber.Text, out FirstNum) ||
                !float.TryParse(txtSecondNumber.Text, out SecondNum))
            {
                MessageBox.Show("Please enter valid numbers.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float total = 0;

            switch (cbOperator.Text)
            {
                case "+":
                    total = BasicComputation.Addition(FirstNum, SecondNum);
                    break;
                case "-":
                    total = BasicComputation.Subtraction(FirstNum, SecondNum);
                    break;
                case "*":
                    total = BasicComputation.Multiplication(FirstNum, SecondNum);
                    break;
                case "/":
                    if (SecondNum == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.", "Invalid Operation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    total = BasicComputation.Division(FirstNum, SecondNum);
                    break;
                default:
                    MessageBox.Show("Please select an operator.", "Invalid Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            lblResult.Text = total.ToString();
        }
    }
}

