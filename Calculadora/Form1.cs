using System.Security.Cryptography.X509Certificates;

namespace Calculadora
{
    public partial class frmcalculadora : Form
    {
        public frmcalculadora()
        {
            InitializeComponent();
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txbnumero1.Text);
            int numero2 = Convert.ToInt32(txbnumero2.Text);
            txbresultado.Text = Soma2(numero1, numero2).ToString();
        }

        private void btnmultiplicacao_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txbnumero1.Text);
            int numero2 = Convert.ToInt32(txbnumero2.Text);
            txbresultado.Text = Mult2(numero1, numero2).ToString();
        }

        private void btnsubtracao_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txbnumero1.Text);
            int numero2 = Convert.ToInt32(txbnumero2.Text);
            txbresultado.Text = Subt2(numero1, numero2).ToString();
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txbnumero1.Text);
            int numero2 = Convert.ToInt32(txbnumero2.Text);
            txbresultado.Text = Div2(numero1, numero2).ToString();
        }
        double resultado;

        double Soma2(params double[] numeros) 
        {
            resultado = 0;
            foreach(double numero in numeros)
            {
                resultado += numero;
            }
            return resultado;
        }
        
        double Subt2(params double[] numeros)
        {
            resultado = 0;
            foreach(double numero in numeros)
            {
                resultado -= numero;
            }
            return resultado;
        }

        double Mult2(params double[] numeros)
        {
            resultado = 1;
            foreach(double numero in numeros)
            {
                resultado *= numero;
            }
            return resultado;
        }

        double Div2(double numero1, double numero2)
        {
            resultado = numero1 / numero2;
            return resultado;
        }
    }
}