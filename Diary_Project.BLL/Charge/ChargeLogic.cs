using Diary_Project.BLL.Contracts.Charge;
using Diary_Project.COMMON.Charge;
using Diary_Project.DAL.Contracts.Charge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary_Project.BLL.Charge
{
    public class ChargeLogic : IChargeLogic
    {
        private readonly ITaskRepository _taskRepository;

        public ChargeLogic(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public void Create(ChargeInputModel task)
        {
            _taskRepository.Add(task);
        }
    }
}
