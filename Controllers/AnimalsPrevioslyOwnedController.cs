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
  public class AnimalsPrevioslyOwnedController : ControllerBase
  {
    private AnimalShelterContext _db;

    public AnimalsPrevioslyOwnedController(AnimalShelterContext db)
    {
      _db = db;
    }

    // GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<AnimalsPreviouslyOwned>> Get(int animalId,int previousOwnerId, int? page)
    {
      var query = _db.AnimalsPreviouslyOwned.AsQueryable();
      if (animalId != 0)
      {
        query = query.Where(entry => entry.AnimalId == animalId);
      }
      if (previousOwnerId != 0)
      {
        query = query.Where(entry => entry.PreviousOwnerId == previousOwnerId);
      }
   
      int pageSize = 5;
      int pageNumber = (page ?? 1);

      return query.ToPagedList(pageNumber,pageSize).ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<AnimalsPreviouslyOwned> Get(int id)
    {
      return _db.AnimalsPreviouslyOwned.FirstOrDefault(entry => entry.AnimalsPreviouslyOwnedId == id);
    }

    // POST api/animals
    [HttpPost]
    public void Post([FromBody] AnimalsPreviouslyOwned animalsPreviouslyOwned)
    {
      _db.AnimalsPreviouslyOwned.Add(animalsPreviouslyOwned);
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] AnimalsPreviouslyOwned animalsPreviouslyOwned)

    {
      animalsPreviouslyOwned.AnimalsPreviouslyOwnedId = id;
      _db.Entry(animalsPreviouslyOwned).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)

    {
      var animalsPreviouslyOwnedToDelete = _db.AnimalsPreviouslyOwned.FirstOrDefault(entry => entry.AnimalsPreviouslyOwnedId == id);
      _db.AnimalsPreviouslyOwned.Remove(animalsPreviouslyOwnedToDelete);
      _db.SaveChanges();
    }
  }
}