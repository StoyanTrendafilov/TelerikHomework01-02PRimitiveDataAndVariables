using System;

    class WorldHello
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object both = (hello + " " + world);
           // Console.WriteLine(both);
            string them = both.ToString();
            Console.WriteLine(them);
        }
    }

