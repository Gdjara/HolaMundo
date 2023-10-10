using System;

namespace AndreSebástianJaraGustavoEjer22Prac1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear(); // Limpiar la consola para la siguiente ejecución

                Console.WriteLine("Ordenamiento por Selección Directa");
                Console.Write("Ingrese los números separados por espacios: ");
                string indi = Console.ReadLine();
                string[] ArraIn = indi.Split(' ');

                int[] numero = new int[ArraIn.Length];
                for (int i = 0; i < ArraIn.Length; i++)
                {
                    numero[i] = Convert.ToInt32(ArraIn[i]);
                }

                int iteraciones = SeleccionDirecta(numero);

                Console.WriteLine("Arreglo ordenado:");
                foreach (int num in numero)
                {
                    Console.Write(num + " ");
                }

                Console.WriteLine($"\nNúmero de iteraciones realizadas: {iteraciones}");

                Console.Write("¿Desea ordenar otro arreglo? (S/N): ");
            } while (Console.ReadLine().ToUpper() == "S");
        }

        static int SeleccionDirecta(int[] arr)
        {
            int n = arr.Length;
            int iteraciones = 0;

            for (int i = 0; i < n - 1; i++)
            {
                int minIn = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIn])
                    {
                        minIn = j;
                    }
                }

                // Intercambiar los elementos arr[i] y arr[minIndex]
                int valor = arr[i];
                arr[i] = arr[minIn];
                arr[minIn] = valor;

                iteraciones++;

                // Mostrar el arreglo en cada iteración
                Console.Write($"Iteración {iteraciones}: ");
                for (int k = 0; k < n; k++)
                {
                    if (k == i || k == minIn)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ResetColor();
                    }

                    Console.Write(arr[k] + " ");
                }

                Console.ResetColor(); // Restablecer el color

                Console.WriteLine();
            }

            return iteraciones;
        }
    }
}
