using Microsoft.AspNetCore.Mvc;
using MovieInfo.Data;
using MovieInfo.Models;

namespace MovieInfo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? id)
        {
            MovieCategoryModel model = new MovieCategoryModel();
            model.Categories = CategoryRepository.Categories;
            if (id == null)
            {
                model.Movies = MovieRepository.Movies;
            }
            else
                model.Movies = MovieRepository.Movies.Where(m => m.CategoryId == id);


            return View(model);
        }

        public IActionResult Details(int id)
        {
            MovieCategoryModel model = new MovieCategoryModel();
            model.Categories = CategoryRepository.Categories;
            model.Movie = MovieRepository.GetById(id);
            return View(model);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }

}