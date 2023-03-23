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
                    // If x is found at mid, return mid
                    return mid;
                }
                else if (result < 0)
                {
                    // If x is smaller than arr[mid], ignore right half
                    right = mid - 1;
                }
                else
                {
                    // If x is greater than arr[mid], ignore left half
                    left = mid + 1;
                }
            }
            // If we reach here, then the element was not present in the array
            return -1;
        }

        public static void Binary_Search()
        {
            // Read in the list of words from file
            string[] words = File.ReadAllText("words.txt").Split(',');

            // Sort the words using Array.Sort() method
            Array.Sort(words);

            // Prompt the user to enter a word to search for
            Console.Write("Enter a word to search for: ");
            string searchWord = Console.ReadLine();

            // Perform Binary Search using the BinarySearch.Search() method
            int index = BinarySearch.Search(words, searchWord);

            // Check if the word was found
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
