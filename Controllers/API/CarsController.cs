using Garage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Garage.Controllers.API
{
    public class CarsController : ApiController
    {
        GarageContext Garage = new GarageContext(); 



        // GET: api/Cars
        public IHttpActionResult Get()
        {
            List<Car> cars = Garage.Cars.ToList();
            return Ok(new { cars });
        }

        // GET: api/Cars/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cars
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cars/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cars/5
        public void Delete(int id)
        {
        }
    }
}
