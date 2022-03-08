using System;
using System.Collections.Generic;

namespace Ex3List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> listaString = new List<string>();

            

            Console.WriteLine("Capacidade: " + listaString.Capacity);
            string nome;
            
            do
            {
                Console.WriteLine("Digite um nome pra inserir na lista");
                nome = Console.ReadLine();
                listaString.Add(nome);

            } while (nome != "");
            
            listaString.ForEach(i => Console.WriteLine(i));

        }
    }
}
