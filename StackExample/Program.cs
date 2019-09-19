using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(34);
            stack.Push(455);
            
            for(int i = 0; i < stack.Count; i--)
            {
                try
                {
                    Console.WriteLine(stack.Peek());
                    Console.WriteLine(stack.Pop());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Стек ПУСТ");
                    break;
                }

            }

            Console.ReadLine();
        }
    }
}
