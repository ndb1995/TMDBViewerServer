using System.Threading.Tasks;
using TMDbLib.Client;
using TMDbLib.Objects.Movies;

namespace TMDBViewerServer.Data
{
    public class MovieService
    {

        TMDbClient client = new TMDbClient("8bd5a4c221de15578361b66eab285db8");

        /// <summary>
        /// get a movie based off of tmdb movie id
        /// </summary>
        public async Task<Movie> getMovieTMDB(int id)
        {
            Movie movie = await client.GetMovieAsync(id, MovieMethods.Credits | MovieMethods.Videos);

            return movie;
        }

        /// <summary>
        /// get a movie based off of IMDB movie id
        /// </summary>
        public async Task<Movie> getMovieIMDB(string name)
        {
            Movie movie = await client.GetMovieAsync(name, MovieMethods.Credits | MovieMethods.Videos);

            return movie;
        }
    }
}
