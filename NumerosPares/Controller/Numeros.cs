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
             string numero = "";
             if (valor % 2 == 0)
             {
                 numero = "Seu número " + valor + " é Par";
             }
             else
             {
                 numero = "Seu número " + valor + " é Ímpar";
             }
             return numero;
        }
    }
}
