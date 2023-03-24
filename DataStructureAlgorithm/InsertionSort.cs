using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class InsertionSort
    {
        public static void Sort(string[] arr)
        {
            int i, j;
            string key;

            for (i = 1; i < arr.Length; i++)
            {
                key = arr[i];
                j = i - 1;

                while (j >= 0 && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        public static void Insertion_Sort()
        {
            Console.WriteLine("Enter a list of words :");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
          
            Sort(words);

            Console.WriteLine("Sorted List:");
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.ReadLine();
        }
    }
}






