
using System.Collections.Generic;

namespace AnimalShelter.Models

{
  public class AnimalsPreviouslyOwned
  {
    public int AnimalsPreviouslyOwnedId { get; set; }
    public int AnimalId { get; set; }
    public int PreviousOwnerId { get; set; }

    public Animal Animal { get; set; }
    public PreviousOwner PreviousOwner { get; set; }
  }
}