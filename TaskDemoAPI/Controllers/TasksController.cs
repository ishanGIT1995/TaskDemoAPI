using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskDemoAPI.Models;

namespace TaskDemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet] 
        public IEnumerable<MyTask> GetAllTasks()
        {
            return new List<MyTask>()
                {
                new MyTask()
                {
                    Id = 1,
                    Title = "Go Shopping",
                    Description = "Go Shopping and buy some snacks",


                },
                new MyTask()
                {
                    Id = 2,
                    Title = "Watch a movie",
                    Description = "this saturday go and watch movie SpiderMan"

                },

                
                };


        }

       
    }
}
