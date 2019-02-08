﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    [Authorize]
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

        public ViewResult Index()
        {
            if(User.IsInRole(RoleName.CanManageMovies) || User.IsInRole(RoleName.CanManageMoviesAndCustomers))
                return View("List");

            return View("ReadOnlyList");
        }

        [Authorize(Roles = RoleName.CanManageMoviesOrCanManageMoviesAndCustomers)]
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.Include(m=> m.Genre).SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return HttpNotFound();
            var viewModel = new MovieFormViewModel()
            {
                Movie = movie,
                Genre = _context.Genres.ToList()
            };
            return View("MovieForm",viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageMoviesOrCanManageMoviesAndCustomers)]
        public ActionResult Save(MovieDto movie)
        {
            if (!ModelState.IsValid)
            {
                var movieForm = new MovieFormViewModel()
                {
                    Movie = new Movie(),
                    Genre = _context.Genres.ToList()
                };

                return View("MovieForm", movieForm);
            }

            if (movie.Id == 0)
            {
                var movieToDb  = new Movie();
                Mapper.Map(movie, movieToDb);
                movieToDb.NumberOfAvailable = movie.NumberInStock;
                _context.Movies.Add(movieToDb);
            }
            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);
                var inStockBeforeChanges = movieInDb.NumberInStock;
                Mapper.Map<MovieDto, Movie>(movie, movieInDb);
                var changeForNumberOfAvailable =  movie.NumberInStock - inStockBeforeChanges;
                movieInDb.NumberOfAvailable += changeForNumberOfAvailable;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
        
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }

        [Authorize(Roles = RoleName.CanManageMoviesOrCanManageMoviesAndCustomers)]
        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel()
            {
                Movie = new Movie(),
                Genre = genres
            };
            return View("MovieForm",viewModel);
        }
    }
}