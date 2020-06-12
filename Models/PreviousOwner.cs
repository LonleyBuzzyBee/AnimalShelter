using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class PreviousOwner
  {
    public PreviousOwner()
    {
      this.Animals = new HashSet<AnimalsPreviouslyOwned>();
    }
    public int PreviousOwnerId { get; set; }
    public int TimesReHomed { get; set; }
    public virtual ICollection<AnimalsPreviouslyOwned> Animals{ get; }
  }
}