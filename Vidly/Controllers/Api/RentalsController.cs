using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }


        // GET: api/Rentals
        public IHttpActionResult GetRentals()
        {
            var rentalsQuery = _context.Rentals.Include(r => r.Customer).Include(r => r.Movie);
            var rentalsDtos = rentalsQuery.ToList().Select(Mapper.Map<Rental, RentalDto>);

            return Ok(rentalsDtos);
        }
        
        // GET: api/Rentals/5
        public IHttpActionResult GetRental(int id)
        {
            var rental = _context.Rentals.SingleOrDefault(r => r.Id == id);
            if (rental == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return Ok(Mapper.Map<Rental, RentalDto>(rental));
        }

        // POST: api/Rentals
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Rentals/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Rentals/5
        public void Delete(int id)
        {
        }
    }

    
}
