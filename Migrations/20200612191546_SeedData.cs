using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    CatId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    PicUrl = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: false),
                    Bio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.CatId);
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Age", "Bio", "Gender", "Name", "PicUrl" },
                values: new object[,]
                {
                    { 1, 19, "Chase imaginary bugs scratch. Always hungry have secret plans but spit up on light gray carpet instead of adjacent linoleum yet play riveting piece on synthesizer keyboard cats are fats i like to pets them they like to meow back for cough furball into food bowl then scratch owner for a new one. It's 3am, time to create some chaos tickle my belly at your own peril i will pester for food when you're in the kitchen even if it's salad , grass smells good lies down cat fur is the new black fish i must find my red catnip fishy fish or chase dog then run away. I like big cats and i can not lie.", "Female", "Muffin", "https://www.pethealthnetwork.com/sites/default/files/maine-coon-cat-484757920.jpg" },
                    { 2, 4, "Lay on arms while you're using the keyboard hiss at vacuum cleaner lies down but mark territory mewl for food at 4am. Shake treat bag vommit food and eat it again. Hide at bottom of staircase to trip human groom forever,", "Female", "Fran", "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/other/cat_relaxing_on_patio_other/1800x1200_cat_relaxing_on_patio_other.jpg?resize=750px:*" },
                    { 3, 1, "Love me! lick arm hair and leave hair everywhere, and furrier and even more furrier hairball. Murder hooman toes see owner, run in terror. Make plans to dominate world and then take a nap brown cats with pink ears so catching very fast laser pointer. Sugar, my siamese, stalks me (in a good way), day and night walk on car leaving trail of paw prints on hood and windshield, for found somthing move i bite it tail.", "Male", "Mac", "https://www.aspcapetinsurance.com/media/2293/siamese-cat-facts-_-siamese-cat-lying-on-an-ottoman.jpg" },
                    { 4, 1, "i haven't decided whether or not i wanna go out my slave human didn't give me any food so i pooped on the floor for kitten is playing with dead mouse. Fall asleep on the washing machine. Eat all the power cords found somthing move i bite it tail, munch on tasty moths. Bring your owner a dead bird small kitty warm kitty little balls of fur step on your keyboard while you're gaming and then turn in a circle , but inspect anything brought into the house, or sit on the laptop and always hungry oooo!", "Male", "Dude", "https://jimiamy.com/wp-content/uploads/2019/09/d254ec3ab776e4345aaef1ced0379e23.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");
        }
    }
}
