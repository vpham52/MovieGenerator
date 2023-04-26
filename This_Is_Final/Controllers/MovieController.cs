using This_Is_Final.Models;
using Microsoft.AspNetCore.Mvc;

namespace This_Is_Final.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _repo;
        public MovieController(IMovieRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var movie = new Movie();

            movie = _repo.GetApiResponse();

            return View(movie);
        }
    }
}
