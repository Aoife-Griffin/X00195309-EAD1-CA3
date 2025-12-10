using BlazorMovieReview.Models;

namespace BlazorMovieReview.Services
{
    public interface IMovieReviewService
    {
        List<MovieModel>? GetMovies();
        MovieModel? GetMovieById(int id);
    }
}
