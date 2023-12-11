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
        public ActionResult<IEnumerable<MyTask>> GetAllTasks()
        {


            //MyTaskRepository obj =  new MyTaskRepository();
            //return obj.MyTasks;

            return Ok(MyTaskRepository.MyTasks);

            //return (IEnumerable<MyTask>)Ok();


        }
        [HttpGet("{id}")]

        public ActionResult<MyTask> GetTask(int id) 
        {
            var task = MyTaskRepository.MyTasks.FirstOrDefault(x => x.Id == id);
            if (task == null)
            {
               return  NotFound();
            }

            return Ok(task);
        }

         


    }
}
