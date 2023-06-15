using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPares.Controller
{
    internal class Numeros
    {
        public string Calcular(int valor)
        {
            string numeropar = "";
            if (valor % 2 == 0)
            {
                numeropar = "Seu número " + valor + " é Par";
            }
            else
            {
                numeropar = "Seu número " + valor + " é Ímpar";
            }
            return numeropar;
        }
    }
}
