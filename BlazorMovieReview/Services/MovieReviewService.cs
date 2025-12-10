using BlazorMovieReview.Models;

namespace BlazorMovieReview.Services
{
    public class MovieReviewService : IMovieReviewService
    {
        private static readonly List<MovieModel> Movies = new List<MovieModel>
        {
            new MovieModel{
                Id=1,
                Title = "Across the Spider-Verse",
                Genre= "Adventure",
                ReleaseYear= 2023,
                Description = "Traveling across the multiverse, Miles Morales meets a new team of Spider-People, made up of heroes from different dimensions. But when the heroes clash over how to deal with a new threat, Miles finds himself at a crossroads. ",
                ImageUrl = "/images/movies/atsv.jpg",
                Review = "It's honestly absurd how good the \"Spider-Verse\" movies are. \"Across the Spider-Verse\" is just as great, if not better than \"Into the Spider-Verse\". I really don't know how. \"Spider-Man: Across the Spider-Verse\" is fantastic! Deftly juggles deeply heartfelt character beats with crazy multiverse content, just packed with so many delightful easter eggs. Loved how Gwen's story is expanded, her scenes with Shea Whigham's Captain Stacy are truly special.\r\n\r\nCan't wait for the third one. Every frame of this movie is gorgeous! I didn't want to blink because I didn't want to miss anything. You can watch this film over & over & finds something new to enjoy. There are some surprises in this film that I truly wasn't expecting.\r\n\r\n\"Across the Spider-Verse\" is another milestone for animation. Yes it's gorgeous & visually mind-blowing, but this sequel surpasses the first for always putting Miles and his family front and center. The movie feels like a massive celebration for Spider-Man fans everywhere, whether you love the movies, games, comics, etc. But again, all the cameos and multiversal elements come second to both Miles and Gwen's story. Is a stunning achievement. Yes, it's visually dazzling, with expansive, expressive new realms The movie's real superpower is its emotional depth and its beautiful, melancholic tone.\r\n\r\nWhat more can I say...It's an actual work of art! Every frame deserves to be hung in a museum. The jokes and nods to Spidey lore are perfect. It's outstanding. \"Spider-Man: Across the Spider-Verse\" is yet another resounding win for the Lord Miller-produced universe. Hailee Steinfeld really comes into her own as Gwen Stacy. It's darker and sadder than I expected, but necessary."
            },
             new MovieModel{
                Id=2,
                Title = "Escape Room",
                Genre= "Horror",
                ReleaseYear= 2019,
                Description = "Six strangers find themselves in a maze of deadly mystery rooms and must use their wits to survive. ",
                ImageUrl = "/images/movies/ems.jpg",
                Review = "Six people receive a mysterious box. It contains a chance to win ten thousand dollars. As the strangers arrive in a nondescript building and wait in a reception area.\r\n\r\nThey certainly find themselves locked in a series of escape rooms with fiendish traps and small clues. However this is no game, the penalty for failure is death.\r\n\r\nEscape Room is reminiscent of the cult movie Cube. There are hints that the six people could be trapped in purgatory. We see flashbacks that they were all involved in some life threatening event where they may or could had perished.\r\n\r\nEscape Room in its own term is better than a lot of low budget horror/thrillers. It is not as gory or nasty as the Saw movies.\r\n\r\nIt is competently entertaining with a subtext regarding pleasing the elites."
            },
            new MovieModel{
                Id=3,
                Title = "Glass Onion",
                Genre= "Mystery",
                ReleaseYear= 2022,
                Description = "Tech billionaire Miles Bron invites his friends for a getaway on his private Greek island. When someone turns up dead, Detective Benoit Blanc is put on the case. ",
                ImageUrl = "/images/movies/go.jpg",
                Review = "Glass Onion further proves Rian Johnson's impressive credentials, matching it's phenomenal predecessor in it's quality delivering an equally strong sequel that tells an equally complex, funny and endlessly unpredictable narrative that's designed for multiple viewings and is easily the best film to be set during the pandemic.\r\n\r\nDaniel Craig is perfect as Benoit Blanc, bringing back that beautiful accent and all the humour whilst still reminding us that he's a truly good person. Janelle Monáe is the best out of the new cast, she shows so much range and makes for a great double act with Craig.\r\n\r\nThe rest of the cast are all really good at making their characters unlikeable and easy to laugh at but the strongest is Edward Norton whose clueless billionaire tech giant feels like a perfect and deliberate contrast to his iconic Fight Club character.\r\n\r\nRian Johnson's direction is excellent, the film surprisingly has a high amount of energy in its constant camera movements and is really good emphasising it's star power through framing. The music by Nathan Johnson is also really good, with an eccentric bombast rarely heard these days.\r\n"
            },
            new MovieModel{
                Id=4,
                Title = "Knives Out",
                Genre= "Mystery",
                ReleaseYear= 2019,
                Description = "When renowned crime novelist Harlan Thrombey is found dead at his estate just after his 85th birthday, the inquisitive and debonair Detective Benoit Blanc is mysteriously enlisted to investigate. ",
                ImageUrl = "/images/movies/ko.jpg",
                Review = "With the exception of my wife and daughter, and possibly my mother, Agatha Christie is the woman whom I love most on this planet. She truly was the most gifted and brilliant fiction writer who ever lived, and it rejoices me to see that her work still inspires other writers and filmmakers nowadays; more than forty years after she passed away. There are still many adaptations of her original work, but with Knives Out, writer/director Rian Johnson attempts something entirely different. It's abundantly clear that Johnson was inspired by all of Christie's typical trademarks and hobby-horses, and he pays tribute to her most legendary characters and favorite settings, but the plot of Knives Out is entirely new and scripted directly for the screen. A good old-fashioned murder mystery/whodunit set in the enormous mansion of a wealthy family, full of eccentric people each of whom have dirty little secrets, convoluted plot twists, continuous red herrings that practically make it impossible to guess along, and a fabulous all-knowing but slightly odd sleuth slowly unravelling the clues.Daniel Craig is downright terrific as Benoit Blanc, a private detective with a bizarre accent and weird one-liners, hired by someone anonymous to dig deeper into the strange and sudden death of patriarch Harlan Thrombey. It looks like suicide, but literally every greedy member of Harlan's bloodline had a motive for killing and - also in delightful Agatha Christie tradition - the plot even thickens after the reading of the will. It would be a shame to reveal too much about the plot, but rest assured that is refreshing and inventive, compelling as well as humorous, complex but simultaneously light-headed and 200% entertaining. The cast is phenomenal. Craig clearly enjoyed depicting a heroic protagonist that is the complete opposite of his James Bond character, and the Thrombey family exclusively exists of great talents, including Jamie Lee Curtis, Michael Shannon, Toni Colette, Christopher Plummer and Don Johnson. Knives Out is perhaps slightly too long, but never tedious, and very well-directed by Rian Johnson (who honestly doesn't deserve all this hatred from disappointed Star Wars geeks)"
            },
            new MovieModel{
                Id=5,
                Title = "Ready or Not",
                Genre= "Horror",
                ReleaseYear= 2019,
                Description = "A bride's wedding night takes a sinister turn when her eccentric new in-laws force her to take part in a terrifying game. ",
                ImageUrl = "/images/movies/ron.jpg",
                Review = "As Katniss Everdeen said in the final book (and film) of The Hunger Games: \"There are much worse games to play\". The game in the comedy horror film Ready or Not...is definitely one of those \"worse games\"!\r\n\r\nWhen a bride-to-be is married into a lavish, rich, and weird family, she soon discovers that they really stick to tradition...and tradition in this house, is anything but fun and games! Each time someone is welcomed into the family, they must play a game. For the bride, the game is hide and seek. All she has to do, is avoid being caught by dawn. Sounds easy right? Well, not with the family armed with ancient weapons and planning to perform a ritual on you it isn't! With the bride's new husband being the only reluctant and helpful one, she must outwit, out hide, and out smart the deranged and insane clan, until a supposable curse threatens to, supposably kill the family!\r\n\r\nI made a brilliant choice to see this film! And you will too, if you decide to play the game! The direction of Mr. Matt Bettinelli Olpin, and Mr. Tyler Gillett is excellent! I loved how the camera follows and moves with those who are running for their lives, and the still shots on lots of stuffed animal heads and pictures on the walls; these shots made the film seem a bit like a 90's or 80's era film, which I appreciated. The dark humor was pretty good too, but I especially loved the acting. I adored all the cast members and their splendid talent, especially, Samara Weaving, who played the traumatized, and frightened bride! As for the supposable death that will befall the family if dawn arrives...well, even they aren't sure if it's true! And that's part of the curious mystery!\r\n\r\nTo any brides-to-be-wedded-into-a-new-family, be careful whose family you're welcomed to join, for as the words on the movie poster say: \"In-laws can be murder!\"\r\n"
            },
            new MovieModel{
                Id=6,
                Title = "Wake Up Dead Man",
                Genre= "Mystery",
                ReleaseYear= 2025,
                Description = "Benoit Blanc returns for his most dangerous case yet. ",
                ImageUrl = "/images/movies/wudm.jpg",
                Review = "I saw this movie on the opening night of the Philadelphia Film Festival, which explains why I saw it before it will be released to Netflix in November.\r\n\r\n\"Wake Up Dead Man\" is pretty typical of Rian Johnson's two previous Knives Out films. First, it has a pretty amazing cast. Second, it does make fun of MAGA people. And, third, it's terrific is pretty much every way.\r\n\r\nThe setting for this one is most unusual...a small, dying Catholic church. But once Father Jud Duplenticy arrives at this new post, he's shocked to see that the Monsignor is evil and has created a small, nasty clique or cult within his dying congregation. The common thing that binds these people is a general hatred for mankind...making it not exactly the nicest church you could attend. As a result, the well meaning and decent Father is stumped as to what to do...and it's made worse when the Monsignor physically assaults him and encourages his cult to hate the Father! So, it's not at all surprising when the Monsignor is found murdered during a church service...and it appears is if the killing was impossible. This is where Benoit Blanc enters the story and, frankly, he's really stumped!\r\n\r\nThe writing and acting are just about perfect. Some might dislike the film because they might see it as an attack on religion, though I think this isn't necessarily fair. The Father IS a good man...the sort Rian Johnson seemed to indicate he wishes he had growing up in an evangelical household (we heard about this during the Q&A following the film). All in all, a most enjoyable film....one I nearly scored a 10.\r\n"
            }

        };

        public MovieModel? GetMovieById(int id)
        {
            return Movies.SingleOrDefault(m => m.Id == id);
        }

        public List<MovieModel>? GetMovies()
        {
            return Movies;
        }
    }
}
