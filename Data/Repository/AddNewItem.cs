using System;
using Collection.Data.Interfaces;
using Collection.Data.Models;

namespace Collection.Data.Repository
{
    public class AddNewItem : ICreateItems {

        private readonly AppDBContent appDBContent;
        private readonly NewItem newItem;

        public ItemRepository(AppDBContent appDBContent, NewItem newItem) {
            this.appDBContent = appDBContent;
            this.newItem = newItem;

        }

        public void createItem(Item item) {
            appDBContent.Item.Add(item);
        }


    }
    
}
