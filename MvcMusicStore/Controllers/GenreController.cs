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

        public ActionResult Details(int id)
        {
            Genre genre = context.Genres.FirstOrDefault(
                g => g.Id == id);
            return View(genre);
        }
        public ActionResult Edit(int id)
        {
            Genre genre = context.Genres.FirstOrDefault(
                g => g.Id == id);
            return View(genre);
        }

        [HttpPost]
        public ActionResult Edit(Genre genre)
        {
            int id = genre.Id;
            Genre oldGenre  = context.Genres.FirstOrDefault(
                g => g.Id == id);
            oldGenre.Name = genre.Name;
            oldGenre.Description = genre.Description;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Genre genre = context.Genres.FirstOrDefault(
                g => g.Id == id);
            return View(genre);
        }

        [HttpPost]
        public ActionResult Delete(Genre genre)
        {
            Genre oldGenre = context.Genres.FirstOrDefault(
                g => g.Id == genre.Id);
            context.Genres.Remove(oldGenre);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}