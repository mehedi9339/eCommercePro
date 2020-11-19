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
    public class ThanasController : ControllerBase
    {
        private readonly databaseContext _context;

        public ThanasController(databaseContext context)
        {
            _context = context;
        }

        // GET: api/Thanas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Thana>>> GetThanas()
        {
            try
            {
                return await _context.Thanas.ToListAsync();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // GET: api/Thanas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Thana>> GetThana(int id)
        {
            var thana = await _context.Thanas.FindAsync(id);

            if (thana == null)
            {
                return NotFound();
            }

            return thana;
        }

        // PUT: api/Thanas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutThana(int id, Thana thana)
        {
            if (id != thana.ThanaId)
            {
                return BadRequest();
            }

            try
            {
                _context.Entry(thana).State = EntityState.Modified;
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
                "Name": "fgsdfgsfd",
                "DistrictId": 1
            },
            {
                "Name": "gdfgdf",
                "DistrictId": 2
            }
        ]
         */
        // POST: api/Thanas
        [HttpPost]
        public async Task<ActionResult<Thana>> PostThana(List<Thana> thana)
        {
            try
            {
                string message = string.Empty;
                foreach (var item in thana)
                {
                    if (!_context.Thanas.Any(c => c.Name == item.Name))
                    {
                        _context.Thanas.Add(item);
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
                    return Created("", thana);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // DELETE: api/Thanas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Thana>> DeleteThana(int id)
        {
            var thana = await _context.Thanas.FindAsync(id);
            if (thana == null)
            {
                return NotFound();
            }

            try
            {
                _context.Thanas.Remove(thana);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return thana;
        }
    }
}
