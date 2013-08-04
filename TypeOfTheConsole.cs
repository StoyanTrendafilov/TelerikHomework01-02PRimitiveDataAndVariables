using System;



    class TypeOnTheConsole
    {
        static void Main()
        {

            for (int ch = 0; ch < 128; ch++)
            {
                Console.WriteLine("The sign of character \"{0}\"  is : \"{1}\".", ch, (char)ch);
            }
        }
    }

