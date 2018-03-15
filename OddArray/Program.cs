using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddArray
{

    class Program
    {
        static int[] MakeOddArray(int left,int right)
        {
            int size;
            int[] arr;
            if (left % 2 == 0)
            {
                size = (right - left + 1) / 2;
                arr = new int[size];
                int idx = 0;
                for (int i = left+1; i <= right; i+=2)
                {
                    arr[idx++] = i;
                }
            }
            else
            {
                size = (right - left) / 2 + 1;
                arr = new int[size];
                int idx = 0;
                for (int i = left; i <= right; i+=2)
                {
                    arr[idx++] = i;
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());
            int r = Convert.ToInt32(Console.ReadLine());
            int[] newarr = MakeOddArray(l, r);

            foreach(int num in newarr)
            {
                Console.Write("{0}  ", num);
            }
        }
    }
}
