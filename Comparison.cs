using System;

    class Comparison
    {
        static void Main()
        {
            Console.Write("Please, enter your first number: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("Please, enter your second number: ");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("You have entered " + number1 + " and " + number2);
            bool comparison = (number1 > number2);
            System.Console.WriteLine("It is {0}, that the first number is greater than the second", comparison);
        }
    }

