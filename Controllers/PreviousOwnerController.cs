using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using PagedList;

namespace AnimalShelter.Controller
{
  [Route("api/[controller]")]
  [ApiController]
  public class PreviousOwnerController : ControllerBase
  {
    private AnimalShelterContext _db;

    public PreviousOwnerController(AnimalShelterContext db)
    {
      _db = db;
    }

    // GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<PreviousOwner>> Get(int timesReHomed, int? page)
    {
      var query = _db.PreviousOwners.AsQueryable();
      if (timesReHomed != 0)
      {
        query = query.Where(entry => entry.TimesReHomed == timesReHomed);
      }
   
      int pageSize = 5;
      int pageNumber = (page ?? 1);

      return query.ToPagedList(pageNumber,pageSize).ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<PreviousOwner> Get(int id)
    {
      return _db.PreviousOwners.FirstOrDefault(entry => entry.PreviousOwnerId == id);
    }

    // POST api/animals
    [HttpPost]
    public void Post([FromBody] PreviousOwner previousOwner)
    {
      _db.PreviousOwners.Add(previousOwner);
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] PreviousOwner previousOwner)

    {
      previousOwner.PreviousOwnerId = id;
      _db.Entry(previousOwner).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)

    {
      var previousOwnerToDelete = _db.PreviousOwners.FirstOrDefault(entry => entry.PreviousOwnerId == id);
      _db.PreviousOwners.Remove(previousOwnerToDelete);
      _db.SaveChanges();
    }
  }
}