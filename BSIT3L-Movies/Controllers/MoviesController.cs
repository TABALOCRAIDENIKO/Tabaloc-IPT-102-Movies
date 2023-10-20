using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace BSIT3L_Movies.Controllers
{
    public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
        {
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
        new MovieViewModel { Id = 1, Name = "Prison Break", Rating = "8", ReleaseYear = 2018, Genre = "Action/Crime/Drama", ytid = "AL9zLctDJaU", ImageUrl ="/pics/prisonbreak.jpg" },
        new MovieViewModel { Id = 2, Name = "Insidious", Rating = "6.7", ReleaseYear = 2001, Genre = "Horror/Thriller", ytid = "zuZnRUcoWos", ImageUrl ="/pics/insidious.jpg" },
        new MovieViewModel { Id = 3, Name = "Spiderman", Rating = "7.3", ReleaseYear = 2017, Genre = "Action/Adventure", ytid = "t06RUxPbp_c", ImageUrl ="/pics/spiderman.jpg" },
         new MovieViewModel { Id = 4, Name = "Dennis the menace", Rating = "5.6", ReleaseYear = 2009, Genre = "Comedy/Family", ytid = "8CogDP0vlfw", ImageUrl ="/pics/dennis.jpg"},
        new MovieViewModel { Id = 5, Name = "Extortion", Rating = "6.2", ReleaseYear = 2013, Genre = "Action/Adventure/Crime", ytid = "VXWSUBlBHwk", ImageUrl ="/pics/extortion.jpg"},
        new MovieViewModel { Id = 6, Name = "Train To Busan", Rating = "7.6", ReleaseYear = 2004, Genre = "Action/Horror/Thriller", ytid = "1ovgxN2VWNc", ImageUrl ="/pics/traintobusan.jpg" },
        new MovieViewModel { Id = 7, Name = "Jumanji", Rating = "7", ReleaseYear = 2001, Genre = " Adventure/Comedy/Family", ytid = "eTjDsENDZ6s", ImageUrl ="/pics/jumanji.jpg" },
         new MovieViewModel { Id = 8, Name = "Transformers", Rating = "7", ReleaseYear = 1989, Genre = "Action/Adventure/Sci-Fi", ytid = "v8ItGrI-Ou0", ImageUrl ="/pics/transformers.jpg" },
        new MovieViewModel { Id = 9, Name = "Wrong Turn", Rating = "7", ReleaseYear = 2014, Genre = "Horror/Thriller", ytid = "9lIUi6xWflg", ImageUrl ="/pics/wrongturn.jpg" },
        new MovieViewModel { Id = 10, Name = "The Purge", Rating = "6.1", ReleaseYear = 2014, Genre = "Horror/Thriller/Action", ytid = "K0LLaybEuzA", ImageUrl ="/pics/thepurge.jpg" },
        new MovieViewModel { Id = 11, Name = "Bird Box", Rating = "6.6", ReleaseYear = 2014, Genre = "Drama/Horror/Sci-Fi", ytid = "o2AsIXSh2xo", ImageUrl ="/pics/birdbox.jpg"},
        new MovieViewModel { Id = 12, Name = "John Wick", Rating = "7.4", ReleaseYear = 2009, Genre = "Action/Crime/Thriller", ytid = "C0BMx-qxsP4", ImageUrl ="/pics/johnwick.jpg" },
        new MovieViewModel { Id = 13, Name = "Pacific Rim", Rating = "6.9", ReleaseYear = 2015, Genre = "Action/Adventure/Sci-Fi", ytid = "5guMumPFBag", ImageUrl ="/pics/pacificrim.jpg" },
        new MovieViewModel { Id = 14, Name = "Jigsaw", Rating = "5.8", ReleaseYear = 1996, Genre = "Crime/Horror/Mystery", ytid = "vPP6aIw1vgY", ImageUrl ="/pics/jigsaw.jpg" },
        new MovieViewModel { Id = 15, Name = "The Conjuring", Rating = "7.5", ReleaseYear = 2017, Genre = "Horror/Mystery/Thriller", ytid = "ejMMn0t58Lc", ImageUrl ="/pics/conjuring.jpg" },
     };
        }
        public IActionResult Index()
        {
            return View(_movies);
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}