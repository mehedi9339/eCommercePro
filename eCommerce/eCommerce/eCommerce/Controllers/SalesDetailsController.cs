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
    public class SalesDetailsController : ControllerBase
    {
        private readonly databaseContext _context;

        public SalesDetailsController(databaseContext context)
        {
            _context = context;
        }

        // GET: api/SalesDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesDetail>>> GetSalesDetails()
        {
            try
            {
                return await _context.SalesDetails.ToListAsync();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // GET: api/SalesDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesDetail>> GetSalesDetail(int id)
        {
            var salesDetail = await _context.SalesDetails.FindAsync(id);

            if (salesDetail == null)
            {
                return NotFound();
            }

            return salesDetail;
        }

        // PUT: api/SalesDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesDetail(int id, SalesDetail salesDetail)
        {
            if (id != salesDetail.SalesDetailId)
            {
                return BadRequest();
            }

            _context.Entry(salesDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesDetailExists(id))
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

        // POST: api/SalesDetails
        [HttpPost]
        public async Task<ActionResult<SalesDetail>> PostSalesDetail(SalesDetail salesDetail)
        {
            _context.SalesDetails.Add(salesDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesDetail", new { id = salesDetail.SalesDetailId }, salesDetail);
        }

        // DELETE: api/SalesDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SalesDetail>> DeleteSalesDetail(int id)
        {
            var salesDetail = await _context.SalesDetails.FindAsync(id);
            if (salesDetail == null)
            {
                return NotFound();
            }

            _context.SalesDetails.Remove(salesDetail);
            await _context.SaveChangesAsync();

            return salesDetail;
        }

        private bool SalesDetailExists(int id)
        {
            return _context.SalesDetails.Any(e => e.SalesDetailId == id);
        }
    }
}
