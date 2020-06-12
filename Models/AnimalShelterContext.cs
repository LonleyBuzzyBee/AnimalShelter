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
      builder.Entity<Animal>()
          .HasData(
              new Animal
              {

                AnimalId = 1,
                Name = "Muffin",
                Age = 19,
                PicUrl = "https://www.pethealthnetwork.com/sites/default/files/maine-coon-cat-484757920.jpg",
                Gender = "Female",
                Species = "Cat",
                Bio = "Chase imaginary bugs scratch. Always hungry have secret plans but spit up on light gray carpet instead of adjacent linoleum yet play riveting piece on synthesizer keyboard cats are fats i like to pets them they like to meow back for cough furball into food bowl then scratch owner for a new one. It's 3am, time to create some chaos tickle my belly at your own peril i will pester for food when you're in the kitchen even if it's salad , grass smells good lies down cat fur is the new black fish i must find my red catnip fishy fish or chase dog then run away. I like big cats and i can not lie."

              },

               new Animal
               {

                 AnimalId = 2,
                 Name = "Fran",
                 Age = 4,
                 PicUrl = "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/other/cat_relaxing_on_patio_other/1800x1200_cat_relaxing_on_patio_other.jpg?resize=750px:*",
                 Gender = "Female",
                 Species = "Cat",
                 Bio = "Lay on arms while you're using the keyboard hiss at vacuum cleaner lies down but mark territory mewl for food at 4am. Shake treat bag vommit food and eat it again. Hide at bottom of staircase to trip human groom forever,"

               },
               new Animal
               {

                 AnimalId = 3,
                 Name = "Mac",
                 Age = 1,
                 PicUrl = "https://www.aspcapetinsurance.com/media/2293/siamese-cat-facts-_-siamese-cat-lying-on-an-ottoman.jpg",
                 Gender = "Male",
                 Species = "Cat",
                 Bio = "Love me! lick arm hair and leave hair everywhere, and furrier and even more furrier hairball. Murder hooman toes see owner, run in terror. Make plans to dominate world and then take a nap brown cats with pink ears so catching very fast laser pointer. Sugar, my siamese, stalks me (in a good way), day and night walk on car leaving trail of paw prints on hood and windshield, for found somthing move i bite it tail."

               },
               new Animal
               {
                 AnimalId = 4,
                 Name = "Dude",
                 Age = 1,
                 PicUrl = "https://jimiamy.com/wp-content/uploads/2019/09/d254ec3ab776e4345aaef1ced0379e23.jpg",
                 Gender = "Male",
                 Species = "Cat",
                 Bio = "i haven't decided whether or not i wanna go out my slave human didn't give me any food so i pooped on the floor for kitten is playing with dead mouse. Fall asleep on the washing machine. Eat all the power cords found somthing move i bite it tail, munch on tasty moths. Bring your owner a dead bird small kitty warm kitty little balls of fur step on your keyboard while you're gaming and then turn in a circle , but inspect anything brought into the house, or sit on the laptop and always hungry oooo!"
               },
               new Animal
               {
                 AnimalId = 5,
                 Name = "Longo",
                 Age = 1,
                 PicUrl = "https://ca-times.brightspotcdn.com/dims4/default/3647d8a/2147483647/strip/true/crop/750x422+0+0/resize/840x473!/quality/90/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2F2b%2Fde%2Fc0a5bdd342bb4c7ade7fc93631d8%2Fsd-1506624972-gyqlu5aun9-snap-image",
                 Gender = "Female",
                 Species = "Cat",
                 Bio = "Very long kitty. Very confused kitty."
               },
               new Animal
               {
                 AnimalId = 6,
                 Name = "Bagera",
                 Age = 11,
                 PicUrl = "https://i.pinimg.com/originals/0c/dc/6b/0cdc6b9ea47cdee8ff88c1d6c9e02ca7.jpg",
                 Gender = "Male",
                 Species = "Dog",
                 Bio = "smol borking doggo with a long snoot for pats dat tungg tho, puggorino. Pats heckin angery woofer long woofer such treat, woofer ur givin me a spook.  Yapper many pats long doggo wow such tempt shoober, long doggo clouds. Lotsa pats puggorino blep big ol pupper dat tungg tho, very good spot heck."
               },
               new Animal
               {
                 AnimalId = 7,
                 Name = "Norman",
                 Age = 3,
                 PicUrl = "https://www.washingtonian.com/wp-content/uploads/2018/10/marcus-wallis-471438-unsplash-2048x1536.jpg",
                 Gender = "Male",
                 Species = "Dog",
                 Bio = "Shibe doggorino. You are doing me the shock you are doing me a frighten long woofer wow very biscit most angery pupper I have ever seen, h*ck waggy wags pupperino waggy wags wrinkler, shooberino what a nice floof aqua doggo."

               },
               new Animal
               {
                 AnimalId = 8,
                 Name = "Moguly",
                 Age = 10,
                 PicUrl = "https://thehappypuppysite.com/wp-content/uploads/2018/12/fat-dachshund-long.jpg",
                 Gender = "Male",
                 Species = "Dog",
                 Bio = "Many pats long water shoob pupper wrinkler very hand that feed shibe doggorino, big ol pupper stop it fren sub woofer lotsa pats. Wow very biscit h*ck tungg long water shoob waggy wags heckin good boys, heck yapper aqua doggo adorable doggo, snoot you are doin me a concern blop corgo. You are doing me a frighten smol smol borking doggo with a long snoot for pats dat tungg tho, very jealous pupper such treat."

               },
               new Animal
               {
                 AnimalId = 9,
                 Name = "Sweety",
                 Age = 2,
                 PicUrl = "https://www.sciencemag.org/sites/default/files/styles/article_main_large/public/pearl_16x9.jpg?itok=jZ8iPy1q",
                 Gender = "Female",
                 Species = "Dog",
                 Bio = "I have ever seen doing me a frighten, smol. Fluffer the neighborhood pupper vvv borking doggo shibe wow such tempt, sub woofer he made many woofs dat tungg tho."
                }
          
              );
        }
        public DbSet<Animal> Animals { get; set; }
    }
}