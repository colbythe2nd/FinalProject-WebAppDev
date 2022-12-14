using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comments", "MovieName", "Rating" },
                values: new object[,]
                {
                    { 1, " A CG-animated comedy about a lazy, irreverent slacker panda, Po, who must somehow become a Kung Fu Master in order to save the Valley of Peace from a villainous snow leopard, Tai Lung. Set in the legendary world of ancient China, this is the story of Po, our unlikely hero, who enters the rigid world of Kung Fu and turning it upside down. Po ultimately becomes a Kung Fu hero by learning that if he believes in himself, he can do anything", "Kungfu Panda", "8.5/10" },
                    { 2, "On his way to the biggest race of his life, Lightning McQueen is disconnected from his truck hauler, Mack, and winds up in Radiator Springs, a small town in Carburetor County on Route 66. McQueen damages the road and has to repair it watched by the Sheriff or Mater. As McQueen fixes it, he meets a rusty old tow truck, a pretty Porsche, a grumpy old Hudson Hornet, a Ferrari-loving Fiat, and many more nice folks. But will McQueen be able to finish the road in time for the final race of the Dinoco 400?", "Cars", "7.5/10" },
                    { 3, "Fearful that her ailing father will be drafted into the Chinese military, Mulan (Ming-Na Wen) takes his spot -- though, as a girl living under a patriarchal regime, she is technically unqualified to serve. She cleverly impersonates a man and goes off to train with fellow recruits. Accompanied by her dragon, Mushu (Eddie Murphy), she uses her smarts to help ward off a Hun invasion, falling in love with a dashing captain along the way.", "Mulan", "7.8/10" },
                    { 4, " Once upon a time, in a far away swamp, there lived an ogre named Shrek (Mike Myers) whose precious solitude is suddenly shattered by an invasion of annoying fairy tale characters. They were all banished from their kingdom by the evil Lord Farquaad (John Lithgow). Determined to save their home -- not to mention his -- Shrek cuts a deal with Farquaad and sets out to rescue Princess Fiona (Cameron Diaz) to be Farquaad's bride. Rescuing the Princess may be small compared to her deep, dark secret.", "Shrek", "8/10" },
                    { 5, "After returning from their honeymoon and showing home movies to their friends, Shrek and Fiona learn that her parents have heard that she has married her true love and wish to invite him to their kingdom, called Far Far Away. The catch is: Fiona's parents are unaware of the curse that struck their daughter and have assumed she married Prince Charming, not a 700-pound ogre with horrible hygiene and a talking donkey pal.", "Shrek 2", "8.3/10" },
                    { 6, "Carl Fredricksen, a 78-year-old balloon salesman, is about to fulfill a lifelong dream. Tying thousands of balloons to his house, he flies away to the South American wilderness. But curmudgeonly Carl's worst nightmare comes true when he discovers a little boy named Russell is a stowaway aboard the balloon-powered house. A Pixar animation.", "Up", "7.6/10" },
                    { 7, "Woody (Tom Hanks), a good-hearted cowboy doll who belongs to a young boy named Andy (John Morris), sees his position as Andy's favorite toy jeopardized when his parents buy him a Buzz Lightyear (Tim Allen) action figure. Even worse, the arrogant Buzz thinks he's a real spaceman on a mission to return to his home planet. When Andy's family moves to a new house, Woody and Buzz must escape the clutches of maladjusted neighbor Sid Phillips (Erik von Detten) and reunite with their boy.", "Toy Story", "7.7/10" },
                    { 8, "Marlin (Albert Brooks), a clown fish, is overly cautious with his son, Nemo (Alexander Gould), who has a foreshortened fin. When Nemo swims too close to the surface to prove himself, he is caught by a diver, and horrified Marlin must set out to find him. A blue reef fish named Dory (Ellen DeGeneres) -- who has a really short memory -- joins Marlin and complicates the encounters with sharks, jellyfish, and a host of ocean dangers. Meanwhile, Nemo plots his escape from a dentist's fish tank.", "Finding Nemo", "7.2/10" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
