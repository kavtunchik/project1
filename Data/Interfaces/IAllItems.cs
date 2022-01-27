using System;
using System.Collections.Generic;
using global::Collection.Data.Models;


namespace Collection.Data.Interfaces
{
   public interface IAllItems
    {
        IEnumerable<Item> Items { get;  }
        IEnumerable<Item> getFavItems { get; }
        Item getObjectItem(int itemId);
    }
}