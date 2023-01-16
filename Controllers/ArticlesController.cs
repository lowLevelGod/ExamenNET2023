using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ModelExam2022.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly AppDBContext db;

        public ArticlesController(AppDBContext ctx)
        {
            db = ctx;
        }
        public IActionResult Index()
        {
            var articles = db.Articles.Include(x => x.Category);
            ViewBag.Articles = articles.ToList<Article>();
            return View();
        }

        public IActionResult Read(int id)
        {
            var article = db.Articles.Where(x => x.Id == id).Include(x => x.Category).FirstOrDefault();
            ViewBag.Article = article;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Article a)
        {
            a.Date = DateTime.Now;
            a.Category = db.Categories.Find(Int32.Parse(Request.Form["category"]));
            db.Articles.Add(a);
            db.SaveChanges();

            return RedirectToAction(actionName: "Read", new { id = a.Id });
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.cats = db.Categories.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var article = db.Articles.Where(x => x.Id == id).Include(x => x.Category).FirstOrDefault();
            ViewBag.cats = db.Categories.ToList();
            Console.WriteLine(article.Category.Id);
            return View(article);
        }


        [HttpPost]
        public IActionResult Edit(Article a)
        {
            var article = db.Articles.Where(x => x.Id == a.Id).FirstOrDefault();

            var c = db.Categories.Find(Int32.Parse(Request.Form["category"]));

            article.Title = a.Title;
            article.Category = c;
            article.Content = a.Content;

            db.SaveChanges();

            return RedirectToAction(actionName: "Read", new { id = a.Id });
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var article = db.Articles.Where(x => x.Id == id).Include(x => x.Category).FirstOrDefault();
            db.Articles.Remove(article);
            db.SaveChanges();

            return RedirectToAction(actionName: "Index");
        }
    }
}
