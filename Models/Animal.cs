using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public Animal()
    {
      this.PreviousOwner = new HashSet<AnimalsPreviouslyOwned>();
    }
    public int AnimalId { get; set; }
    [Required]
    [StringLength(20, ErrorMessage = "Sorry this cats name can't be more than 20 characters")]
    public string Name { get; set; }
    [Required]
    [Range(1, 30, ErrorMessage = "Age must be between 0 and 30")]
    public int Age { get; set; }
    public string PicUrl { get; set; }
    [Required]
    public string Gender { get; set; }
    public string Species { get; set; }
    public string Bio { get; set; }
    public virtual ICollection<AnimalsPreviouslyOwned> PreviousOwner { get; }
  }
}