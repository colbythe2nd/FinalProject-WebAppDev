﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MvcCoreApplication.Models
{
    internal class ReviewsConfig : IEntityTypeConfiguration<Reviews>
    {
        public void Configure(EntityTypeBuilder<Reviews> entity)
        {
            entity.HasData(
               new { Id = 1, MovieName = "Kungfu Panda", Rating = "8.5/10", Comments = " A CG-animated comedy about a lazy, irreverent slacker panda, Po, who must somehow become a Kung Fu Master in order to save the Valley of Peace from a villainous snow leopard, Tai Lung. Set in the legendary world of ancient China, this is the story of Po, our unlikely hero, who enters the rigid world of Kung Fu and turning it upside down. Po ultimately becomes a Kung Fu hero by learning that if he believes in himself, he can do anything" },
               new { Id = 2, MovieName = "Cars", Rating = "7.5/10", Comments = "On his way to the biggest race of his life, Lightning McQueen is disconnected from his truck hauler, Mack, and winds up in Radiator Springs, a small town in Carburetor County on Route 66. McQueen damages the road and has to repair it watched by the Sheriff or Mater. As McQueen fixes it, he meets a rusty old tow truck, a pretty Porsche, a grumpy old Hudson Hornet, a Ferrari-loving Fiat, and many more nice folks. But will McQueen be able to finish the road in time for the final race of the Dinoco 400?" },
               new { Id = 3, MovieName = "Mulan", Rating = "7.8/10", Comments = "Fearful that her ailing father will be drafted into the Chinese military, Mulan (Ming-Na Wen) takes his spot -- though, as a girl living under a patriarchal regime, she is technically unqualified to serve. She cleverly impersonates a man and goes off to train with fellow recruits. Accompanied by her dragon, Mushu (Eddie Murphy), she uses her smarts to help ward off a Hun invasion, falling in love with a dashing captain along the way." },
               new { Id = 4, MovieName = "Shrek", Rating = "8/10", Comments = " Once upon a time, in a far away swamp, there lived an ogre named Shrek (Mike Myers) whose precious solitude is suddenly shattered by an invasion of annoying fairy tale characters. They were all banished from their kingdom by the evil Lord Farquaad (John Lithgow). Determined to save their home -- not to mention his -- Shrek cuts a deal with Farquaad and sets out to rescue Princess Fiona (Cameron Diaz) to be Farquaad's bride. Rescuing the Princess may be small compared to her deep, dark secret." },
               new { Id = 5, MovieName = "Shrek 2", Rating = "8.3/10", Comments = "After returning from their honeymoon and showing home movies to their friends, Shrek and Fiona learn that her parents have heard that she has married her true love and wish to invite him to their kingdom, called Far Far Away. The catch is: Fiona's parents are unaware of the curse that struck their daughter and have assumed she married Prince Charming, not a 700-pound ogre with horrible hygiene and a talking donkey pal." },
               new { Id = 6, MovieName = "Up", Rating = "7.6/10", Comments = "Carl Fredricksen, a 78-year-old balloon salesman, is about to fulfill a lifelong dream. Tying thousands of balloons to his house, he flies away to the South American wilderness. But curmudgeonly Carl's worst nightmare comes true when he discovers a little boy named Russell is a stowaway aboard the balloon-powered house. A Pixar animation." },
               new { Id = 7, MovieName = "Toy Story", Rating = "7.7/10", Comments = "Woody (Tom Hanks), a good-hearted cowboy doll who belongs to a young boy named Andy (John Morris), sees his position as Andy's favorite toy jeopardized when his parents buy him a Buzz Lightyear (Tim Allen) action figure. Even worse, the arrogant Buzz thinks he's a real spaceman on a mission to return to his home planet. When Andy's family moves to a new house, Woody and Buzz must escape the clutches of maladjusted neighbor Sid Phillips (Erik von Detten) and reunite with their boy." },
               new { Id = 8, MovieName = "Finding Nemo", Rating = "7.2/10", Comments = "Marlin (Albert Brooks), a clown fish, is overly cautious with his son, Nemo (Alexander Gould), who has a foreshortened fin. When Nemo swims too close to the surface to prove himself, he is caught by a diver, and horrified Marlin must set out to find him. A blue reef fish named Dory (Ellen DeGeneres) -- who has a really short memory -- joins Marlin and complicates the encounters with sharks, jellyfish, and a host of ocean dangers. Meanwhile, Nemo plots his escape from a dentist's fish tank." }
            );
        }
    }

}