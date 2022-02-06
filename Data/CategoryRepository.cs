using MovieInfo.Models;

namespace MovieInfo.Data
{
    public static class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository()
        {
            _categories = new List<Category>()
            {
                new Category() {Id=1, Name="Adventure"},
                new Category() {Id=2, Name="Romantic"},
                new Category() {Id=3, Name="Science Fiction"},
                new Category() {Id=4, Name="War"},
                new Category() {Id=5, Name="Comedy"}
            };
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void AddCategory(Category entity)
        {
            _categories.Add(entity);
        }

        public static Category GetById(int id)
        {
            return _categories.FirstOrDefault(i => i.Id == id);
        }
    }
}