using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Userinfo.core;
using UserInfo.Data;
namespace Projem.Controllers
{
    public class Controllers : Controller
    {
        private readonly IDataHelper<User> dataHelper;
       private  List<User> Arr;
        private User user;
        public Controllers(IDataHelper<User> dataHelper)
        {
            this.dataHelper = dataHelper;
        }

        // GET: Controller
        public ActionResult Index()
        {
            return View(dataHelper.Getdata());
        }

        // GET: Controller/Details/5
        public ActionResult Details(int id)
        {
            user = dataHelper.Find(id);
            return View(user);
        }

        // GET: Controller/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Controller/Create
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

        // GET: Controller/Edit/5
        public ActionResult Edit(int id)
        {
            user = dataHelper.Find(id);
            return View(user);
        }

        // POST: Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User collection)
        {
            try
            {
               // dataHelper.Edite(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Controller/Delete/5
        public ActionResult Delete(int id)
        {
            user = dataHelper.Find(id);
            return View(user);
        }

        // POST: Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
