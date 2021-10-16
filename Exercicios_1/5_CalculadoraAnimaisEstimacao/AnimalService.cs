using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercicios_CSharp.Animal;

namespace Exercicios_CSharp
{
    class AnimalService
    {
        public static void CalculadoraAnimaisEstimacao()
        {
            //Inicializa a lista de animais
            List<Animal> animais = new List<Animal>();

            //Define a quantidade de animais que serão lidos
            int quantidadeLista = 5;

            Console.WriteLine("::   Calculadora de Animais de Estimação   ::");
            Console.WriteLine("---------------------------------------------");

            //Solicita a inclusão de dados de forma genérica conforme a quantidade informada previamente na variável "quantidadeLista"
            for (int i = 1; i <= quantidadeLista; i++)
            {
                string nome;
                TipoAnimal tipo;

                Console.WriteLine($"Digite os dados do {i}º animal:");
                
                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Tipo: ");
                Console.WriteLine("(1) - Peixe");
                Console.WriteLine("(2) - Cachorro");
                Console.WriteLine("(3) - Gato");

                //Pega o tipo digitado pelo usuário e converte em um enum
                Enum.TryParse(Console.ReadLine(), out tipo);

                //Se o tipo escolhido pelo usuário não existir no enum, seta como "Peixe" por default
                if (!Enum.IsDefined(typeof(TipoAnimal), tipo)) tipo = TipoAnimal.Peixe;

                //Monta o objeto através da factory
                Animal animal = new Animal(nome, tipo);

                //Adiciona o animal à lista de animais
                animais.Add(animal);

                Console.WriteLine("---------------------------------------------");
            }

            Console.WriteLine();

            //Envia a lista de animais para o método da classe "Animal" responsável pela contagem
            Dictionary<TipoAnimal, int> quantidadeAnimais = ContarAnimaisTipo(animais);

            Console.WriteLine("::         Quantidade de animais:          ::");
            Console.WriteLine("---------------------------------------------");

            //Percore os dados retornados pelo método "ContarAnimaisTipo" e exibe na tela
            foreach (KeyValuePair<TipoAnimal, int> item in quantidadeAnimais)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
