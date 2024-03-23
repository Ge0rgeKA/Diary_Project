using Diary_Project.COMMON.Tasks;

namespace Diary_Project.DAL.Contracts.Tasks
{
    public interface ITaskRepository
    {
        public void Add(TaskInputModel task);
    }
}
