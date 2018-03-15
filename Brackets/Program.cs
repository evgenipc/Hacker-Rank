using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static bool IfBalanced(char[] expression)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char bracket in expression)
        {
            switch (bracket)
            {
                case '(':
                    stack.Push(')');
                    break;
                case '{':
                    stack.Push('}');
                    break;
                case '[':
                    stack.Push(']');
                    break;
                default:
                    if (stack.Count!=0 && stack.Peek() == bracket)
                        stack.Pop();
                    else
                        return false;

                    break;
                    
            }

        }
        if (stack.Count == 0)
            return true;
        else
            return false;
    }
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            char[] expression = Console.ReadLine().ToCharArray();
            if (IfBalanced(expression))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
           
        }
    }
}