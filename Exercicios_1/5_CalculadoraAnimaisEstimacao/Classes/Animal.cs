using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_CSharp
{
    public class Animal
    {

        public Animal (string nome, TipoAnimal tipo)
        {
            this.SetNome(nome);
            this.SetTipo(tipo);
        }

        public enum TipoAnimal
        {
            Peixe = 1,
            Cachorro = 2,
            Gato = 3,
        };

        private string Nome;
        private TipoAnimal Tipo;

        public string GetNome()
        {
            return this.Nome;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public TipoAnimal GetTipo()
        {
            return this.Tipo;
        }

        public void SetTipo(TipoAnimal tipo)
        {
            this.Tipo = tipo;
        }

        public static Dictionary<TipoAnimal, int> ContarAnimaisTipo(List<Animal> animais)
        { 
            //Agrupa os animais por tipo, e faz a contagem do total de cada grupo
            Dictionary<TipoAnimal, int> contagem = animais.GroupBy(o => o.Tipo).ToDictionary(g => g.Key, g => g.Count());

            return contagem;
        }
    }
}
