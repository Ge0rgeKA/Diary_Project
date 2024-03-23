using Diary_Project.COMMON.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary_Project.DAL.Contracts.Task
{
    public interface ITaskRepository
    {
        public void Add(TaskInputModel task);
    }
}
