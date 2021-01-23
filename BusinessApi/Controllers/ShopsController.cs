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


  }
}