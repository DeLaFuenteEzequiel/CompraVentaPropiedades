using CompraVenta_api.Data;
using CompraVenta_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompraVenta_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InteresadosController : ControllerBase
    {
        private readonly ILogger<InteresadosController> _logger;
        private readonly DataContext _context;

        public InteresadosController(ILogger<InteresadosController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetInteresados")]
        public async Task<ActionResult<IEnumerable<Interesado>>> GetInteresados()
        {
            return await _context.Interesados.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetInteresado")]
        public async Task<ActionResult<Interesado>> GetInteresado(int id)
        {
            var interesado = await _context.Interesados.FindAsync(id);
            if (interesado == null)
            {
                return NotFound();
            }
            return interesado;
        }

        [HttpPost]
        public async Task<ActionResult<Interesado>> PostInteresado(Interesado interesado)
        {
            _context.Interesados.Add(interesado);
            await _context.SaveChangesAsync();

            return new CreatedAtRouteResult("GetInteresado", new { id = interesado.InteresadoId }, interesado);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutInteresado(int id, Interesado interesado)
        {
            if (id != interesado.InteresadoId)
            {
                return BadRequest();
            }

            _context.Entry(interesado).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Interesado>> DeleteInteresado(int id)
        {
            var interesado = await _context.Interesados.FindAsync(id);
            if (interesado == null)
            {
                return NotFound();
            }

            _context.Interesados.Remove(interesado);
            await _context.SaveChangesAsync();
            return interesado;
        }
    }
}
