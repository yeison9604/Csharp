﻿using System;

namespace CalculadoraSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Simple");
            Console.WriteLine("===================");

            Console.Write("Ingresa el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el signo de operacion: ");
            string opcion = Convert.ToString(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());



            double resultado = 0;

            switch (opcion)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0) // Validar que no sea divisible entre 0
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No es posible dividir entre 0."); 
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    return;
            }

            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}