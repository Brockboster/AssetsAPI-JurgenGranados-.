using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AssetsAPI_JurgenGranados__.Models;

namespace AssetsAPI_JurgenGranados__.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetsInfoesController : ControllerBase
    {
        private readonly P6Assets20231Context _context;

        public AssetsInfoesController(P6Assets20231Context context)
        {
            _context = context;
        }

        // GET: api/AssetsInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AssetsInfo>>> GetAssetsInfos()
        {
            return await _context.AssetsInfos.ToListAsync();
        }

        // GET: api/AssetsInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AssetsInfo>> GetAssetsInfo(int id)
        {
            var assetsInfo = await _context.AssetsInfos.FindAsync(id);

            if (assetsInfo == null)
            {
                return NotFound();
            }

            return assetsInfo;
        }

        // PUT: api/AssetsInfoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAssetsInfo(int id, AssetsInfo assetsInfo)
        {
            if (id != assetsInfo.Idactivo)
            {
                return BadRequest();
            }

            _context.Entry(assetsInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssetsInfoExists(id))
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

        // POST: api/AssetsInfoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AssetsInfo>> PostAssetsInfo(AssetsInfo assetsInfo)
        {
            _context.AssetsInfos.Add(assetsInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAssetsInfo", new { id = assetsInfo.Idactivo }, assetsInfo);
        }

        // DELETE: api/AssetsInfoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssetsInfo(int id)
        {
            var assetsInfo = await _context.AssetsInfos.FindAsync(id);
            if (assetsInfo == null)
            {
                return NotFound();
            }

            _context.AssetsInfos.Remove(assetsInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AssetsInfoExists(int id)
        {
            return _context.AssetsInfos.Any(e => e.Idactivo == id);
        }
    }
}
