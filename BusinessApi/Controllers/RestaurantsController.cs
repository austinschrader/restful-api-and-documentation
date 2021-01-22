using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BusinessApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BusinessApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RestaurantsController : ControllerBase
  {
    private BusinessApiContext _db;
    public RestaurantsController(BusinessApiContext db)
    {
      _db = db;
    }

    // GET api/Restaurants
    [HttpGet]
    public ActionResult<IEnumerable<Restaurant>> Get(string name, int pricing)
    {
      var query = _db.Restaurants.AsQueryable();
      if (pricing != 0)
      {
        query = query.Where(entry => entry.Pricing == pricing);
      }
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      return query.ToList();
    }

    // POST api/Restaurants
    [HttpPost]
    public void Post([FromBody] Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
    }

    // GET api/Restaurants/{id}
    [HttpGet("{id}")]
    public ActionResult<Restaurant> Get(int id)
    {
      return _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
    }

    // PUT api/Restaurants/{id}
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Restaurant restaurant)
    {
      restaurant.RestaurantId = id;
      _db.Entry(restaurant).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/Restaurant/{id}
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var RestaurantToDelete = _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
      _db.Restaurants.Remove(RestaurantToDelete);
      _db.SaveChanges();
    }
  }
}