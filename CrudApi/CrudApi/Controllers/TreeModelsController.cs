using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrudApi.Controllers.Models;

namespace CrudApi.Controllers
{
    [Route("api/tree")]
    [ApiController]
    public class TreeModelsController : ControllerBase
    {
        private readonly TreeModelContext _context;

        public TreeModelsController(TreeModelContext context)
        {
            _context = context;
        }

        // GET: api/tree
        [HttpGet]
        public IEnumerable<TreeListItem> GetTreemodels()
        {
            return _context.TreeModels.Select(x => TreeListItem.From(x));
      
        }

        // GET: api/TreeModels/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTreeModel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var treeModel = await _context.TreeModels.FindAsync(id);

            if (treeModel == null)
            {
                return NotFound();
            }

            return Ok(treeModel);
        }

        // PUT: api/TreeModels/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTreeModel([FromRoute] int id, [FromBody] TreeModel treeModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != treeModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(treeModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TreeModelExists(id))
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

        // POST: api/TreeModels
        [HttpPost]
        public async Task<IActionResult> PostTreeModel([FromBody] TreeModel treeModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TreeModels.Add(treeModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTreeModel", new { id = treeModel.Id }, treeModel);
        }

        // DELETE: api/TreeModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTreeModel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var treeModel = await _context.TreeModels.FindAsync(id);
            if (treeModel == null)
            {
                return NotFound();
            }

            _context.TreeModels.Remove(treeModel);
            await _context.SaveChangesAsync();

            return Ok(treeModel);
        }

        private bool TreeModelExists(int id)
        {
            return _context.TreeModels.Any(e => e.Id == id);
        }
    }
}