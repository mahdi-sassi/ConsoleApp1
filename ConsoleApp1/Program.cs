using ConsoleApp1Mahdi;
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
            
            double average = result.Average();
           

            List<int> list = result.ToList();
            int[] array = result.ToArray();

            //Models model = new Models();
            //model.name = "Hello World!";
            //Console.WriteLine(model.name);
            //Console.ReadLine();
            /**************
            **/
            Example example = new Example();
            example.Month = new List<string>();
            example.Month.Add("Janvier");
            example.Month.Add("Février");
            example.Month.Add("Mars");
            example.Month.Add("Avril");
            example.Month.Add("Mais");
            example.Month.Add("Juin");
            example.Month.Add("Juillet");
            example.Month.Add("Aout");
            example.Month.Add("Septembre");
            example.Month.Add("Octobre");
            example.Month.Add("Novembre");
            example.Month.Add("Décembre");
            IEnumerable<string> iEnumerableOfString = (IEnumerable<string>)example.Month;
            foreach (string element in example.Month)
            {
                Console.WriteLine(element);
                Console.ReadLine();

            }
        }
    }
}
