using System;
using System.Collections.Generic;
using System.Text;

namespace Everson_Menezes
{
    class Exercicio1
    {
        public double ValorDolar { get; private set; }
        private const double ValorReal = 5.36;
        public double Resultado { get; private set; }
        public void CalcularReal(double dolar)
        {
            ValorDolar = dolar;
            Resultado = ValorDolar * ValorReal;
        }
        public string ExibirValorReal()
        {
            return "$: " + ValorDolar + " convertidos para real é equivalente a R$: " + Resultado.ToString("N2");
        }
    }
}
