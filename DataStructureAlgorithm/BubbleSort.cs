using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class BubbleSort
    {
        public static void BubbleSortIntArray(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void Bubble_Sort()
        {
            Console.WriteLine("Enter a list of integers separated by spaces:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int[] intArray = Array.ConvertAll(numbers, int.Parse);

            // Perform bubble sort on the array of integers
            BubbleSortIntArray(intArray);

            Console.WriteLine("Sorted List:");
            foreach (int num in intArray)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();
        }
    }
        
}
