using System;

namespace WiredBrainCoffee.StackApp
{
    class Program
    {
        static void Main(String[] args)
        {
            StackDoubles();
            StackStrings();
        }

        private static void StackDoubles()
        {
            var stack = new Stack<double>();
            double sum = 0.0;

            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);

            while (stack.Count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine(item);
                sum += item;
            }

            Console.WriteLine(sum);
        }

        private static void StackStrings()
        {
            var stack = new Stack<string>();

            stack.Push("Wired Brain Coffee");
            stack.Push("CShrap generics");
            stack.Push("Pluralsight");

            while (stack.Count > 0)
            {
                object item = stack.Pop();
                Console.WriteLine(item);
            }
        }
        
    }
}