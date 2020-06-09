using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FiliereMicroService.Models;

namespace FiliereMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilieresController : ControllerBase
    {
        private readonly FiliereContext _context;

        public FilieresController()
        {
            _context = new FiliereContext();
        }

        // GET: api/Filieres
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Filiere>>> GetFilieres()
        {
            return await _context.Filieres.ToListAsync();
        }

        // GET: api/Filieres/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Filiere>> GetFiliere(int id)
        {
            var filiere = await _context.Filieres.FindAsync(id);

            if (filiere == null)
            {
                return NotFound();
            }

            return filiere;
        }

        // PUT: api/Filieres/5
     
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFiliere(int id, Filiere filiere)
        {
            if (id != filiere.FiliereId)
            {
                return BadRequest();
            }

            _context.Entry(filiere).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FiliereExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Filieres
        
        [HttpPost]
        public async Task<ActionResult<Filiere>> PostFiliere(Filiere filiere)
        {
            _context.Filieres.Add(filiere);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFiliere", new { id = filiere.FiliereId }, filiere);
        }

        // DELETE: api/Filieres/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Filiere>> DeleteFiliere(int id)
        {
            var filiere = await _context.Filieres.FindAsync(id);
            if (filiere == null)
            {
                return NotFound();
            }

            _context.Filieres.Remove(filiere);
            await _context.SaveChangesAsync();

            return filiere;
        }

        private bool FiliereExists(int id)
        {
            return _context.Filieres.Any(e => e.FiliereId == id);
        }
    }
}
