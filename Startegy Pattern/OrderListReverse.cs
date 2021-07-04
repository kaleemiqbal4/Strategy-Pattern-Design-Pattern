using System.Collections.Generic;

namespace Startegy_Pattern
{
    /// <summary>Reverse the List</summary>
    public class OrderListReverse: IOrderList
    {
        /// <summary>Method to Sort Order</summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public List<string> OrderList(List<string> list)
        {
            list.Sort();
            list.Reverse();
            return list;
        }
    }
}
