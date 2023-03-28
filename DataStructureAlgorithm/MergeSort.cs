using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class MergeSort
    {
        public static void Sort(string[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                Sort(arr, left, mid);
                Sort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        public static void Merge(string[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            string[] leftArr = new string[n1];
            string[] rightArr = new string[n2];

            int i, j;

            for (i = 0; i < n1; i++)
            {
                leftArr[i] = arr[left + i];
            }

            for (j = 0; j < n2; j++)
            {
                rightArr[j] = arr[mid + 1 + j];
            }

            i = 0;
            j = 0;
            int k = left;

            while (i < n1 && j < n2)
            {
                if (leftArr[i].CompareTo(rightArr[j]) < 0)
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
            }
        }


        public static void Merge_Sort()
        {
            string[] arr = { "apple", "banana", "orange", "grape", "pear" };
            Console.WriteLine("Before sorting:");
            Console.WriteLine(string.Join(", ", arr));
            Sort(arr, 0, arr.Length - 1);
            Console.WriteLine("After sorting:");
            Console.WriteLine(string.Join(", ", arr));
        }
    }

}

