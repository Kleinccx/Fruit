using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myfile = @"fruit.txt";
          //  File.WriteAllText(myfile, "");



            using (StreamWriter sw = File.AppendText(myfile))
          
            {

                sw.WriteLine("Banana");
                sw.WriteLine("Watermelon");
                sw.WriteLine("Cherry");
                sw.WriteLine("Strawberry");
                sw.WriteLine("Apple");
               


            }
            using (StreamReader sr = File.OpenText(myfile))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);

                }
            }

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Search a fruit: ");
                string search = Console.ReadLine();
                string[] lines = File.ReadAllLines(myfile);

                string found = "Not Found";
                foreach (string line in lines)
                {
                    if (line.Contains(search))
                    {
                        found = "Found";

                        break;
                    }


                }
                Console.WriteLine(found);

            }
        }

    }
    }




