using CompraVenta_api.Data;
using CompraVenta_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompraVenta_api.Controllers
{
[ApiController]
[Route("api/[controller]")]
    public class PropiedadesController : ControllerBase
    {
        private readonly ILogger<PropiedadesController> _logger;
        private readonly DataContext _context;

        public PropiedadesController(ILogger<PropiedadesController> logger, DataContext context){
            _logger= logger;
            _context = context;
        }

        [HttpGet(Name = "GetPropiedades")]
        public async Task<ActionResult<IEnumerable<Propiedad>>> GetPropiedades()
        {
            return await _context.Propiedades.ToListAsync();
        }

         [HttpGet("{id}",Name = "GetPropiedad")]
         public async Task<ActionResult<Propiedad>> GetPropiedad(int id)
         {
            var propiedad = await _context.Propiedades.FindAsync(id);
            if( propiedad == null){
                return NotFound();
            }
            return propiedad;

         }

         [HttpPost]
         public async Task<ActionResult<Propiedad>> Post(Propiedad propiedad)
         {
            _context.Propiedades.Add(propiedad);
            await _context.SaveChangesAsync();

            return new CreatedAtRouteResult("GetPropiedad",new{id = propiedad.PropiedadId },propiedad);
         }

          [HttpPut("{id}")]
           public async Task<ActionResult> Put(int id, Propiedad propiedad)
           {
                if(id!=propiedad.PropiedadId){
                    return BadRequest();
                }

                _context.Entry(propiedad).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return Ok();
           }

            [HttpDelete("{id}")]
            public async Task<ActionResult<Propiedad>> Delete(int id){
                var propiedad = await _context.Propiedades.FindAsync(id);
                if(propiedad == null){
                    return NotFound();
                }

                _context.Propiedades.Remove(propiedad);
                await _context.SaveChangesAsync();
                return propiedad;
            }
    }
}