using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class GenreController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        // GET: Genres
        public ActionResult Index()
        {
            return View(context.Genres);
        }

        // GET: Genres
        public ActionResult Create()
        {
            return View();
        }

        // POST: Genres
        [HttpPost]
        public ActionResult Create(Genre genre)
        {
            context.Genres.Add(genre);
            context.SaveChanges();
            return View();
        }
    }
}