using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eCommerce.Context;
using eCommerce.Models;
using System;

namespace eCommerce.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitsController : ControllerBase
    {
        private readonly databaseContext _context;

        public UnitsController(databaseContext context)
        {
            _context = context;
        }

        // GET: api/Units
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Unit>>> GetUnits()
        {
            try
            {
                return await _context.Units.ToListAsync();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // GET: api/Units/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Unit>> GetUnit(int id)
        {
            var unit = await _context.Units.FindAsync(id);

            if (unit == null)
            {
                return NotFound();
            }

            return unit;
        }

        // PUT: api/Units/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnit(int id, Unit unit)
        {
            if (id != unit.UnitId)
            {
                return BadRequest();
            }

            try
            {
                _context.Entry(unit).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return NoContent();
        }
        /*
         [
            {
                "Name": "Killogra",
                "ShortName": "fg"
            },
            {
                "Name": "fdgdfg",
                "ShortName": "fr"
            }
        ]
         */
        // POST: api/Units
        [HttpPost]
        public async Task<ActionResult<Unit>> PostUnit(List<Unit> unit)
        {
            try
            {
                string message = string.Empty;
                foreach (var item in unit)
                {
                    if (!_context.Units.Any(c => c.Name == item.Name))
                    {
                        _context.Units.Add(item);
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        message += item.Name + ", ";
                    }
                }
                if (message != "")
                {
                    var i = message.LastIndexOf(',');
                    message = message.Remove(i, 1);
                    return BadRequest(message + "Already Exists!");
                }
                else
                {
                    return Created("", unit);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // DELETE: api/Units/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> DeleteUnit(int id)
        {
            var unit = await _context.Units.FindAsync(id);
            if (unit == null)
            {
                return NotFound();
            }

            try
            {
                _context.Units.Remove(unit);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return unit;
        }
    }
}
