using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora;

namespace Calculadora.Control
{
    public partial class UI: UserControl
    {
        Calculos calcule = new Calculos();

        public UI()
        {
            InitializeComponent();
        }

        
        
        //apenas números na entrada
        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // apenas uma vírgula
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try 
            {
                double soma = calcule.Somar(Convert.ToDouble(txtNum.Text));
                txtResultado.Text = soma.ToString();
            }
            catch (FormatException) //Se o usuário clicar no botão somar antes de digitar um número será disparado uma msg de erro
            {
                MessageBox.Show("Digite um número");
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            try
            {
                double subtracao = calcule.Subtrair(Convert.ToDouble(txtNum.Text));
                txtResultado.Text = subtracao.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite um número");
            }

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                double multiplicacao = calcule.Multiplicar(Convert.ToDouble(txtNum.Text));
                txtResultado.Text = multiplicacao.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite um número");
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                double divisao = calcule.Dividir(Convert.ToDouble(txtNum.Text));

                if (Convert.ToDouble(txtNum.Text) == 0)
                {
                    MessageBox.Show("Não é possível dividir por 0");
                }
                else
                {
                    txtResultado.Text = divisao.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite um número");
            }
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {            
            txtResultado.Text = Convert.ToString(calcule.Zerar());
            txtNum.Clear();
            txtResultado.Clear();
        }


    }
}
