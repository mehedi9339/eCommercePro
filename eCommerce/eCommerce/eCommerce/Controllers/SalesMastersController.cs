using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eCommerce.Context;
using eCommerce.Models;
using System;

namespace eCommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesMastersController : ControllerBase
    {
        private readonly databaseContext _context;

        public SalesMastersController(databaseContext context)
        {
            _context = context;
        }

        // GET: api/SalesMasters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesMaster>>> GetSalesMasters()
        {
            try
            {
                return await _context.SalesMasters.ToListAsync();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // GET: api/SalesMasters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesMaster>> GetSalesMaster(int id)
        {
            var salesMaster = await _context.SalesMasters.FindAsync(id);

            if (salesMaster == null)
            {
                return NotFound();
            }

            return salesMaster;
        }

        // PUT: api/SalesMasters/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesMaster(int id, SalesMaster salesMaster)
        {
            if (id != salesMaster.SalesMasterId)
            {
                return BadRequest();
            }

            _context.Entry(salesMaster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesMasterExists(id))
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

        // POST: api/SalesMasters
        [HttpPost]
        public async Task<ActionResult<SalesMaster>> PostSalesMaster(SalesMaster salesMaster)
        {
            _context.SalesMasters.Add(salesMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesMaster", new { id = salesMaster.SalesMasterId }, salesMaster);
        }

        // DELETE: api/SalesMasters/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SalesMaster>> DeleteSalesMaster(int id)
        {
            var salesMaster = await _context.SalesMasters.FindAsync(id);
            if (salesMaster == null)
            {
                return NotFound();
            }

            _context.SalesMasters.Remove(salesMaster);
            await _context.SaveChangesAsync();

            return salesMaster;
        }

        private bool SalesMasterExists(int id)
        {
            return _context.SalesMasters.Any(e => e.SalesMasterId == id);
        }
    }
}
