// Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc. 
// (No se ingresan valores por teclado)

using System;

namespace mutiplos_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplo = 11, suma = 0, x = 1;

            while (x <= 25)
            {
                Console.WriteLine(multiplo);
                multiplo = multiplo + 11;
                x = x + 1;
            }
            Console.ReadKey();
        }
    }
}