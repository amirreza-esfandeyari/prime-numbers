using System;

class Program
{
    static void Main()
    {
        // Getting input from the user
        Console.Write(" Enter the first number (m): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write(" Enter the second number (n) : ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("اعداد آینه‌ای بین " + m + " و " + n + " عبارتند از:");

        // Check any number between m و n
        for (int number = m; number <= n; number++)
        {
            // Convert number to string
            string strNumber = number.ToString();
            // Reverse the string
            char[] charArray = strNumber.ToCharArray();
            Array.Reverse(charArray);
            string reversedNumber = new string(charArray);

            // Check if the number is a mirror
            if (strNumber == reversedNumber)
            {
                Console.Write(number + " "); // Mirror number printing
            }
        }
    }
}