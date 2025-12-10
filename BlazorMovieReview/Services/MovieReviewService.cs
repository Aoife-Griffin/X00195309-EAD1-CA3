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
                Description = "Traveling across the multiverse, Miles Morales meets a new team of Spider-People, made up of heroes from different dimensions. But when the heroes clash over how to deal with a new threat, Miles finds himself at a crossroads. ",
                ImageUrl = "/images/movies/atsv.jpg",
                Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia"
            },
             new MovieModel{
                Id=2,
                Title = "Escape Room",
                Description = "Six strangers find themselves in a maze of deadly mystery rooms and must use their wits to survive. ",
                ImageUrl = "/images/movies/ems.jpg",
                Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia"
            },
            new MovieModel{
                Id=3,
                Title = "Glass Onion",
                Description = "Tech billionaire Miles Bron invites his friends for a getaway on his private Greek island. When someone turns up dead, Detective Benoit Blanc is put on the case. ",
                ImageUrl = "/images/movies/go.jpg",
                Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia"
            },
            new MovieModel{
                Id=4,
                Title = "Knives Out",
                Description = "When renowned crime novelist Harlan Thrombey is found dead at his estate just after his 85th birthday, the inquisitive and debonair Detective Benoit Blanc is mysteriously enlisted to investigate. ",
                ImageUrl = "/images/movies/ko.jpg",
                Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia"
            },
            new MovieModel{
                Id=5,
                Title = "Ready or Not",
                Description = "A bride's wedding night takes a sinister turn when her eccentric new in-laws force her to take part in a terrifying game. ",
                ImageUrl = "/images/movies/ron.jpg",
                Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia"
            },
            new MovieModel{
                Id=6,
                Title = "Wake Up Dead Man",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. ",
                ImageUrl = "/images/movies/wudm.jpg",
                Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia"
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
