using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int NumberOfDifferences(string a, string b)
    {
        int result = 0;
        int[] freq1 = new int[26];
        int[] freq2 = new int[26];
        foreach (char chr in a)
        {
            freq1[Convert.ToInt32(chr) -'a']++;
        }
        foreach (char chr in b)
        {
            freq2[Convert.ToInt32(chr) -'a']++;
        }

        for (int i = 0; i < 26; i++)
        {
            result += Math.Abs(freq1[i] - freq2[i]);
        }

        return result;
    }
    static void Main(String[] args)
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();

        Console.WriteLine(NumberOfDifferences(a, b));
    }
}
