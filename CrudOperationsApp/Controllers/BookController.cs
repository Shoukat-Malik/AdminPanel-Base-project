using CrudOperationsApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CrudOperationsApp.Controllers
{
    public class BookController : Controller
    {
        //private readonly IBookRepository _bookRepository = null;
        //public BookController(IBookRepository bookRepository)
        //{
        //    _bookRepository = bookRepository; 
        //}
        public IActionResult Index()
        {
            return View();
        }
    }
}
