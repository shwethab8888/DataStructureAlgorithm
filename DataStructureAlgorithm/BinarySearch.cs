using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class BinarySearch
    {
        public static int Search(string[] arr, string x)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int result = x.CompareTo(arr[mid]);
                if (result == 0)
                {
                    return mid;
                }
                else if (result < 0)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }

        public static void Binary_Search()
        {
            string[] words = File.ReadAllText("words.txt").Split(',');

            Array.Sort(words);

            Console.Write("Enter a word to search for: ");
            string searchWord = Console.ReadLine();
            int index = BinarySearch.Search(words, searchWord);

            if (index >= 0)
            {
                Console.WriteLine("The word {0} was found at index {1}.", searchWord, index);
            }
            else
            {
                Console.WriteLine("The word {0} was not found in the list.", searchWord);
            }
        }
    }
}
