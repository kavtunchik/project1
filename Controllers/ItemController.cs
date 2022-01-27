using System;
using Collection.Data.Interfaces;
using Collection.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Collection.Controllers
{
    public class ItemController : Controller {

        private readonly IAllItems _allItem;
        private readonly IItemCategory _allCategories;

        public ItemController(IAllItems iAllItems,IItemCategory iIitemCategory)
        {
            _allItem = iAllItems;
            _allCategories = iIitemCategory;
        }

        public ViewResult List() {
            ViewBag.Title = "Главная страница";
            ItemsListViewModel obj = new ItemsListViewModel();
            obj.allItems = _allItem.Items;
            obj.currCategory = "Недавно добавленные айтемы";
            return View(obj);


        }

    }
}
