using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Models model = new Models();
            model.name = "Hello World!";
            Console.WriteLine(model.name);
            Console.ReadLine();
           
        }
    }
}
