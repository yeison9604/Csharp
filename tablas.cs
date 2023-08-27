using System;

namespace TablasDeMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generador de Tablas de Multiplicar con Desafío");
            Console.WriteLine("============================================");

            Console.Write("Ingresa el número inicial del rango: ");
            int inicio = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el número final del rango: ");
            int fin = Convert.ToInt32(Console.ReadLine());

            if (inicio > fin)
            {
                Console.WriteLine("El número inicial debe ser menor o igual al número final.");
                return;
            }

            Random random = new Random();

            for (int i = inicio; i <= fin; i++)
            {
                Console.WriteLine($"Tabla del {i}:");
                for (int j = 1; j <= 10; j++)
                {
                    if (j == 5) // Elegimos ocultar un resultado aleatorio en la fila 5
                    {
                        int resultadoReal = i * j;
                        int resultadoOculto = random.Next(1, 10) * i; // Generamos un resultado aleatorio para ocultar
                        Console.Write($" {i} x {j} = {resultadoOculto}\t");
                    }
                    else
                    {
                        Console.Write($" {i} x {j} = {i * j}\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}