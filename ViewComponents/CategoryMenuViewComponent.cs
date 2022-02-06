using Microsoft.AspNetCore.Mvc;
using MovieInfo.Data;

namespace MovieInfo.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData.Values["id"];
            return View(CategoryRepository.Categories);
        }

    }
}