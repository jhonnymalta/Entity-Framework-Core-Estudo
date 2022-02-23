using EFCore_001.Dados;
using EFCore_001.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCore_001.Controllers
{
    public class ArtigoController : Controller
    {
        private readonly AppDbContext _context;
        public ArtigoController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Index()
        {
            List<Artigo> listaArtigos = _context.Artigos.ToList();            
            return View(listaArtigos);
        }
        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(Artigo artigo)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            _context.Artigos.Add(artigo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
