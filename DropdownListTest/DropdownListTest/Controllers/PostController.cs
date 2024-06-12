using DropdownListTest.Data;
using DropdownListTest.EntityClasses;
using DropdownListTest.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DropdownListTest.Controllers
{
    public class PostController : Controller
    {
        private readonly IDatahelper<AuthorPost> authorpostdata;
        private readonly IDatahelper<Author> forAuthor;
        private readonly IDatahelper<Book> forBook;
        private readonly IWebHostEnvironment webHost;

        public PostController(IDatahelper<AuthorPost> authorpostdata, IDatahelper<Author> forAuthor,IDatahelper<Book> forBook
            ,IWebHostEnvironment webHost)
        {
            this.authorpostdata = authorpostdata;
            this.forAuthor = forAuthor;
            this.forBook = forBook;
            this.webHost = webHost;
        }

        // GET: PostController
        public ActionResult Index()
        {
            return View(authorpostdata.GetTables());
        }

        // GET: PostController/Details/5
        public ActionResult Details(int id)
        {

            return View(authorpostdata.Find(id));
        }

        // GET: PostController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: PostController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AuthorPostView collection)
        {
            try
            {
                var model = new AuthorPost
                {
                    Id = collection.Id,
                    PostCategory = collection.PostCategory,
                    PostAuthor = collection.PostAuthor,

                    author=collection.author,
                    AuthorId=forAuthor.GetTables().Where(x=>x.Name==collection.PostAuthor).Select(x=>x.Id).First(),
                    book=collection.book,
                    BookId = forBook.GetTables().Where(x => x.Title == collection.PostCategory).Select(x => x.Id).First(),
                    PostImageUrl=UploadFile(collection.PostImageUrl,"Images")
                    

                };
                authorpostdata.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PostController/Edit/5
        public ActionResult Edit(int id)
        {
            var post= authorpostdata.Find(id);
            var authorpost = new AuthorPostView
            {
                Id = post.Id,
                author = post.author,
                AuthorId = forAuthor.GetTables().Where(x => x.Name == post.PostAuthor).Select(x => x.Id).First(),
                book = post.book,
                BookId = forBook.GetTables().Where(x => x.Title == post.PostCategory).Select(x => x.Id).First(),
                PostCategory=post.PostCategory,
                PostAuthor=post.PostAuthor

            };
            return View(authorpost);
        }

        // POST: PostController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, AuthorPostView collection)
        {
            try
            {
                var model = new AuthorPost
                {
                    Id = collection.Id,
                    PostCategory = collection.PostCategory,
                    PostAuthor = collection.PostAuthor,

                    author = collection.author,
                    AuthorId = forAuthor.GetTables().Where(x => x.Name == collection.PostAuthor).Select(x => x.Id).First(),
                    book = collection.book,
                    BookId = forBook.GetTables().Where(x => x.Title == collection.PostCategory).Select(x => x.Id).First(),
                    PostImageUrl = UploadFile(collection.PostImageUrl, "Images")


                };
                authorpostdata.Update(id,model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PostController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PostController/Delete/5
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

        public string UploadFile(IFormFile file, string folder)
        {
            if (file != null)
            {
                var fileDir = Path.Combine(webHost.WebRootPath, folder);
                var fileName = Guid.NewGuid() + "-" + file.FileName;
                var filePath = Path.Combine(fileDir, fileName);

                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                    return fileName;
                }

            }
            else
            {
                return string.Empty;
            }
        }
  


    }
}
