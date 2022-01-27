using Collection.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Collection.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {

            if (ModelState.IsValid)
            {
                User user = null;
                using (UserContext db = new UserContext())
                {

                    user = db.Users.FirstOrDefault(u => u.name == model.name);
                }
                if (user == null)
                {
                    using (UserContext db = new UserContext())
                    {
                        db.Users.Add(new User { name = model.name, password = model.password });
                        db.SaveChanges();
                        user = db.Users.Where(u => u.name == model.name && u.password == model.password).FirstOrDefault();
                    }
                    if (user != null)
                    {
                       
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Пользователь с данным логином уже существует");
                }
            }
            return View(model);
        }
    }
}
