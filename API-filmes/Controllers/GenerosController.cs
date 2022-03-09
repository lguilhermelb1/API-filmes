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
    public class GenerosController : ControllerBase
    {

        private readonly DataContext _context;

        public GenerosController(DataContext context)
        {

            this._context = context;

        }

        [HttpGet("GetGeneros")]
        public async Task<ActionResult> GetGeneros()
        {
            var generos = await _context.Generos.ToListAsync();
            return Ok(generos);
        }

        [HttpPost("PostGeneros")]
        public async Task<ActionResult> PostGeneros([FromBody] Genero genero)
        {
            _context.Generos.Add(genero);
            _context.SaveChanges();
            return Ok("Cadastrado com sucesso");
        }

        [HttpPut("PutGeneros")]
        public async Task<ActionResult> PutGeneros([FromBody] Genero genero)
        {
            _context.Generos.Update(genero);
            _context.SaveChanges();
            return Ok("Atualizado com sucesso");
        }

        [HttpDelete("DeleteGeneros")]
        public async Task<ActionResult> DeleteGeneros(int id)
        {
            var genero = await _context.Generos.Where(f => f.Id == id).FirstOrDefaultAsync();
            _context.Generos.Remove(genero);
            _context.SaveChanges();
            return Ok("Deletado com sucesso");
        }
    }
}
