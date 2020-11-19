using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eCommerce.Context;
using eCommerce.Models;
using System;
using Microsoft.AspNetCore.Authorization;

namespace eCommerce.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly databaseContext _context;


        public CategoriesController(databaseContext context)
        {
            _context = context;
        }

        // GET: api/Categories
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            try
            {

                return await _context.Categories.ToListAsync();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }

        // PUT: api/Categories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, Category category)
        {
            if (id != category.CategoryId)
            {
                return BadRequest();
            }

            try
            {
                _context.Entry(category).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok();
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
                "Name": "AAAA",
                "ParentId": 0
            },
            {
                "Name": "BBB",
                "ParentId": 1
            }
        ]
         */
        // POST: api/Categories
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(List<Category> category)
        {
            try
            {
                string message = string.Empty;
                foreach (var item in category)
                {
                    if (!_context.Categories.Any(c => c.Name == item.Name))
                    {
                        _context.Categories.Add(item);
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
                    return Created("", category);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Category>> DeleteCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            try
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return category;
        }
    }
}
