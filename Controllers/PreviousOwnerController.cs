// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using AnimalShelter.Models;
// using PagedList;

// namespace AnimalShelter.Controller
// {
//   [Route("api/[controller]")]
//   [ApiController]
//   public class PreviousOwnerController : ControllerBase
//   {
//     private AnimalShelterContext _db;

//     public PreviousOwnerController(AnimalShelterContext db)
//     {
//       _db = db;
//     }

//     // GET api/animals
//     [HttpGet]
//     public ActionResult<IEnumerable<PreviousOwner>> Get(string lastOwner, int timesReHomed)
//     {
//       var query = _db.PreviousOwners.AsQueryable();
//       if (lastOwner != null)
//       {
//         query = query.Where(entry => entry.LastOwner == lastOwner);
//       }
//       if (species != null)
//       {
//         query = query.Where(entry => entry.Species == species);
//       }
//       int pageSize = 5;
//       int pageNumber = (page ?? 1);

//       return query.ToPagedList(pageNumber,pageSize).ToList();
//     }

//     [HttpGet("{id}")]
//     public ActionResult<Animal> Get(int id)
//     {
//       return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
//     }

//     // POST api/animals
//     [HttpPost]
//     public void Post([FromBody] Animal animal)
//     {
//       _db.Animals.Add(animal);
//       _db.SaveChanges();
//     }

//     [HttpPut("{id}")]
//     public void Put(int id, [FromBody] Animal animal)

//     {
//       animal.AnimalId = id;
//       _db.Entry(animal).State = EntityState.Modified;
//       _db.SaveChanges();
//     }

//     [HttpDelete("{id}")]
//     public void Delete(int id)

//     {
//       var animalToDelete = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
//       _db.Animals.Remove(animalToDelete);
//       _db.SaveChanges();
//     }
//   }
// }