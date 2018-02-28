using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<int> result = from value in Enumerable.Range(0, 2)
                                      select value;
            //foreach(int element in result)
            //{
            //    Console.WriteLine(element);
            //    Console.ReadLine();

            //}
            double average = result.Average();
            Console.WriteLine(average);
            Console.Read();

            List<int> list = result.ToList();
            int[] array = result.ToArray();

            //Models model = new Models();
            //model.name = "Hello World!";
            //Console.WriteLine(model.name);
            //Console.ReadLine();
            /**************
            **/
        }
    }
}
