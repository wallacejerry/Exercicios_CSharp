using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_CSharp
{
    public class ImcService
    {
        public static void CalculadoraImc()
        {
            double peso;
            double altura;
            double resultado;

            Console.WriteLine("::            Calculadora de IMC           ::");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Digite seu peso (em kg):");
            peso = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite sua altura (em metros):");
            altura = Convert.ToDouble(Console.ReadLine());

            resultado = (peso / (Math.Pow(altura, 2)));
            Console.WriteLine("Seu IMC é: {0}", resultado);

            if (resultado < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if ((resultado >= 20) && (resultado < 25))
            {
                Console.WriteLine("Peso ideal");
            }
            else if (resultado >= 25)
            {
                Console.WriteLine("Acima do peso");
            }
        }
    }
}
