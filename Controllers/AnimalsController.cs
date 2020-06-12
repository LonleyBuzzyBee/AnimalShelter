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
  public class AnimalsController : ControllerBase
  {
    private AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    // GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get(string gender,string species, string name, int age, bool picUrl, string bio, int? page)
    {
      var query = _db.Animals.AsQueryable();
      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }
      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
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
    public ActionResult<Animal> Get(int id)
    {
      return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
    }

    // POST api/animals
    [HttpPost]
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Animal animal)

    {
      animal.AnimalId = id;
      _db.Entry(animal).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)

    {
      var animalToDelete = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
      _db.Animals.Remove(animalToDelete);
      _db.SaveChanges();
    }
  }
}