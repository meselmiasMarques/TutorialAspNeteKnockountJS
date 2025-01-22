
using Microsoft.EntityFrameworkCore;
using TutorialAspNetKnockoutJS.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace TutorialAspNetKnockoutJS.Controllers
{
    public class TodoController : Controller
    {
        private readonly AppDbContext _context;

        public TodoController(AppDbContext context)
        {
            _context = context;
        }

        // Carrega a view
        public ActionResult Index()
        {
            return View();
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<IActionResult> GetTodos()
        {
            var listTodos = await _context.Todos.ToListAsync();
            return Json(listTodos);
        }



    }
}
