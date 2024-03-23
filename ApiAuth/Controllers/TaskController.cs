using Diary_Project.BLL.Contracts.Task;
using Diary_Project.COMMON.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {

        private readonly ITaskLogic _taskLogic;

        public TaskController(ITaskLogic taskLogic)
        {
            _taskLogic = taskLogic;
        }

        // POST api/<TaskController>
        [HttpPost]
        public void Post([FromBody] TaskInputModel task)
        {
            _taskLogic.Create(task);
        }

    }
}
