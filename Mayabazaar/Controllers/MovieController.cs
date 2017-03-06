﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mayabazaar.Models;

namespace Mayabazaar.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            List<Movie> Movies = new List<Movie>();
            Movies.Add(new Movie() { Name = "Avatar" });
            Movies.Add(new Movie() { Name = "Dark Knight Rises"});
            Movies.Add(new Movie() { Name = "Ted" });
            Movies.Add(new Movie() { Name = "The Terminal" });

            return View(Movies);

        }
    }
}