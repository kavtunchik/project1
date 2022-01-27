using System;
using System.Collections.Generic;
using Collection.Data.Interfaces;
using Collection.Data.Models;

namespace Collection.Data.Repository
{
    public class CategoryRepository : IItemCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }



        IEnumerable<Category> IItemCategory.AllCategories => appDBContent.Category;
    }
}
