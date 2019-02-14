using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    public class RentalsController : Controller
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Rentals
        public ActionResult New()
        {
            return View();
        }


        public ActionResult GetRentals()
        {
            return View("ListOfRentals");
        }

        public void Return(int id)
        {
            var rental = _context.Rentals
                .Include(r => r.Customer)
                .Include(r => r.Movie)
                .SingleOrDefault(r => r.Id == id);

            rental.DateReturned = DateTime.Now;
            rental.Movie.NumberOfAvailable += 1;
            _context.SaveChanges();
        }

    }
}