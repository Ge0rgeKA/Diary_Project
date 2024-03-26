using Diary_Project.BLL.Contracts.Charge;
using Diary_Project.COMMON.Charge;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChargeController : ControllerBase
    {

        private readonly IChargeLogic _taskLogic;

        public ChargeController(IChargeLogic taskLogic)
        {
            _taskLogic = taskLogic;
        }

        // POST api/<TaskController>
        [HttpPost]
        public void Post([FromBody] ChargeInputModel task)
        {
            _taskLogic.Create(task);
        }

    }
}
