using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Back_ps.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace Back_ps.Controllers
{
    public class CadastroUsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CadastroUsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Email,Senha")] CadastroUsuario cadastroUsuario)
        {
            var userin = await _context.CadastroUsuarios
                .FirstOrDefaultAsync(m => m.Email == cadastroUsuario.Email);

            if (userin == null)
            {
                ViewBag.Message = "Usuário ou Senha Inválido!";
                return View();
            }

            bool isSenhaok = BCrypt.Net.BCrypt.Verify(cadastroUsuario.Senha, userin.Senha);

            if(isSenhaok)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, userin.Nome),
                    new Claim(ClaimTypes.NameIdentifier, userin.Nome)
                };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity); 

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true
                };

                await HttpContext.SignInAsync(principal, props);

                return Redirect("/");

                ViewBag.Message = "Usuário OK!";
                return View();
            }
            ViewBag.Message = "Usuário ou Senha Inválido!";
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();

        }

        // GET: CadastroUsuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.CadastroUsuarios.ToListAsync());
        }

        // GET: CadastroUsuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroUsuario = await _context.CadastroUsuarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastroUsuario == null)
            {
                return NotFound();
            }

            return View(cadastroUsuario);
        }

        // GET: CadastroUsuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CadastroUsuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Email,Senha,Genero,Idade,Telefone")] CadastroUsuario cadastroUsuario)
        {
            if (ModelState.IsValid)
            {
                cadastroUsuario.Senha = BCrypt.Net.BCrypt.HashPassword(cadastroUsuario.Senha);
                _context.Add(cadastroUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroUsuario);
        }

        // GET: CadastroUsuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroUsuario = await _context.CadastroUsuarios.FindAsync(id);
            if (cadastroUsuario == null)
            {
                return NotFound();
            }
            return View(cadastroUsuario);
        }

        // POST: CadastroUsuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,Senha,Genero,Idade,Telefone")] CadastroUsuario cadastroUsuario)
        {
            if (id != cadastroUsuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    cadastroUsuario.Senha = BCrypt.Net.BCrypt.HashPassword(cadastroUsuario.Senha);
                    _context.Update(cadastroUsuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroUsuarioExists(cadastroUsuario.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroUsuario);
        }

        // GET: CadastroUsuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroUsuario = await _context.CadastroUsuarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastroUsuario == null)
            {
                return NotFound();
            }

            return View(cadastroUsuario);
        }

        // POST: CadastroUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cadastroUsuario = await _context.CadastroUsuarios.FindAsync(id);
            _context.CadastroUsuarios.Remove(cadastroUsuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroUsuarioExists(int id)
        {
            return _context.CadastroUsuarios.Any(e => e.Id == id);
        }
    }
}
