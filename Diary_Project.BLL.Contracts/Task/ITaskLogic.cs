using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diary_Project.COMMON.Tasks;

namespace Diary_Project.BLL.Contracts.Tasks
{
    public interface ITaskLogic
    {
        public void Create(TaskInputModel task);
    }
}
