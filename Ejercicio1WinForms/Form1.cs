namespace Ejercicio1WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GreetButton_Click(object sender, EventArgs e)
        {
            HelloWorlLbl.Text = "¡Hola, WinForms!";
            GreetButton.Enabled = false;
        }
    }
}
