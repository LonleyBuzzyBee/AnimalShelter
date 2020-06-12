using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Cat
  {
    public int CatId { get; set; }
    [Required]
    [StringLength(20, ErrorMessage = "Sorry this cats name can't be more than 20 characters")]
    public string Name { get; set; }
    [Required]
    [Range(1, 30, ErrorMessage = "Age must be between 0 and 30")]
    public int Age { get; set; }
    public string PicUrl { get; set; }
    [Required]
    public string Gender { get; set; }
    public string Bio { get; set; }
  }
}