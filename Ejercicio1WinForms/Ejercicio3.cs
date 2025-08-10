using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1WinForms
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void SumaButton_Click(object sender, EventArgs e)
        {
            bool esNumero1 = double.TryParse(Value1Txt.Text, out double valor1);
            bool esNumero2 = double.TryParse(Value2Txt.Text, out double valor2);
            if (esNumero1 && esNumero2)
            {
                double resultado = valor1 + valor2;
                OperationResultLbl.Text = $"{resultado}";
                OperationSimbolLbl.Text = "+";
            }
            else
            {
                OperationResultLbl.Text = "Números no válidos.";
            }
        }

        private void OperationResultLbl_Click(object sender, EventArgs e)
        {

        }

        private void RestarButton_Click(object sender, EventArgs e)
        {
            bool esNumero1 = double.TryParse(Value1Txt.Text, out double valor1);
            bool esNumero2 = double.TryParse(Value2Txt.Text, out double valor2);
            if (esNumero1 && esNumero2)
            {
                double resultado = valor1 - valor2;
                OperationResultLbl.Text = $"{resultado}";
                OperationSimbolLbl.Text = "-";
            }
            else
            {
                OperationResultLbl.Text = "Números no válidos.";
            }
        }

        private void multiplicarButton_Click(object sender, EventArgs e)
        {
            bool esNumero1 = double.TryParse(Value1Txt.Text, out double valor1);
            bool esNumero2 = double.TryParse(Value2Txt.Text, out double valor2);
            if (esNumero1 && esNumero2)
            {
                double resultado = valor1 * valor2;
                OperationResultLbl.Text = $"{resultado}";
                OperationSimbolLbl.Text = "X";
            }
            else
            {
                OperationResultLbl.Text = "Números no válidos.";
            }
        }

        private void DividirButton_Click(object sender, EventArgs e)
        {
            bool esNumero1 = double.TryParse(Value1Txt.Text, out double valor1);
            bool esNumero2 = double.TryParse(Value2Txt.Text, out double valor2);
            if (esNumero1 && esNumero2)
            {
                double resultado = valor1 / valor2;
                OperationResultLbl.Text = $"{resultado:F2}";
                OperationSimbolLbl.Text = "÷";
            }
            else
            {
                OperationResultLbl.Text = "Números no válidos.";
            }
        }
    }
}
