// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам.


using System;

namespace Controlworks
{
    class Program
    {

        static string[] ArrayFilling(int size)
        {
            string[] array = new string[size];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите с клавиатуры произвольный элемент №{i + 1}: ");
                array[i] = string.Format(Console.ReadLine());
            }
            return array;
        }

        static void PrintArray(string[] array)
        {
            int count = array.Length;
            int i = 0;

            Console.Write("[");
            while (i < count)
            {
                Console.Write(array[i]);
                i++;
                if (i < count)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");
        }

        static string[] ArrayChange(string[] array)
        {
            string[] changedArray = new string[array.Length];
            int j = 0;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    changedArray[j] = array[i];
                    j++;
                    count++;
                }
            }
            Array.Resize(ref changedArray, count);
            return changedArray;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Укажите длину массива: ");
            int size = Convert.ToInt32(Console.ReadLine());

            string[] array = ArrayFilling(size);
            PrintArray(array);
            Console.WriteLine();

            string[] changedArray = ArrayChange(array);
            PrintArray(changedArray);
            Console.WriteLine();
        }
    }
}