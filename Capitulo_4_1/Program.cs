﻿using System;

namespace Capitulo_4_1 // mostrar la tabla de multiplicar de un numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", numero, i, numero * i);
            }
        }
    }
}
