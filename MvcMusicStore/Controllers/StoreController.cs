using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        // GET: Store
        public ActionResult Index()
        {
            return View(context.Genres);
        }

        // GET: Store/Browse?genre=Disco
        public ActionResult Browse(string genre)
        {
            Genre genreModel = new Genre { Name = genre };
            return View(genreModel);
        }

        // GET: Store/Details/5
        public ActionResult Details(int id)
        {
            // Maak eerst een genre aan
            Genre genre = new Genre();
            genre.Id = 1;
            genre.Name = "Pop";

            // Dan maken we een artiest aan
            Models.Artist artist = new Models.Artist() { Id = 1, Name = "Coldplay" };

            // Maak nu een album aan
            Album album = new Album();
            album.Id = 1;
            album.Title = "Parachutes";
            album.Artist = artist;
            album.Genre = genre;
            return View(album);
        }
    }
}