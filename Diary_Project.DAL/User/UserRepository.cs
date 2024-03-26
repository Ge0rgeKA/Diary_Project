using Diary_Project.COMMON.Entities.User;
using Diary_Project.DAL.Contracts.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary_Project.DAL.User
{
    public class UserRepository : IUserRepository
    {
        private readonly DiaryContext _dbContext;
        private readonly ILogger<UserRepository> _logger;
        public UserRepository(DiaryContext diaryContext, ILogger<UserRepository> logger)
        {
            _dbContext = diaryContext;
            _logger = logger;
        }

        #region
        public async Task CreateAsync(UserDb user)
        {
            try
            {
                await _dbContext.Users.AddAsync(user);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }

        public async Task<UserDb> FindByIdAsync(int id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<UserDb>> GetAllAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }
        #endregion
    }
}
