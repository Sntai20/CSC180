// SOURCE: https://www.sanfoundry.com/csharp-program-atm-transaction/
// AUTHOR: Sanfoundry
// FILENAME: ATM.cs
// PURPOSE: C# Program to Display the ATM Transaction.
// STUDENT: Antonio Santana
// DATE: 19 April 2019
// Changes: int amount to decimal
//  else if (withdraw > (amount - 500))

using System;

namespace ATM
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Initalize amount, deposit, withdraw, pin, and choice
            decimal amount = 1000, deposit = 0, withdraw = 0;
            string choice; 
            string pin = "1234";

            // Read customer pin number as an integer.
            Console.WriteLine("Enter Your Pin Number ");
            pin = (Console.ReadLine());

            // Evaluate if pin matches.
            

            // Display the menu option.
            while (true)
            {
                Console.WriteLine("\n\n********Welcome to ATM Service**************\n");
                Console.WriteLine("1. Check Balance\n");
                Console.WriteLine("2. Withdraw Cash\n");
                Console.WriteLine("3. Deposit Cash\n");
                Console.WriteLine("4. Quit\n");
                Console.WriteLine("*********************************************\n\n");
                Console.WriteLine("Enter your choice: ");

                // Read the menu option selected and store the value in choice.
                choice = (Console.ReadLine());

                // To evaluate the menu option selected use this switch statement.
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\n Your balance is : ${0} ", amount);
                        break;
                    case "2":
                        Console.WriteLine("\n ENTER THE AMOUNT TO WITHDRAW: ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN MULTIPLES OF 100");
                        }
                        else if (withdraw > (amount))
                        {
                            Console.WriteLine("\n INSUFFICENT BALANCE");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n\n PLEASE COLLECT CASH");
                            Console.WriteLine("\n YOUR CURRENT BALANCE IS ${0}", amount);
                        }
                        break;
                    case "3":
                        Console.WriteLine("\n ENTER THE AMOUNT TO DEPOSIT");
                        deposit = int.Parse(Console.ReadLine());

                        // Validate deposit is a positive value.
                        if (deposit >= 0)
                        {
                            amount = amount + deposit;
                        }
                        else
                        {
                            Console.WriteLine("\n Please enter a positive value.");
                        }
                        Console.WriteLine("YOUR BALANCE IS ${0}", amount);
                        break;
                    case "4":
                        Console.WriteLine("\n\n Thank You for using the ATM");
                        break;
                    default:
                        Console.WriteLine("\n\n Please select one of the 4 options.");
                        break;
                }
            }
        }
    }
}
/*
Enter your choice: 
1

 Your balance is : $1000 


********Welcome to ATM Service**************

1. Check Balance

2. Withdraw Cash

3. Deposit Cash

4. Quit

*********************************************


Enter your choice: 
    */


