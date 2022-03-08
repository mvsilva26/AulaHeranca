using System;

namespace Ex_Enum
{
    internal class Program
    {

        enum Cor
        {
            Vermelho,
            Verde = 10,
            Azul
        }

        static void Main(string[] args)
        {

            Console.WriteLine(nomeDaCor(Cor.Vermelho));
            Console.WriteLine(nomeDaCor(Cor.Verde));
            Console.WriteLine(nomeDaCor(Cor.Azul));


        }


        static string nomeDaCor(Cor c)
        {
            switch (c)
            {
                case Cor.Vermelho:
                    return String.Format("Vermelho = {0}", (int)c);
                case Cor.Verde:
                    return String.Format("Vermelho = {0}", (int)c);
                case Cor.Azul:
                    return String.Format("Vermelho = {0}", (int)c);
                default:
                    return "Cor não definida";
            }
        }

    }
}
