using Microsoft.AspNetCore.Mvc;
using Blog.Models;
using Blog.Data;
using Microsoft.AspNetCore.Identity.UI.Pages.Internal.Account;
using System.Threading.Tasks;

namespace blog.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _ctx;

        public HomeController(AppDbContext ctx)
        {
            _ctx = ctx;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Post()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View(new Post());
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Post post)
        {
            _ctx.Posts.Add(post);
            await _ctx.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}