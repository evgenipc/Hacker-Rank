using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        Stack<int> pusher = new Stack<int>();
        Stack<int> popper = new Stack<int>();

        int q = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < q; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int query = Convert.ToInt32(input[0]);

            if (query == 1)
            {

                pusher.Push(Convert.ToInt32(input[1]));
            }
            else if (query == 2)
            {
                if (popper.Count == 0)
                {
                    while(pusher.Count!=0)
                    {
                        popper.Push(pusher.Pop());
                    }
                }
                popper.Pop();
            }
            else
            {
                if (popper.Count == 0)
                {
                    while (pusher.Count != 0)
                    {
                        popper.Push(pusher.Pop());
                    }
                }
                Console.WriteLine(popper.Peek());
            }
               
        }
      

    }
}