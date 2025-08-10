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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void ConversionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esNumero = double.TryParse(DatoIngresadoTxt.Text, out double datoIngresado);

            if (esNumero)
            {
                string tipoConversion = ConversionType.SelectedItem.ToString();

                if (tipoConversion == "Celsius a Fahrenheit")
                {
                    double resultado = (datoIngresado * 9 / 5) + 32;
                    ResultLbl.Text = $"{datoIngresado} grados Celsius son {resultado:F2} grados Fahrenheit.";
                }
                else if (tipoConversion == "Fahrenheit a Celsius")
                {
                    double resultado = (datoIngresado - 32) * 5 / 9;
                    ResultLbl.Text = $"{datoIngresado} grados Fahrenheit son {resultado:F2} grados Celsius.";
                }
            }
            else
            {
                ResultLbl.Text = "Por favor, ingrese un número válido.";
            }
        }

        private void DatoIngresadoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
