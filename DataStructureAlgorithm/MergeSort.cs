using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class MergeSort
    {
            private string[] arr;
            private string[] tempArr;

            public void Merge_Sort(string[] arr)
            {
                this.arr = arr;
                int n = arr.Length;
                this.tempArr = new string[n];
                Merge_Sort_Helper(0, n - 1);
            }

            private void Merge_Sort_Helper(int left, int right)
            {
                if (left < right)
                {
                    int mid = (left + right) / 2;
                    Merge_Sort_Helper(left, mid);
                    Merge_Sort_Helper(mid + 1, right);
                    Merge(left, mid, right);
                }
            }

            private void Merge(int left, int mid, int right)
            {
                for (int i = left; i <= right; i++)
                {
                    tempArr[i] = arr[i];
                }

                int leftIndex = left;
                int rightIndex = mid + 1;
                int currentIndex = left;

                while (leftIndex <= mid && rightIndex <= right)
                {
                    if (string.Compare(tempArr[leftIndex], tempArr[rightIndex]) < 0)
                    {
                        arr[currentIndex] = tempArr[leftIndex];
                        leftIndex++;
                    }
                    else
                    {
                        arr[currentIndex] = tempArr[rightIndex];
                        rightIndex++;
                    }
                    currentIndex++;
                }

                while (leftIndex <= mid)
                {
                    arr[currentIndex] = tempArr[leftIndex];
                    leftIndex++;
                    currentIndex++;
                }
            }
        
        public static void Merge_Sort()
        {

            Console.Write("Enter a list of strings separated by spaces: ");
            string[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            MergeSort mergeSort = new MergeSort();
            mergeSort.Merge_Sort(arr);

            Console.WriteLine("Sorted list:");
            foreach (string s in arr)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
    }

}

