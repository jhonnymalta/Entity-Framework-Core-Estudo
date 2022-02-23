using EFCore_001.Dados;
using EFCore_001.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCore_001.Controllers
{
    public class CategoriaController : Controller
    {
        public readonly AppDbContext _context;
        public CategoriaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Categoria> listaCategoria = _context.Categorias.ToList();
            return View(listaCategoria);
        }
        [HttpGet]        
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(Categoria categoira)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _context.Categorias.Add(categoira);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
