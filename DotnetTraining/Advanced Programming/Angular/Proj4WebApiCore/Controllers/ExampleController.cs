using Microsoft.AspNetCore.Http;//Web API part
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proj4WebApiCore.Models;

namespace Proj4WebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly ExampleDbContext context;
        public ExampleController(ExampleDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Gets all the Examples associated with the System
        /// </summary>
        /// <returns>An array of Examples</returns>
        [HttpGet]
        public async Task<ActionResult<List<Example>>> AllExamples()
        {
            return await context.Examples.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Example>> FindExample(int id)
        {
            return await context.Examples.FindAsync(id) ?? throw new Exception("Example not found");
        }
        
        [HttpPost]
        public async Task<ActionResult<Example>> AddExample(Example example)
        {
            context.Examples.Add(example);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(FindExample), new { id = example.Id}, example);
        }

        [HttpGet("Categories")]
        public async Task<ActionResult<List<string>>> GetCategories()
        {
            return await context.Examples.Select(x => x.Category).Distinct().ToListAsync();
        }

    }
}
