using EFCore_001.Dados;
using EFCore_001.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCore_001.Controllers
{
    public class UsuarioController : Controller
    {
        public readonly AppDbContext _context;
        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Usuario> listaUsuarios = _context.Usuarios.ToList();
            return View(listaUsuarios);
        }
        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();
        }
        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if(id == null)
            {
                return View();
            }
            var usuario = _context.Usuarios.SingleOrDefault(c=> c.ID == id);   
            return View(usuario);
        }
        [HttpPost]
        public IActionResult Editar(Usuario usuario)
        {
            if (ModelState.IsValid) {
                _context.Usuarios.Update(usuario);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(usuario);
        }
        [HttpGet]
        public IActionResult Deletar(int? id)
        {
            var usuario = _context.Usuarios.FirstOrDefault(c => c.ID == id);
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
