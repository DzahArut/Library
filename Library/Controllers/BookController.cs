using Library.Controllers.Helpers;
using Library.Data;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookHelper _bookHelper;
        public BookController(ApplicationDbContext context)
        {
            _bookHelper = new BookHelper(context);
        }
        // GET
        public IActionResult Index()
        {
             return View(_bookHelper.GetRange());
        }

        public IActionResult Create()
        {
            return View(_bookHelper.CreateBookVM());

        }
    }
}