using System;

namespace WiredBrainCoffee.StackApp
{
    class Program
    {
        static void Main(String[] args)
        {
            var stack = new SimpleStack();
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
    }
}