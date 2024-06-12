using firstproject.Core;
using firstproject.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fisrtproject.Controllers
{
    public class UserController : Controller
    {
        private readonly DataHelper<User> dataHelper;
        private User user;
        public UserController(DataHelper<User> dataHelper)
        {
            this.dataHelper = dataHelper;
        }

        // GET: HomeController
        public ActionResult Index()
        {
            return View(dataHelper.getdata());
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            user = dataHelper.Find(id);
            return View(user);
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User collection)
        {
            try
            {
                dataHelper.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, User collection)
        {
            try
            {
                dataHelper.Edite(id , collection); 
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            user = dataHelper.Find(id);
            return View(user);
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, User collection)
        {
            try
            {
                dataHelper.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
