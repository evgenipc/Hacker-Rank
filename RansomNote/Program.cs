using System;
using System.Linq;
using System.Collections.Generic;
namespace RansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens[0]);
            int m = Convert.ToInt32(tokens[1]);
            List<string> available = Console.ReadLine().Split(' ').ToList();
            List<string> needed = Console.ReadLine().Split(' ').ToList();


            foreach (string word in needed)
            {
                if (!available.Remove(word))
                {
                    Console.WriteLine("No");
                    return;
                }

            }
            Console.WriteLine("Yes");
        }

        
    }
}
