using System;
   
    class Checking
    {
        static void Main()
        {
            bool isFemale = false; // може и да не се задава стойност, защото по default е false, но на мен така ми е по-прегледно.
            Console.WriteLine("it is {0}, that I am a female. ", isFemale);
          
           //Ако закоментирате горния вариант и откоментирате долния се получава по-интересна, поне за мен, програмка.
            //Console.Write("What is you gender: ");
            //string gender = Console.ReadLine().ToLower();
            //bool isFemale = gender.Equals("female");
            //System.Console.WriteLine("It is {0}, that you are female !", isFemale);
        }
    }

