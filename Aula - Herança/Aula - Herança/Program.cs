using System;

namespace Aula___Herança
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Fisica fisica = new Fisica("Joao", "123.456.789-");
            fisica.escreverNome();
            Console.WriteLine("\n" + fisica.validarDocumento());

            Pessoa pessoa = new Pessoa();

        }
    }
}
