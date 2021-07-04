using System;
using System.Collections.Generic;

namespace Startegy_Pattern
{
    /// <summary>Concrete class to Sort Order of Given List</summary>
    public class OrderListSort : IOrderList
    {
        /// <summary>Method to Sort Order</summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public List<string> OrderList(List<string> list)
        {
            list.Sort();
            return list;
        }
    }
}
