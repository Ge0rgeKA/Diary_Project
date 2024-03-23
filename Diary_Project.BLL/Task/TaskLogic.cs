using Diary_Project.BLL.Contracts.Tasks;
using Diary_Project.COMMON.Tasks;
using Diary_Project.DAL.Contracts.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary_Project.BLL.Taska
{
    public class TaskLogic : ITaskLogic
    {
        private readonly ITaskRepository _taskRepository;

        public TaskLogic(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public void Create(TaskInputModel task)
        {
            _taskRepository.Add(task);
        }
    }
}
