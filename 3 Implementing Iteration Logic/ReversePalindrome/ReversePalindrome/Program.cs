// SOURCE: https://www.sanfoundry.com
// AUTHOR: Manish Bhojasia
// FILENAME: GetFileTime
// PURPOSE: C# Program identifies if user's number is a palindrome.
// STUDENT: Antonio Santana
// DATE: 6 May 2019
// Changes: 


using System;

namespace ReversePalindrome
{
    class MainClass
    {
        public static void Main()
        {

            // Declare values as ints and initialize reverse as 0.
            int num, temp, remainder, reverse = 0;

            // Ask for user input and store value in num.
            Console.WriteLine("Enter an integer \n");
            num = int.Parse(Console.ReadLine());

            // The temp variable will initially share the same
            // value as num. 
            temp = num;

            // Execute as long as the num variable is greater than 0.
            while (num > 0)
            {
                // Divide the input by 10 and store remainder value in remainder. 
                remainder = num % 10;

                // Multiply the input by 10 add the remainder value and store in reverse.
                reverse = reverse * 10 + remainder;

                // Assign the value to num after it's divided by 10.
                // 'num /= 10' means 'num = num/10'.
                num /= 10;
            }

            Console.WriteLine("Given number is = {0}", temp);
            Console.WriteLine("Its reverse is  = {0}", reverse);

            // Are the temp and reverse variables the same? 
            // Returns true if the value is a palindrome.
            if (temp == reverse)
                Console.WriteLine("Number is a palindrome \n");
            else
                Console.WriteLine("Number is not a palindrome \n");
            Console.ReadLine();
        }
    }
}

/*      
        Example output:
        Enter an integer
        252
        Given number is = 252
        Its reverse is  = 252
        Number is a palindrome
*/
