using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using vidly.Dtos;

namespace vidly.Controllers.Api
{
    public class RentalController : ApiController
    {
        [HttpPost]
        public IHttpActionResult NewRental(NewRentalDto newRental)
        {
            throw new NotImplementedException();
        }
    }
}
