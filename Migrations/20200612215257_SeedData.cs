using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    PicUrl = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: false),
                    Species = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.CreateTable(
                name: "PreviousOwners",
                columns: table => new
                {
                    PreviousOwnerId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TimesReHomed = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreviousOwners", x => x.PreviousOwnerId);
                });

            migrationBuilder.CreateTable(
                name: "AnimalsPreviousOwned",
                columns: table => new
                {
                    AnimalsPreviouslyOwnedId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AnimalId = table.Column<int>(nullable: false),
                    PreviousOwnerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalsPreviousOwned", x => x.AnimalsPreviouslyOwnedId);
                    table.ForeignKey(
                        name: "FK_AnimalsPreviousOwned_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "AnimalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalsPreviousOwned_PreviousOwners_PreviousOwnerId",
                        column: x => x.PreviousOwnerId,
                        principalTable: "PreviousOwners",
                        principalColumn: "PreviousOwnerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Bio", "Gender", "Name", "PicUrl", "Species" },
                values: new object[,]
                {
                    { 1, 19, "Chase imaginary bugs scratch. Always hungry have secret plans but spit up on light gray carpet instead of adjacent linoleum yet play riveting piece on synthesizer keyboard cats are fats i like to pets them they like to meow back for cough furball into food bowl then scratch owner for a new one. It's 3am, time to create some chaos tickle my belly at your own peril i will pester for food when you're in the kitchen even if it's salad , grass smells good lies down cat fur is the new black fish i must find my red catnip fishy fish or chase dog then run away. I like big cats and i can not lie.", "Female", "Muffin", "https://www.pethealthnetwork.com/sites/default/files/maine-coon-cat-484757920.jpg", "Cat" },
                    { 2, 4, "Lay on arms while you're using the keyboard hiss at vacuum cleaner lies down but mark territory mewl for food at 4am. Shake treat bag vommit food and eat it again. Hide at bottom of staircase to trip human groom forever,", "Female", "Fran", "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/other/cat_relaxing_on_patio_other/1800x1200_cat_relaxing_on_patio_other.jpg?resize=750px:*", "Cat" },
                    { 3, 1, "Love me! lick arm hair and leave hair everywhere, and furrier and even more furrier hairball. Murder hooman toes see owner, run in terror. Make plans to dominate world and then take a nap brown cats with pink ears so catching very fast laser pointer. Sugar, my siamese, stalks me (in a good way), day and night walk on car leaving trail of paw prints on hood and windshield, for found somthing move i bite it tail.", "Male", "Mac", "https://www.aspcapetinsurance.com/media/2293/siamese-cat-facts-_-siamese-cat-lying-on-an-ottoman.jpg", "Cat" },
                    { 4, 1, "i haven't decided whether or not i wanna go out my slave human didn't give me any food so i pooped on the floor for kitten is playing with dead mouse. Fall asleep on the washing machine. Eat all the power cords found somthing move i bite it tail, munch on tasty moths. Bring your owner a dead bird small kitty warm kitty little balls of fur step on your keyboard while you're gaming and then turn in a circle , but inspect anything brought into the house, or sit on the laptop and always hungry oooo!", "Male", "Dude", "https://jimiamy.com/wp-content/uploads/2019/09/d254ec3ab776e4345aaef1ced0379e23.jpg", "Cat" },
                    { 5, 1, "Very long kitty. Very confused kitty.", "Female", "Longo", "https://ca-times.brightspotcdn.com/dims4/default/3647d8a/2147483647/strip/true/crop/750x422+0+0/resize/840x473!/quality/90/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2F2b%2Fde%2Fc0a5bdd342bb4c7ade7fc93631d8%2Fsd-1506624972-gyqlu5aun9-snap-image", "Cat" },
                    { 6, 11, "smol borking doggo with a long snoot for pats dat tungg tho, puggorino. Pats heckin angery woofer long woofer such treat, woofer ur givin me a spook.  Yapper many pats long doggo wow such tempt shoober, long doggo clouds. Lotsa pats puggorino blep big ol pupper dat tungg tho, very good spot heck.", "Male", "Bagera", "https://i.pinimg.com/originals/0c/dc/6b/0cdc6b9ea47cdee8ff88c1d6c9e02ca7.jpg", "Dog" },
                    { 7, 3, "Shibe doggorino. You are doing me the shock you are doing me a frighten long woofer wow very biscit most angery pupper I have ever seen, h*ck waggy wags pupperino waggy wags wrinkler, shooberino what a nice floof aqua doggo.", "Male", "Norman", "https://www.washingtonian.com/wp-content/uploads/2018/10/marcus-wallis-471438-unsplash-2048x1536.jpg", "Dog" },
                    { 8, 10, "Many pats long water shoob pupper wrinkler very hand that feed shibe doggorino, big ol pupper stop it fren sub woofer lotsa pats. Wow very biscit h*ck tungg long water shoob waggy wags heckin good boys, heck yapper aqua doggo adorable doggo, snoot you are doin me a concern blop corgo. You are doing me a frighten smol smol borking doggo with a long snoot for pats dat tungg tho, very jealous pupper such treat.", "Male", "Moguly", "https://thehappypuppysite.com/wp-content/uploads/2018/12/fat-dachshund-long.jpg", "Dog" },
                    { 9, 2, "I have ever seen doing me a frighten, smol. Fluffer the neighborhood pupper vvv borking doggo shibe wow such tempt, sub woofer he made many woofs dat tungg tho.", "Female", "Sweety", "https://www.sciencemag.org/sites/default/files/styles/article_main_large/public/pearl_16x9.jpg?itok=jZ8iPy1q", "Dog" }
                });

            migrationBuilder.InsertData(
                table: "PreviousOwners",
                columns: new[] { "PreviousOwnerId", "TimesReHomed" },
                values: new object[,]
                {
                    { 1, 0 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "AnimalsPreviousOwned",
                columns: new[] { "AnimalsPreviouslyOwnedId", "AnimalId", "PreviousOwnerId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "AnimalsPreviousOwned",
                columns: new[] { "AnimalsPreviouslyOwnedId", "AnimalId", "PreviousOwnerId" },
                values: new object[] { 2, 9, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalsPreviousOwned_AnimalId",
                table: "AnimalsPreviousOwned",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalsPreviousOwned_PreviousOwnerId",
                table: "AnimalsPreviousOwned",
                column: "PreviousOwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalsPreviousOwned");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "PreviousOwners");
        }
    }
}
