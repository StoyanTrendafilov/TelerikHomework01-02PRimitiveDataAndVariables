using System;



    class Changer
    {
        static void Main()
        {
            int first = 5;
            int second = 10;
            int memory;
            memory = first;
            first = second;
            second = memory;
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }

