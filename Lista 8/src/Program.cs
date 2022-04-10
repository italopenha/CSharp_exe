using System;

namespace Lista_8.src
{
    public class carro
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Cor { get; set; }

        public int Preco { get; set; }
        
        public carro(string _marca, string _modelo, string _cor, int _preco)
        {
            Marca = _marca;
            Modelo = _modelo;
            Cor = _cor;
            Preco = _preco;
        }

        public void combustivel()
        {
            Console.WriteLine("Etanol");
        }

        public void roda()
        {
            Console.WriteLine("Aro 18");
        }
        
    }
}