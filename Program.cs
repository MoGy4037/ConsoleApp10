using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;

            while (true)
            {
                Console.Write("enter array size: ");
                if (int.TryParse(Console.ReadLine(), out size) && size > 0)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("enter a number not a char");
                }
            }

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"enter element [{i + 1}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int max = arr[0];
            int min = arr[0];

            for (int i = 0; i < size; i++)
            {
                sum += arr[i];

                if (arr[i] > max)
                    max = arr[i];

                if (arr[i] < min)
                    min = arr[i];
            }

            double average = (double)sum / size;

            Console.WriteLine($"\nsum= {sum}");
            Console.WriteLine($"average= {average}");
            Console.WriteLine($"maximum= {max}");
            Console.WriteLine($"minimum= {min}");

            Console.Write("array in reverse= ");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
