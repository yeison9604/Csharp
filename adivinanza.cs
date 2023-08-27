using System;

namespace AdivinaPalabras
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "El *** Juega *** El ***.";
            string[] palabrasOcultas = { "Gato", "En", "Jardin" };
            bool[] palabrasAdivinadas = new bool[palabrasOcultas.Length];
            int intentosRestantes = 10;

            Console.WriteLine("¡Bienvenido al juego de adivinar palabras!");
            Console.WriteLine("Completa las palabras ocultas en la siguiente frase:");
            Console.WriteLine(frase);

            while (intentosRestantes > 0 && !TodasPalabrasAdivinadas(palabrasAdivinadas))
            {
                Console.WriteLine($"Intentos restantes: {intentosRestantes}");

                Console.Write("Ingresa una palabra: ");
                string palabraIngresada = Console.ReadLine();

                bool palabraAdivinada = false;
                for (int i = 0; i < palabrasOcultas.Length; i++)
                {
                    if (!palabrasAdivinadas[i] && palabraIngresada.ToLower() == palabrasOcultas[i].ToLower())
                    {
                        if (!palabraAdivinada)
                        {
                            Console.WriteLine("¡Correcto! ¡Adivinaste una palabra!");
                            palabrasAdivinadas[i] = true;
                            palabraAdivinada = true;
                        }
                    }
                }

                if (!palabraAdivinada)
                {
                    Console.WriteLine("Incorrecto. Sigue intentando.");
                    intentosRestantes--;
                }
            }

            if (TodasPalabrasAdivinadas(palabrasAdivinadas))
            {
                Console.WriteLine("¡Felicitaciones! Adivinaste todas las palabras.");
                Console.WriteLine("La frase completa es:");
                for (int i = 0; i < palabrasOcultas.Length; i++)
                {
                    frase = frase.Replace("***", palabrasOcultas[i]);
                }
                Console.WriteLine(frase);
            }
            else
            {
                Console.WriteLine("¡Se acabaron los intentos! Perdiste. Las palabras eran:");
                for (int i = 0; i < palabrasOcultas.Length; i++)
                {
                    if (!palabrasAdivinadas[i])
                    {
                        Console.WriteLine($"Palabra {i + 1}: {palabrasOcultas[i]}");
                    }
                }
            }

            Console.WriteLine("¡Juego terminado! Gracias por jugar.");
        }

        static bool TodasPalabrasAdivinadas(bool[] palabrasAdivinadas)
        {
            foreach (bool adivinada in palabrasAdivinadas)
            {
                if (!adivinada)
                {
                    return false;
                }
            }
            return true;
        }
    }
}