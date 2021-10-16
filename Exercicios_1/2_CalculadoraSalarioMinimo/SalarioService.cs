using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_CSharp
{
    class SalarioService
    {
        public static void CalculadoraSalario()
        {
            double salarioFuncionario;
            double salarioMinimo;
            double resultado;

            Console.WriteLine("::          Calculadora de Salário         ::");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Digite o valor do seu salário:");
            Console.Write("R$: ");
            salarioFuncionario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do salário mínimo:");
            Console.Write("R$: ");
            salarioMinimo = Convert.ToDouble(Console.ReadLine());

            resultado = (salarioFuncionario / salarioMinimo);
            Console.WriteLine("Você recebe {0} salários mínimos!", resultado.ToString("N2"));
        }
    }
}
