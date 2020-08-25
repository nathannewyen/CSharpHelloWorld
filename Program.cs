using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Nathan", "Adam", "Jane" };
            names[2] = "Hello Kid";
            Console.WriteLine(names[1]);
            Console.WriteLine(String.Join(" || ", names));

            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers);
            Console.WriteLine(String.Join(", ", numbers));

            List<string> DojoLocations = new List<string>();
            DojoLocations.Add("Dallas");
            DojoLocations.Add("Arlington");
            DojoLocations.Add("New York");
            DojoLocations.Add("Seattle");
            foreach (var location in DojoLocations)
            {
                Console.WriteLine(location);
            }
            Console.WriteLine(String.Join(", ", DojoLocations));

            Dictionary<string, object> Users = new Dictionary<string, object>();
            Users["William"] = 15;

            string input = "";

            while (!input.Equals("uncle"))
            {
                Console.WriteLine("Say Uncle!");
                input = Console.ReadLine();
            }
            PrintNumto255(100);
            Console.WriteLine(PrintNumto255(100));
        }

        static int PrintNumto255(int num)
        {
            int sum = 0;
            for (int i = num; i <= 255; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            if (sum == 100)
            {
                Console.WriteLine("100 here");
                return 0;
            }
            else
            {
                return sum;
            }
        }

    }
}
