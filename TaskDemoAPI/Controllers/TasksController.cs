using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskDemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public List<string> GetAllTasks()
        {
            return new List<string>() { "Go Shopping", "Do homework", "Morning meeting",
            "create currency API"};


        }

       

    }
}
