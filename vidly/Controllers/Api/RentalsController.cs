using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using vidly.Dtos;
using vidly.Models;

namespace vidly.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = ApplicationDbContext.Create();
        }

        public IHttpActionResult GetRental()
        {
            var rentalDtos = _context.Rentals.Include(m=> m.Movie).Include(m=>m.Customer).ToList().Select(Mapper.Map<Rental, RentalDto>);

            return Ok(rentalDtos);
        }



        [HttpDelete]
        public IHttpActionResult ReturnRental(int id)
        {
            var rentalInDb = _context.Rentals.Include(m=>m.Movie).SingleOrDefault(r => r.Id == id);

            if (rentalInDb == null)
                return NotFound();
            rentalInDb.Movie.NumberAvailable++;
            _context.Rentals.Remove(rentalInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
