using System;

namespace Lista_8.src
{
    class Program
    {
        static void Main(string[] args)
        {
            carro cruze = new carro("Chevrolet", "Cruze", "Azul", 70000);
            carro lancer = new carro("Mitsubishi", "Lancer", "Branco", 50000);
            carro onix = new carro("Chevrolet", "Onix", "Preto", 40000);

            Console.WriteLine($"Carro 1 é o {cruze.Marca} {cruze.Modelo} de cor {cruze.Cor} e custa {cruze.Preco}");
            Console.WriteLine($"Carro 2 é o {lancer.Marca} {lancer.Modelo} de cor {lancer.Cor} e custa {lancer.Preco}");
            Console.WriteLine($"Carro 3 é o {onix.Marca} {onix.Modelo} de cor {onix.Cor} e custa {onix.Preco}");

            cruze.combustivel();
            lancer.roda();
        }   
    }
}   