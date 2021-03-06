﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Authorize(Roles = RoleName.canManageMovies)]
        public ActionResult New()
        {
            var genre = _context.Genres.ToList();

            var viewModel = new MovieEditViewModel
            {
                Genres = genre
            };
            return View("MovieForm",viewModel);
        }

        [HttpPost]
        [Authorize(Roles = RoleName.canManageMovies)]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieEditViewModel(movie)
                {
                    Genres = _context.Genres.ToList()
                };
                return View("MovieForm" , viewModel);
            }

            if (movie.Id == 0)
            {
                movie.NumberAvailable = movie.NumberInStock;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.DateAddedToDatabase = DateTime.Now;
                movieInDb.NumberInStock = movie.NumberInStock;

            }
            
            _context.SaveChanges();
            return RedirectToAction("ViewMovies", "Movies");
        }



        [Route("movies")]
        public ActionResult viewMovies()
        {
            if (User.IsInRole(RoleName.canManageMovies))
                return View("viewMovies");
            
            return View("viewMoviesReadOnly");           
        }


        //GET: (Movie/details)
        [Route("movies/details/{Id}")]
        public ActionResult movieDetails(int Id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == Id);
            return View(movie);
        }



        [Authorize(Roles = RoleName.canManageMovies)]
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c=> c.Id==id);

            if (movie == null)
                return HttpNotFound();
            var viewmodel = new MovieEditViewModel(movie)
            {
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm",viewmodel);
        }
    }
}