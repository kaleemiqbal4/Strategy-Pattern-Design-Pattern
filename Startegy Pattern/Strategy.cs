using System;
using System.Collections.Generic;

namespace Startegy_Pattern
{
    /// <summary>Strategy Class</summary>
    public class Strategy
    {
        private IOrderList _orderCharList;

        /// <summary></summary>
        public Strategy()
        {

        }

        /// <summary>Constructor to initialize readonly properties</summary>
        /// <param name="orderCharList"></param>
        public Strategy(IOrderList orderCharList)
        {
            this._orderCharList = orderCharList;
        }

        /// <summary> Usually, the Context allows replacing a Strategy object at runtime.</summary>
        /// <param name="orderCharList"></param>
        public void SetStrategy(IOrderList orderCharList)
        {
            this._orderCharList = orderCharList;
        }

        /// <summary>Print String</summary>
        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
            var result = this._orderCharList.OrderList(new List<string> { "a", "b", "c", "d", "e" });

            string resultStr = string.Empty;
            foreach (var element in result)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);
        }
    }
}
