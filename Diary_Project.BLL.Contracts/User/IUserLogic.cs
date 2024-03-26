using Diary_Project.COMMON.Entities.User;

namespace Diary_Project.BLL.Contracts.User
{
    public interface IUserLogic
    {
        public Task CreateAsync(UserInputModel UserInputModel);
        public Task<List<UserDb>> GetAllAsync();
        public Task<UserDb> GetByIdAsync(int id);
    }
}
