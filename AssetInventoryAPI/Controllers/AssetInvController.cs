using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AssetInventoryAPI.Data;
using AssetInventoryAPI.Model;

namespace AssetInventoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetInvController : ControllerBase
    {
        private readonly AssetInventoryAPIContext _context;

        public AssetInvController(AssetInventoryAPIContext context)
        {
            _context = context;
        }

        // GET: api/AssetInv
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AssetInv>>> GetAssetInv()
        {
            return await _context.AssetInv.ToListAsync();
        }

        // GET: api/AssetInv/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AssetInv>> GetAssetInv(string id)
        {
            var assetInv = await _context.AssetInv.FindAsync(id);

            if (assetInv == null)
            {
                return NotFound();
            }

            return assetInv;
        }

        // PUT: api/AssetInv/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAssetInv(string id, AssetInv assetInv)
        {
            if (id != assetInv.agreement_number)
            {
                return BadRequest();
            }

            _context.Entry(assetInv).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssetInvExists(id))
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

        // POST: api/AssetInv
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AssetInv>> PostAssetInv(AssetInv assetInv)
        {
            _context.AssetInv.Add(assetInv);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AssetInvExists(assetInv.agreement_number))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAssetInv", new { id = assetInv.agreement_number }, assetInv);
        }

        // DELETE: api/AssetInv/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssetInv(string id)
        {
            var assetInv = await _context.AssetInv.FindAsync(id);
            if (assetInv == null)
            {
                return NotFound();
            }

            _context.AssetInv.Remove(assetInv);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AssetInvExists(string id)
        {
            return _context.AssetInv.Any(e => e.agreement_number == id);
        }
    }
}
