using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculos
    {

        
        public double Somar(double num)
        {
            resultado = Resultado + num;
            return resultado;
        }

        public double Subtrair(double num)
        {
            resultado = Resultado - num;
            return resultado;
        }

        public double Multiplicar(double num)
        {
            resultado = Resultado * num;
            return resultado;
        }

        public double Dividir(double num)
        {
            resultado = Resultado / num;
            return resultado;
        }



        private double resultado;
        public double Resultado { get { return resultado; } }


        public double Zerar() //zerar o resultado
        {
            return this.resultado = 0.0;            
        }


        public Calculos()
        {
            this.resultado = 0.0; //inicializa a variável com zero
        }
    }
}
