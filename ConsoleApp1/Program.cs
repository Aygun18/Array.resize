using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int increment = 0;
            Console.WriteLine("Please enter the size of the array"); // userden array'in olcusunu isteyirik
            int sizeArray = Convert.ToInt32(Console.ReadLine()); // user olcunu daxil edir
            int[] numbers = new int[0];
            do
            {
                Console.WriteLine("Enter element ");
                int element = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(element);
                Array.Resize(ref numbers, numbers.Length + 1); // array'i bir vahid boyudur
                numbers[numbers.Length - 1] = element;

                Console.WriteLine("Do you want to continue? ");
                string answer = Console.ReadLine();
                if (!(answer == "y" || answer == "Y"))
                {
                    flag = false;
                    Console.WriteLine(".......exiting");
                }

            } while (flag);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}