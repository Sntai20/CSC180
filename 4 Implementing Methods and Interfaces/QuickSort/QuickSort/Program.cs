// SOURCE: https://www.sanfoundry.com
// AUTHOR: Sanfoundry
// FILENAME: QuickSort
// PURPOSE: C# Program to Implement Quick Sort.
// STUDENT: Antonio Santana
// DATE: 30 April 2019
// Changes: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickSort
{
    class QuickSort
    {
        private int[] array = new int[20];
        private int len;

        public void quickSort()
        {
            sort(0, len - 1);
        }

        public void sort(int left, int right)
        {
            int pivot, leftend, rightend;

            leftend = left;
            rightend = right;
            pivot = array[left];

            while (left < right)
            {
                while ((array[right] >= pivot) && (left < right))
                {
                    right--;
                }

                if (left != right)
                {
                    array[left] = array[right];
                    left++;
                }

                while ((array[left] <= pivot) && (left < right))
                {
                    left++;
                }

                if (left != right)
                {
                    array[right] = array[left];
                    right--;
                }
            }

            array[left] = pivot;
            pivot = left;
            left = leftend;
            right = rightend;

            if (left < pivot)
            {
                sort(left, pivot - 1);
            }

            if (right > pivot)
            {
                sort(pivot + 1, right);
            }
        }

        public static void Main()
        {
            QuickSort q_Sort = new QuickSort();

            int[] array = { 4, 3, 1, 4, 6, 7, 5, 4, 32, 5, 26, 187, 8 };
            q_Sort.array = array;
            q_Sort.len = q_Sort.array.Length;
            q_Sort.quickSort();

            for (int j = 0; j < q_Sort.len; j++)
            {
                Console.WriteLine(q_Sort.array[j]);
            }
            Console.ReadKey();
        }
    }
}



 
