using System;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class FilmesController : ControllerBase
    {

        private readonly DataContext _context;

        public FilmesController(DataContext context)
        {

            this._context = context;

        }

        [HttpGet("GetFilmes")]
        public async Task<ActionResult> GetFilmes()
        {
            var filmes = await _context.Filmes.Include(f=>f.Genero).ToListAsync();
            return Ok(filmes);
        }

        [HttpPost("PostFilmes")]
        public async Task<ActionResult> PostFilmes([FromBody]Filme filme)
        {
            try {
                _context.Entry(filme).State = EntityState.Added;
                _context.SaveChanges();
                return Ok("Cadastrado com sucesso");
            }
            catch(Exception e)
            {
                return Ok("Error: " + e.InnerException.Message);
            }
          
        }

        [HttpPut("PutFilmes")]
        public async Task<ActionResult> PutFilmes([FromBody] Filme filme)
        {
            _context.Filmes.Update(filme);
            _context.SaveChanges();
            return Ok("Atualizado com sucesso");
        }

        [HttpDelete("DeleteFilmes")]
        public async Task<ActionResult> DeleteFilmes(int id)
        {
            var filme = await _context.Filmes.Where(f=>f.Id==id).FirstOrDefaultAsync();
            _context.Filmes.Remove(filme);
            _context.SaveChanges();
            return Ok("Deletado com sucesso");
        }
    }
}
