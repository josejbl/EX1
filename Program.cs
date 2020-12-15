using System;
using Ex1.Calsses;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
                    
            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o Sobrenome");
            string sobreNome = Console.ReadLine();

            Pessoa pessoa = new Pessoa(nome,sobreNome);

        }
    }
}
