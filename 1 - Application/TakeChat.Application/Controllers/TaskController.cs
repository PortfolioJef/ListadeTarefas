using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task.Domain.Entities;
using Task.Infra.Data.Context;

namespace Task.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly taskAppContext _ctx;

        public TaskController(taskAppContext ctx)
        {
            _ctx = ctx;
        }

        // GET: api/TaskEntitys
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskEntity>>> GetTaskEntityAsync()
        {
            return await _ctx.Tasks.ToListAsync();
        }

        // GET: api/TaskEntitys/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskEntity>> GetTaskEntityAsync(int id)
        {
            var TaskEntity = await _ctx.Tasks.FindAsync(id);

            if (TaskEntity == null)
            {
                return NotFound();
            }

            return TaskEntity;
        }

        // PUT: api/TaskEntitys/5        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskEntityAsync(int id, TaskEntity TaskEntity)
        {
            if (id != TaskEntity.Id)
            {
                return BadRequest();
            }

            _ctx.Entry(TaskEntity).State = EntityState.Modified;

            try
            {
                await _ctx.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskEntityExists(id))
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

        // POST: api/TaskEntitys
        [HttpPost]
        public async Task<ActionResult<TaskEntity>> PostTaskEntityAsync(TaskEntity TaskEntity)
        {
            _ctx.Tasks.Add(TaskEntity);
            await _ctx.SaveChangesAsync();

            return CreatedAtAction("GetTaskEntity", new { id = TaskEntity.Id }, TaskEntity);
        }

        // DELETE: api/TaskEntitys/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TaskEntity>> DeleteTaskEntityAsync(int id)
        {
            var TaskEntity = await _ctx.Tasks.FindAsync(id);
            if (TaskEntity == null)
            {
                return NotFound();
            }

            _ctx.Tasks.Remove(TaskEntity);
            await _ctx.SaveChangesAsync();

            return TaskEntity;
        }

        private bool TaskEntityExists(int id)
        {
            return _ctx.Tasks.Any(e => e.Id == id);
        }
    }
}
