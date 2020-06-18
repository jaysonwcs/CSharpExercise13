using Exercise_13.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\C Sharp\Exercise 13\";
            string targetPath = @"D:\C Sharp\Exercise 13\out\";

            List<Item> list = new List<Item>();

            try
            {
                using StreamReader sr = File.OpenText(path + "in.csv");
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');

                    list.Add(new Item(line[0], double.Parse(line[1], CultureInfo.InvariantCulture), int.Parse(line[2])));
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has ocurred:");
                Console.WriteLine(e.Message);
            }

            try
            {
                using StreamWriter sw = File.AppendText(targetPath + "summary.csv");
                foreach (Item item in list)
                {
                    sw.WriteLine(item.Name + "," + (item.Price * item.Quantity).ToString(CultureInfo.InvariantCulture));
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has ocurred:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
