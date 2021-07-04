using System.Collections.Generic;

namespace Startegy_Pattern
{
    /// <summary>Set Order of the List</summary>
    public interface IOrderList
    {
        /// <summary>Set Order of List</summary>
        List<string> OrderList(List<string> list);
    }
}
