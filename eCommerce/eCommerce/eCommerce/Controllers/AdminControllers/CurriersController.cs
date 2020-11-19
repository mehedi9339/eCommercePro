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
    public class CurriersController : ControllerBase
    {
        private readonly databaseContext _context;

        public CurriersController(databaseContext context)
        {
            _context = context;
        }

        // GET: api/Curriers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Currier>>> GetCurrier()
        {
            try
            {
                return await _context.Currier.ToListAsync();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // GET: api/Curriers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Currier>> GetCurrier(int id)
        {
            var currier = await _context.Currier.FindAsync(id);

            if (currier == null)
            {
                return NotFound();
            }

            return currier;
        }

        // PUT: api/Curriers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurrier(int id, Currier currier)
        {
            if (id != currier.CurrierId)
            {
                return BadRequest();
            }

            try
            {
                _context.Entry(currier).State = EntityState.Modified;
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
                "Name": "dfsd",
                "DistrictId": 1,
                "ThanaId": 1,
                "Phone": "01745256325"
            },
            {
                "Name": "fsdfds",
                "DistrictId": 2,
                "ThanaId": 2,
                "Phone": "01748956325"
            }
        ]
         */
        // POST: api/Curriers
        [HttpPost]
        public async Task<ActionResult<Currier>> PostCurrier(List<Currier> currier)
        {
            try
            {
                string message = string.Empty;
                foreach (var item in currier)
                {
                    if (!_context.Currier.Any(c => c.Name == item.Name))
                    {
                        _context.Currier.Add(item);
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
                    return Created("", currier);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // DELETE: api/Curriers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Currier>> DeleteCurrier(int id)
        {
            var currier = await _context.Currier.FindAsync(id);
            if (currier == null)
            {
                return NotFound();
            }

            try
            {
                _context.Currier.Remove(currier);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return currier;
        }
    }
}
