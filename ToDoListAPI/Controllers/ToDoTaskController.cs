using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoListAPI.Data;
using ToDoListAPI.Model;

namespace ToDoListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoTaskController : ControllerBase
    {
        private readonly ToDoTaskDbContext _context;

        public ToDoTaskController(ToDoTaskDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<ToDoTask>> Get()
            => await _context.ToDoTasks.ToListAsync();
    }
}