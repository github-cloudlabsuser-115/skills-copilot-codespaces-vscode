using System;

public class Program
{

    
    public static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static void Main()
    {
        int number = 17; // Replace with the number you want to check

        if (IsPrime(number))
        {
            Console.WriteLine($"{number} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number.");
        }
    }
}