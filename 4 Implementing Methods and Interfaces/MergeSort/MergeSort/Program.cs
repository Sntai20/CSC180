// SOURCE: https://www.sanfoundry.com
// AUTHOR: Sanfoundry
// FILENAME: MergeSort
// PURPOSE: C# Program to Perform Merge Sort.
// STUDENT: Antonio Santana
// DATE: 19 April 2019
// Changes: 
using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSort
{
    class MainClass
    {
        // This method accepts numbers, left, mid, and right integers.
        static public void mergemethod(int[] numbers, int left, int mid, int right)
        {
            // Create an array named temp of 25 elements.
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;

            // Split the collection.
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            // Make sure the collection is split in half.
            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];
            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }

        }

        static public void sortmethod(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                sortmethod(numbers, left, mid);
                sortmethod(numbers, (mid + 1), right);
                mergemethod(numbers, left, (mid + 1), right);

            }
        }

        // Create numbers array with 9 elements.
        static void Main(string[] args)
        {
            int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            int len = 9;
            Console.WriteLine("MergeSort :");

            // Call the sortmethod and subtract 1 to account for 0 element.
            sortmethod(numbers, 0, len - 1);

            // Iterate through the collection and print each element.
            for (int i = 0; i < 9; i++)
                Console.WriteLine(numbers[i]);
            Console.Read();
        }
    }
}



