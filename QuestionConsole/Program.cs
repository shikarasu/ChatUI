using System;

namespace QuestionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello! " + name);
            Console.ReadKey();

            Console.WriteLine("Where do you live?");
            string name1 = Console.ReadLine();
            Console.WriteLine(name1 + "?" + " Where is that?");
            Console.ReadKey();

            Console.WriteLine("That Sounds Nice!");
            string name2= Console.ReadLine();
            Console.WriteLine(name2 + "." + " I would like to go there some day...");
            Console.ReadKey();

           
            Console.WriteLine("Maybe I could visit one day.");
            string name3 = Console.ReadLine();
            
            Console.ReadKey();
        }
    }
}

