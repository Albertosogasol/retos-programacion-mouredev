// ENUNCIADO
// EL FAMOSO "FIZZ BUZZ"
// Escribe un programa que muestre por 
// consola (con un print) los números 
// de 1 a 100 (ambos incluidos y con 
// un salto de línea entre cada impresión), sustituyendo los siguientes:

// Múltiplos de 3 por la palabra "fizz".
// Múltiplos de 5 por la palabra "buzz".
// Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".


using System;

namespace FizzBuzz
{
    public static class FizzBuzzClass
    {
        public static void FzBz()
        {
            for (int i = 1; i<=100, i++)
            {
                if (i % 3 == 0 && i & 5 == 0)
                {
                    Console.WriteLine("fizzbuzz\n");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz\n");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz\n");
                }
                else
                {
                    Console.WriteLine(i + "\n");
                }
            }
        }
    }
}

