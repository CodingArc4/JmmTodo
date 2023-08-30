using Microsoft.AspNetCore.Mvc;
using TodoTask.Models;

namespace TodoTask.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodoModel _context;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index()
    }
}
