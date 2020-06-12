﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20200612215257_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Bio");

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("PicUrl");

                    b.Property<string>("Species");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 19,
                            Bio = "Chase imaginary bugs scratch. Always hungry have secret plans but spit up on light gray carpet instead of adjacent linoleum yet play riveting piece on synthesizer keyboard cats are fats i like to pets them they like to meow back for cough furball into food bowl then scratch owner for a new one. It's 3am, time to create some chaos tickle my belly at your own peril i will pester for food when you're in the kitchen even if it's salad , grass smells good lies down cat fur is the new black fish i must find my red catnip fishy fish or chase dog then run away. I like big cats and i can not lie.",
                            Gender = "Female",
                            Name = "Muffin",
                            PicUrl = "https://www.pethealthnetwork.com/sites/default/files/maine-coon-cat-484757920.jpg",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 4,
                            Bio = "Lay on arms while you're using the keyboard hiss at vacuum cleaner lies down but mark territory mewl for food at 4am. Shake treat bag vommit food and eat it again. Hide at bottom of staircase to trip human groom forever,",
                            Gender = "Female",
                            Name = "Fran",
                            PicUrl = "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/other/cat_relaxing_on_patio_other/1800x1200_cat_relaxing_on_patio_other.jpg?resize=750px:*",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 1,
                            Bio = "Love me! lick arm hair and leave hair everywhere, and furrier and even more furrier hairball. Murder hooman toes see owner, run in terror. Make plans to dominate world and then take a nap brown cats with pink ears so catching very fast laser pointer. Sugar, my siamese, stalks me (in a good way), day and night walk on car leaving trail of paw prints on hood and windshield, for found somthing move i bite it tail.",
                            Gender = "Male",
                            Name = "Mac",
                            PicUrl = "https://www.aspcapetinsurance.com/media/2293/siamese-cat-facts-_-siamese-cat-lying-on-an-ottoman.jpg",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 1,
                            Bio = "i haven't decided whether or not i wanna go out my slave human didn't give me any food so i pooped on the floor for kitten is playing with dead mouse. Fall asleep on the washing machine. Eat all the power cords found somthing move i bite it tail, munch on tasty moths. Bring your owner a dead bird small kitty warm kitty little balls of fur step on your keyboard while you're gaming and then turn in a circle , but inspect anything brought into the house, or sit on the laptop and always hungry oooo!",
                            Gender = "Male",
                            Name = "Dude",
                            PicUrl = "https://jimiamy.com/wp-content/uploads/2019/09/d254ec3ab776e4345aaef1ced0379e23.jpg",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 1,
                            Bio = "Very long kitty. Very confused kitty.",
                            Gender = "Female",
                            Name = "Longo",
                            PicUrl = "https://ca-times.brightspotcdn.com/dims4/default/3647d8a/2147483647/strip/true/crop/750x422+0+0/resize/840x473!/quality/90/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2F2b%2Fde%2Fc0a5bdd342bb4c7ade7fc93631d8%2Fsd-1506624972-gyqlu5aun9-snap-image",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 11,
                            Bio = "smol borking doggo with a long snoot for pats dat tungg tho, puggorino. Pats heckin angery woofer long woofer such treat, woofer ur givin me a spook.  Yapper many pats long doggo wow such tempt shoober, long doggo clouds. Lotsa pats puggorino blep big ol pupper dat tungg tho, very good spot heck.",
                            Gender = "Male",
                            Name = "Bagera",
                            PicUrl = "https://i.pinimg.com/originals/0c/dc/6b/0cdc6b9ea47cdee8ff88c1d6c9e02ca7.jpg",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 7,
                            Age = 3,
                            Bio = "Shibe doggorino. You are doing me the shock you are doing me a frighten long woofer wow very biscit most angery pupper I have ever seen, h*ck waggy wags pupperino waggy wags wrinkler, shooberino what a nice floof aqua doggo.",
                            Gender = "Male",
                            Name = "Norman",
                            PicUrl = "https://www.washingtonian.com/wp-content/uploads/2018/10/marcus-wallis-471438-unsplash-2048x1536.jpg",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 8,
                            Age = 10,
                            Bio = "Many pats long water shoob pupper wrinkler very hand that feed shibe doggorino, big ol pupper stop it fren sub woofer lotsa pats. Wow very biscit h*ck tungg long water shoob waggy wags heckin good boys, heck yapper aqua doggo adorable doggo, snoot you are doin me a concern blop corgo. You are doing me a frighten smol smol borking doggo with a long snoot for pats dat tungg tho, very jealous pupper such treat.",
                            Gender = "Male",
                            Name = "Moguly",
                            PicUrl = "https://thehappypuppysite.com/wp-content/uploads/2018/12/fat-dachshund-long.jpg",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 9,
                            Age = 2,
                            Bio = "I have ever seen doing me a frighten, smol. Fluffer the neighborhood pupper vvv borking doggo shibe wow such tempt, sub woofer he made many woofs dat tungg tho.",
                            Gender = "Female",
                            Name = "Sweety",
                            PicUrl = "https://www.sciencemag.org/sites/default/files/styles/article_main_large/public/pearl_16x9.jpg?itok=jZ8iPy1q",
                            Species = "Dog"
                        });
                });

            modelBuilder.Entity("AnimalShelter.Models.AnimalsPreviouslyOwned", b =>
                {
                    b.Property<int>("AnimalsPreviouslyOwnedId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnimalId");

                    b.Property<int>("PreviousOwnerId");

                    b.HasKey("AnimalsPreviouslyOwnedId");

                    b.HasIndex("AnimalId");

                    b.HasIndex("PreviousOwnerId");

                    b.ToTable("AnimalsPreviousOwned");

                    b.HasData(
                        new
                        {
                            AnimalsPreviouslyOwnedId = 1,
                            AnimalId = 1,
                            PreviousOwnerId = 1
                        },
                        new
                        {
                            AnimalsPreviouslyOwnedId = 2,
                            AnimalId = 9,
                            PreviousOwnerId = 2
                        });
                });

            modelBuilder.Entity("AnimalShelter.Models.PreviousOwner", b =>
                {
                    b.Property<int>("PreviousOwnerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("TimesReHomed");

                    b.HasKey("PreviousOwnerId");

                    b.ToTable("PreviousOwners");

                    b.HasData(
                        new
                        {
                            PreviousOwnerId = 1,
                            TimesReHomed = 0
                        },
                        new
                        {
                            PreviousOwnerId = 2,
                            TimesReHomed = 1
                        });
                });

            modelBuilder.Entity("AnimalShelter.Models.AnimalsPreviouslyOwned", b =>
                {
                    b.HasOne("AnimalShelter.Models.Animal", "Animal")
                        .WithMany("PreviousOwner")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AnimalShelter.Models.PreviousOwner", "PreviousOwner")
                        .WithMany("Animals")
                        .HasForeignKey("PreviousOwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}