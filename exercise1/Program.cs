using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine().ToLower();
            Console.ReadKey();

            string[] names = new string[3];
            names[0] = "shane";
            names[1] = "bob";
            names[2] = "fred";
            bool isName = false;

            for(int i = 0; i < names.Length; i++ )
            {
                if(name == names[i])
                {
                    isName = true;
                }
            }

            if(isName == true)
            {
                Console.WriteLine("Your name is in the list");
            }
            else
            {
                Console.WriteLine("Name isn't on list");
            }


        }
    }
}
