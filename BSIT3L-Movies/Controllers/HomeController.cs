using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
         new MovieViewModel { Id = 1, Name = "Prison Break", Rating = "8", ReleaseYear = 2018, Genre = "Action/Crime/Drama", ImageUrl ="/pics/prisonbreak.jpg" },
        new MovieViewModel { Id = 2, Name = "Insidious", Rating = "6.7", ReleaseYear = 2001, Genre = "Horror/Thriller", ImageUrl ="/pics/insidious.jpg" },
        new MovieViewModel { Id = 3, Name = "Spiderman", Rating = "7.3", ReleaseYear = 2017, Genre = "Action/Adventure", ImageUrl ="/pics/spiderman.jpg" },
         new MovieViewModel { Id = 4, Name = "Dennis the menace", Rating = "5.6", ReleaseYear = 2009, Genre = "Comedy/Family", ImageUrl ="/pics/dennis.jpg"},
        new MovieViewModel { Id = 5, Name = "Extortion", Rating = "6.2", ReleaseYear = 2013, Genre = "Action/Adventure/Crime", ImageUrl ="/pics/extortion.jpg"},
        new MovieViewModel { Id = 6, Name = "Train To Busan", Rating = "7.6", ReleaseYear = 2004, Genre = "Action/Horror/Thriller", ImageUrl ="/pics/traintobusan.jpg" },
        new MovieViewModel { Id = 7, Name = "Jumanji", Rating = "7", ReleaseYear = 2001, Genre = " Adventure/Comedy/Family", ImageUrl ="/pics/jumanji.jpg" },
         new MovieViewModel { Id = 8, Name = "Transformers", Rating = "7", ReleaseYear = 1989, Genre = "Action/Adventure/Sci-Fi", ImageUrl ="/pics/transformers.jpg" },
        new MovieViewModel { Id = 9, Name = "Wrong Turn", Rating = "7", ReleaseYear = 2014, Genre = "Horror/Thriller", ImageUrl ="/pics/wrongturn.jpg" },
        new MovieViewModel { Id = 10, Name = "The Purge", Rating = "6.1", ReleaseYear = 2014, Genre = "Horror/Thriller/Action", ImageUrl ="/pics/thepurge.jfif" },
        new MovieViewModel { Id = 11, Name = "Bird Box", Rating = "6.6", ReleaseYear = 2014, Genre = "Drama/Horror/Sci-Fi", ImageUrl ="/pics/birdbox.jpg"},
        new MovieViewModel { Id = 12, Name = "John Wick", Rating = "7.4", ReleaseYear = 2009, Genre = "Action/Crime/Thriller", ImageUrl ="/pics/johnwick.jpg" },
        new MovieViewModel { Id = 13, Name = "Pacific Rim", Rating = "6.9", ReleaseYear = 2015, Genre = "Action/Adventure/Sci-Fi", ImageUrl ="/pics/pacificrim.jpg" },
        new MovieViewModel { Id = 14, Name = "Jigsaw", Rating = "5.8", ReleaseYear = 1996, Genre = "Crime/Horror/Mystery", ImageUrl ="/pics/jigsaw.jpg" },
        new MovieViewModel { Id = 15, Name = "The Conjuring", Rating = "7.5", ReleaseYear = 2017, Genre = "Horror/Mystery/Thriller", ImageUrl ="/pics/conjuring.jpg" },
        };
    }

    public IActionResult Index()
    {
        return View(_movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}