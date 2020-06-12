using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Cat>()
              .HasData(
                  new Cat 
                  { 

                    CatId = 1, 
                    Name = "Muffin", 
                    Age = 19, 
                    PicUrl = "https://www.pethealthnetwork.com/sites/default/files/maine-coon-cat-484757920.jpg",
                    Gender = "Female",
                    Bio = "Chase imaginary bugs scratch. Always hungry have secret plans but spit up on light gray carpet instead of adjacent linoleum yet play riveting piece on synthesizer keyboard cats are fats i like to pets them they like to meow back for cough furball into food bowl then scratch owner for a new one. It's 3am, time to create some chaos tickle my belly at your own peril i will pester for food when you're in the kitchen even if it's salad , grass smells good lies down cat fur is the new black fish i must find my red catnip fishy fish or chase dog then run away. I like big cats and i can not lie."
                      
                  },

                   new Cat 
                  { 

                    CatId = 2, 
                    Name = "Fran", 
                    Age = 4, 
                    PicUrl = "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/other/cat_relaxing_on_patio_other/1800x1200_cat_relaxing_on_patio_other.jpg?resize=750px:*",
                    Gender = "Female",
                    Bio = "Lay on arms while you're using the keyboard hiss at vacuum cleaner lies down but mark territory mewl for food at 4am. Shake treat bag vommit food and eat it again. Hide at bottom of staircase to trip human groom forever,"

                  },
                   new Cat 
                  {

                    CatId = 3, 
                    Name = "Mac", 
                    Age = 1, 
                    PicUrl = "https://www.aspcapetinsurance.com/media/2293/siamese-cat-facts-_-siamese-cat-lying-on-an-ottoman.jpg",
                    Gender = "Male",
                    Bio = "Love me! lick arm hair and leave hair everywhere, and furrier and even more furrier hairball. Murder hooman toes see owner, run in terror. Make plans to dominate world and then take a nap brown cats with pink ears so catching very fast laser pointer. Sugar, my siamese, stalks me (in a good way), day and night walk on car leaving trail of paw prints on hood and windshield, for found somthing move i bite it tail." 

                  },
                   new Cat 
                  {

                    CatId = 4, 
                    Name = "Dude", 
                    Age = 1, 
                    PicUrl = "https://jimiamy.com/wp-content/uploads/2019/09/d254ec3ab776e4345aaef1ced0379e23.jpg",
                    Gender = "Male",
                    Bio = "i haven't decided whether or not i wanna go out my slave human didn't give me any food so i pooped on the floor for kitten is playing with dead mouse. Fall asleep on the washing machine. Eat all the power cords found somthing move i bite it tail, munch on tasty moths. Bring your owner a dead bird small kitty warm kitty little balls of fur step on your keyboard while you're gaming and then turn in a circle , but inspect anything brought into the house, or sit on the laptop and always hungry oooo!" 

                  }
          
              );
        }
        public DbSet<Cat> Cats { get; set; }
    }
}