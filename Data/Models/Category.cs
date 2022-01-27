using System;
using System.Collections.Generic;

namespace Collection.Data.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public string desc { set; get; }
        public List<Item> item { set; get; }

    }
}
