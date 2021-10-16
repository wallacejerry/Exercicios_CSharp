using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_CSharp
{
    class EsferaService
    { 
        public static void CalculadoraVolumeEsfera()
        {
            double raio;
            double volume;

            Console.WriteLine("::     Calculadora de Volume de Esfera     ::");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Digite o valor do raio da esfera:");
            Console.Write("Raio: ");
            raio = Convert.ToDouble(Console.ReadLine());

            volume = ((4.0 / 3.0) * Math.PI * Math.Pow(raio, 3));
            Console.WriteLine("O volume da esfera é: {0}", volume.ToString("N2"));
        }
    }
}
