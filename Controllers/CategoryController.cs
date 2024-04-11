using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDo_List.Controllers
{
    public class CategoryController : Controller
    {
        private IRepository<CategoryController> data {  get; set; }

        public CategoryController(IRepository<Author> repository) => data = repository;
    }
}
