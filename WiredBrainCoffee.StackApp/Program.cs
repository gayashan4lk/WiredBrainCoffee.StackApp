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
            var stackDouble = new SimpleStackDouble();
            double sum = 0.0;

            stackDouble.Push(1.2);
            stackDouble.Push(2.8);
            stackDouble.Push(3.0);
            /*stack.Push(11);
            stack.Push(true);
            stack.Push("Some string");
            stack.Push(new object());*/

            while (stackDouble.Count > 0)
            {
                double item = (double)stackDouble.Pop();
                Console.WriteLine(item);
                sum += item;
            }

            Console.WriteLine(sum);
        }

        private static void StackStrings()
        {
            var stackString = new SimpleStackString();

            stackString.Push("Wired Brain Coffee");
            stackString.Push("CShrap generics");
            stackString.Push("Pluralsight");

            while (stackString.Count > 0)
            {
                object item = stackString.Pop();
                Console.WriteLine(item);
            }
        }
        
    }
}