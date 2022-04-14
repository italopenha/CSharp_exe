using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoologico.src
{
    public class Lobo : Animal
    {
        public Lobo() {}

        public Lobo(string nome, string cor, string classificacao) : base(nome, cor, classificacao) {}

        public override void Comunicar(string comunicacao)
        {
            Console.WriteLine($"{Nome} fazendo: {comunicacao}");
        }
    }
}