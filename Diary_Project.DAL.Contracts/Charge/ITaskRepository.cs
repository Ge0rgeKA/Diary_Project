using Diary_Project.COMMON.Charge;

namespace Diary_Project.DAL.Contracts.Charge
{
    public interface ITaskRepository
    {
        public void Add(ChargeInputModel task);
    }
}
