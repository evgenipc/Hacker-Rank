using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRotation
{
    class Program
    {
        static void DoRotation(int n, int[] arr, int rotations)
        {
            int[] tmp = new int[rotations];
            for (int i = 0; i < rotations; i++)
            {
                tmp[i] = arr[i];
            }
            for (int i = 0; i <n - rotations; i++)
            {
                arr[i] = arr[i + rotations];
            }
            for (int i = n-rotations; i < n; i++)
            {
                arr[i] = tmp[i-n+rotations];
            }
            Console.WriteLine(string.Join(" ",arr));
        }

        static void PrintLeftRotation(int n, int[] arr, int rotations)
        {
            for(int i =rotations; i< n;++i)
            {
                Console.Write("{0} ",arr[i]);
            }
            for(int i=0; i< rotations; ++i)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
        static void Main(string[] args)
        {

            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            PrintLeftRotation(n, a, k);
            Console.WriteLine();
            DoRotation(n, a, k);
        }
    }


}
