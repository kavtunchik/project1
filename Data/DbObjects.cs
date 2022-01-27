using System;
using System.Collections.Generic;
using System.Linq;
using Collection.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Collection.Data
{
    public class DbObjects
    {
        public static void Initial(AppDBContent content) {



            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Item.Any()) {
                content.AddRange(
                     new Item { name = "Водка", desc = "Редкий экземпляр", img = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0a/Vodka_bottle.jpg/1200px-Vodka_bottle.jpg", price = 700, isFavourite = false, Category = Categories["Алкоголь"],authorName = "Admin" },
                     new Item { name = "Виски", desc = "10 летний", img = "https://bipbap.ru/wp-content/uploads/2018/09/1442946458_viski-i-konyak-v-chem-raznica-1-640x426.jpg", price = 4500, isFavourite = true, Category = Categories["Алкоголь"], authorName = "Admin" },
                     new Item { name = "Война и мир", desc = "Написал Лев Толстой", img = "https://s2-goods.ozstatic.by/2000/342/917/10/10917342_0.jpg", price = 2800, isFavourite = false, Category = Categories["Книги"], authorName = "Admin" },
                     new Item { name = "Брсм", desc = "Белорусский значек", img = "https://gymn7.minskedu.gov.by/files/00335/obj/110/5663/img/76113.jpg", price = 100, isFavourite = true, Category = Categories["Значки"], authorName = "Admin" },
                     new Item { name = "Гарри Поттер", desc = "Написала Дж.Роулинг", img = "https://icdn.lenta.ru/images/2016/05/31/18/20160531180534953/pic_cb94216a4a6c5bad285809a124ae190d.jpg", price = 3000, isFavourite = true, Category = Categories["Книги"], authorName = "Admin" }

                    );
            }
            content.SaveChanges();
        }


        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories {
            get {
                if (category == null) {
                    var list = new Category[] {
                        new Category { categoryName = "Книги",desc = "Колекция книг"},
                        new Category { categoryName = "Алкоголь",desc = "Колекция алкоголя"},
                        new Category { categoryName = "Значки",desc = "Колекция значков"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }

        }
    }
}
