using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorClient.CalculatorService;

namespace CalculatorClient
{
    public partial class CalculatorForm : Form
    {
        enum Operators { add = 0, subtract = 1, multiply  = 2, divide = 3 };
        private Operators[] operators = { Operators.add, Operators.subtract, Operators.multiply, Operators.divide };

        private CalculatorSoapClient service = new CalculatorSoapClient();
        
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            foreach(Operators op in operators)
            {
                lbOperator.Items.Add(op);
            }

            lbOperator.SetSelected(0, true);
        }

        // Make onExecute async as this access services that use HTTP (could be delays)
        async private void onExecute(object sender, EventArgs e)
        {
            int operand1 = Convert.ToInt32(tbOperand1.Text);
            int operand2 = Convert.ToInt32(tbOperand2.Text);
            int result = 0;

            try
            {
                switch (lbOperator.SelectedItem)
                {
                    case Operators.add:
                        result = await service.AddAsync(operand1, operand2);
                        lbCalcResult.Text = result.ToString();
                        break;
                    case Operators.subtract:
                        result = await service.SubtractAsync(operand1, operand2);
                        lbCalcResult.Text = result.ToString();
                        break;
                    case Operators.multiply:
                        result = await service.MultiplyAsync(operand1, operand2);
                        lbCalcResult.Text = result.ToString();
                        break;
                    case Operators.divide:
                        if (operand2 != 0)
                        {
                            result = await service.DivideAsync(operand1, operand2);
                            lbCalcResult.Text = result.ToString();
                        }
                        else
                        {
                            lbCalcResult.Text = "Cannot divide by zero!";
                        }
                        break;
                    default:
                        lbCalcResult.Text = "Invalid Operator!";
                        break;
                }
            }
            catch (FaultException exception)
            {
                // Catch system exception, could be sent from the calculator web service
                Console.WriteLine(exception.Message);
            }
        }
    }
}
