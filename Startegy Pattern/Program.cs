using System;

namespace Startegy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var strategy = new Strategy();
            Console.WriteLine("Sort Order Of Given String List");
            Console.WriteLine("");
            strategy.SetStrategy(new OrderListSort());
            strategy.DoSomeBusinessLogic();
            Console.WriteLine("Reverse Order Of Given String List");
            Console.WriteLine("");
            strategy.SetStrategy(new OrderListReverse());
            strategy.DoSomeBusinessLogic();
        }
    }
}
