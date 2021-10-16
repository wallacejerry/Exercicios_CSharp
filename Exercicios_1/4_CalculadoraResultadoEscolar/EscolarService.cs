using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_CSharp
{
    class EscolarService
    {
        public static void CalculadoraResultadoEscolar()
        {
            //Inicializa a lista de notas
            List<double> notas = new List<double>();

            //Define a quantidade de notas que serão lidos
            int quantidadeNotas = 3;

            double media;

            Console.WriteLine("::     Calculadora de Resultado Escolar    ::");
            Console.WriteLine("---------------------------------------------");

            //Solicita a inclusão dos dados de forma genérica conforme a quantidade informada previamente na variável "quantidadeNotas"
            for (int i = 1; i <= quantidadeNotas; i++)
            {
                Console.WriteLine($"Digite a {i}ª nota:");
                double nota = Convert.ToDouble(Console.ReadLine());
                notas.Add(nota);

                Console.WriteLine("---------------------------------------------");
            }

            Console.WriteLine();
            
            //Calcula a média das notas informadas
            media = (notas.Sum() / quantidadeNotas);
            Console.WriteLine("A média das notas é: {0}", media.ToString("N2"));

            if (media >= 7)
            {
                Console.WriteLine("Resultado: Aprovado!");
            }
            else
            {
                //Caso o aluno não tenha atingido a média, solicita a nota do exame
                Console.WriteLine("Digite a nota do exame:");
                double notaExame = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("---------------------------------------------");

                //Calcula a nova média de acordo com a nota do exame
                double mediaExame = (media + notaExame) / 2;
                Console.WriteLine("A nova média é: {0}", mediaExame.ToString("N2"));

                if (mediaExame >= 5)
                {
                    Console.WriteLine("Resultado: Aprovado em exame!");
                }
                else
                {
                    Console.WriteLine("Resultado: Reprovado!");
                }
            }
        }
    }
}
