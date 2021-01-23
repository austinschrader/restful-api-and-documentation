using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BusinessApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BusinessApi.Contollers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ShopsController : ControllerBase
  {

    private BusinessApiContext _db;
    public ShopsController(BusinessApiContext db)
    {
      _db = db;
    }

    // GET api/Shops
    [HttpGet]
    public ActionResult<IEnumerable<Shop>> Get(int pricing, string description)
    {
      var query = _db.Shops.AsQueryable();
      if (pricing != 0)
      {
        query = query.Where(entry => entry.Pricing == pricing);
      }
      if (description != null)
      {
        query = query.Where(entry => entry.Description == description);
      }
      return query.ToList();
    }

    // POST api/Shops
    [HttpPost]
    public void Post([FromBody] Shop shop)
    {
      _db.Shops.Add(shop);
      _db.SaveChanges();
    }


    // GET api/Shops/{id}
    [HttpGet("{id}")]
    public ActionResult<Shop> Get(int id)
    {
      return _db.Shops.FirstOrDefault(entry => entry.ShopId == id);
    }

    // PUT api/Shops/{id}
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Shop shop)
    {
      shop.ShopId = id;
      _db.Entry(shop).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/Shops/{id}
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var shopToDelete = _db.Shops.FirstOrDefault(entry => entry.ShopId == id);
      _db.Shops.Remove(shopToDelete);
      _db.SaveChanges();
    }

  }
}