using System;
using System.Collections;

namespace Ex2___ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList myAL = new ArrayList();

            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");

            Console.WriteLine("myAL");
            Console.WriteLine("     Contador:   {0}", myAL.Count);
            Console.WriteLine("     Contador:   {0}", myAL.Capacity);
            Console.WriteLine("     Valores:    ");
            PrintValues(myAL);

        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }

    }
}
