using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp3
{
    public class sorting
    {
        static void Main()
        {

            string file = "D:\\C#\\Searching-Sorting\\Searching-Sorting\\Details.txt";
            string[] textLines = File.ReadAllLines(file);


            Console.WriteLine("Enter the Search Keyword:");
            string searchKeyword = Convert.ToString(Console.ReadLine());
            List<string> results = new List<string>();

            foreach (string line in textLines)
            {
                while (line.Contains(searchKeyword))
                {
                    results.Add(line);
                    Console.WriteLine("Keyword is\n" + line);
                    break;


                }
                if (true)
                {
                    Console.WriteLine("Key Not Found");
                    break;

                }

            }
            Console.ReadLine();
        }

    }
}