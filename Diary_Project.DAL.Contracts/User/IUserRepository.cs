using Diary_Project.COMMON.Entities.User;

namespace Diary_Project.DAL.Contracts.User
{
    public interface IUserRepository
    {
        public System.Threading.Tasks.Task CreateAsync(UserDb user);
        public Task<UserDb> FindByIdAsync(int id);
        public Task<List<UserDb>> GetAllAsync();
    }
}
