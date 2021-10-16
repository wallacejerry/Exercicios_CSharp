using System;
using Exercicios_CSharp;

namespace Exercicios_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            bool validacao = true;

            do
            {
                Console.WriteLine(":: Sejam bem-vindos a lista de exercícios! ::");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("(1) - Calculadora de IMC");
                Console.WriteLine("(2) - Calculadora de Salário / Salário Mínimo");
                Console.WriteLine("(3) - Calculadora de Volume de Esfera");
                Console.WriteLine("(4) - Calculadora de Resultado Escolar");
                Console.WriteLine("(5) - Calculadora de Animais de Estimação");
                Console.WriteLine("(6) - Sair");
                Console.WriteLine("---------------------------------------------");

                Console.WriteLine(":: Qual programa você deseja visualizar? ::");
                opcao = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("---------------------------------------------");

                switch (opcao)
                {
                    case 1:
                        ImcService.CalculadoraImc();
                        break;
                    case 2:
                        SalarioService.CalculadoraSalario();
                        break;
                    case 3:
                        EsferaService.CalculadoraVolumeEsfera();
                        break;
                    case 4:
                        EscolarService.CalculadoraResultadoEscolar();
                        break;
                    case 5:
                        AnimalService.CalculadoraAnimaisEstimacao();
                        break;
                    case 6:
                        validacao = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Tecle ENTER para continuar.");
                Console.ReadLine();
                Console.Clear();
            }
            while (validacao);
        }
    }
}