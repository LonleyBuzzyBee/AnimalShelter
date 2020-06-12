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
  public class CatController : ControllerBase
  {
    private AnimalShelterContext _db;

    public CatController(AnimalShelterContext db)
    {
      _db = db;
    }

    // GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<Cat>> Get(string gender, string name, int age, bool picUrl, string bio, int? page)
    {
      var query = _db.Cats.AsQueryable();
      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (age != 0)
      {
        query = query.Where(entry => entry.Age == age);
      }
      if (picUrl)
      {
        query = query.Where(entry => entry.PicUrl != null);
        query = query.Where(entry => entry.PicUrl != "");
      }
      if (bio != null)
      {
        query = query.Where(entry => entry.Bio == bio);
      }
      int pageSize = 5;
      int pageNumber = (page ?? 1);

      return query.ToPagedList(pageNumber,pageSize).ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Cat> Get(int id)
    {
      return _db.Cats.FirstOrDefault(entry => entry.CatId == id);
    }

    // POST api/animals
    [HttpPost]
    public void Post([FromBody] Cat cat)
    {
      _db.Cats.Add(cat);
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Cat cat)

    {
      cat.CatId = id;
      _db.Entry(cat).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)

    {
      var catToDelete = _db.Cats.FirstOrDefault(entry => entry.CatId == id);
      _db.Cats.Remove(catToDelete);
      _db.SaveChanges();
    }
  }
}