using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoinChangeProblem
{

    class Program
    {
        static int[] memoized;


        static long makeChange(int money, int[] coins)
        {
            int amountinCoin = 0;
            long ways = 0;
            while (amountinCoin <= money)
            {

            }

       
        public void Main(string[] args)
        {   
            // Input
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);

            string[] c_temp = Console.ReadLine().Split(' ');
            long[] c = Array.ConvertAll(c_temp, Int64.Parse);

            // memoization init

            memoized = new int[n];



        }


    }
}
