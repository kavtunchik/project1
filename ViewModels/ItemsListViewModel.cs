using System;
using System.Collections.Generic;
using Collection.Data.Models;

namespace Collection.ViewModels
{
    public class ItemsListViewModel
    {
       public IEnumerable<Item> allItems { get; set; }
        public string currCategory { get; set; }
    }
}
