using System.Collections.Generic;
using Collection.Data.Models;

namespace Collection.Data.Interfaces {
   public interface IItemCategory {
        IEnumerable<Category> AllCategories { get; }
    }
}