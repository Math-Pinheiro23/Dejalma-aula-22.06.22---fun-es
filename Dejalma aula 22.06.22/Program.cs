using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dejalma_aula_22._06._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma;

            soma = Calcular(30, 20, "+");
            Console.WriteLine(soma);
            Console.ReadLine();
        }

       static public int Calcular(int numero1, int numero2, string operação)
        {
            int resultado=0;
            if (operação == "+")
            {
                resultado = numero1 + numero2;
            }
            else if(operação == "*")
            {
                resultado = numero1 + numero2;
            }
            else if (operação == "/")
            {
                resultado = numero1 + numero2;
            }
            else if (operação == "-")
            {
                resultado = numero1 + numero2;
            }
            return resultado;
        }
    }
}
