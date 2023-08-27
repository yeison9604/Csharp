using System;

namespace NumeroEspecial
{
    class Program
    {
        static bool EsNumeroEspecial(int numero)
        {
            // Verificar si es divisible entre 5
            if (numero % 5 != 0)
                return false;

            // Verificar que no sea divisible entre 2 ni 3
            if (numero % 2 == 0 || numero % 3 == 0)
                return false;

            // Calcular la suma de los dígitos
            int sumaDigitos = 0;
            int numeroTemporal = numero;
            while (numeroTemporal > 0)
            {
                sumaDigitos += numeroTemporal % 10;
                numeroTemporal /= 10;
            }

            // Verificar si la suma de los dígitos es mayor a 10
            if (sumaDigitos <= 10)
                return false;

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Ingresa un número: ");
            int numeroIngresado = int.Parse(Console.ReadLine());

            if (EsNumeroEspecial(numeroIngresado))
                Console.WriteLine($"{numeroIngresado} es un número especial.");
            else
                Console.WriteLine($"{numeroIngresado} no es un número especial.");
        }
    }
}