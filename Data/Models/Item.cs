using System;
namespace Collection.Data.Models
{
    public class Item
    {
       
        public int id { set; get; }
        public ushort price { set; get; }
        public string name { set; get; }
        public string desc { set; get; }
        public string img { set; get; }
        public bool isFavourite { set; get; }
        public int categoryId { set; get; }
        public string authorName { set; get; }
        public virtual Category Category { set; get; }
    }
}
