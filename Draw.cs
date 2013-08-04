using System;
using System.Text;

    class Draw
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            char symbol = (char)0xA9;
            int columns = 5;
            int row = 3;
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine(new string(' ', columns - i) + new string(symbol, i * 2 + 1));
            }

        }
    }

