using Diary_Project.BLL.Contracts.User;
using Diary_Project.COMMON.Entities.User;
using Diary_Project.DAL.Contracts.User;
using Microsoft.Extensions.Logging;

//Ctrl + R + G - убрать ненужные using
namespace Diary_Project.BLL.User
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger<UserLogic> _logger;
        public UserLogic(IUserRepository userRepository, ILogger<UserLogic> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        #region PublicMethod
        public async Task CreateAsync(UserInputModel userInputModel)
        {
            ValidateUser(userInputModel);
            var user = new UserDb()
            {
                FirstName = userInputModel.FirstName,
                LastName = userInputModel.LastName,
                Email = userInputModel.Email,
                Password = userInputModel.Password
            };
            await _userRepository.CreateAsync(user);
        }

        public Task<List<UserDb>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<UserDb> GetByIdAsync(int id)
        {
            return await _userRepository.FindByIdAsync(id);
        }
        #endregion

        //Валидатор Юзера - Проверка заполнения данных юзера при вводе "на сайте"
        #region PrivateMethod
        private bool ValidateUser(UserInputModel user)
        {
            
            string validateInfo = string.Empty;
            if (string.IsNullOrEmpty(user.Password) || user.Password.Length <= 5)
            {
                validateInfo += "Пароль не должен быть пустым и не меньше 5 символов; ";
            }

            if (string.IsNullOrEmpty(user.Email))
            {
                validateInfo += "Email не должен быть пустым; ";
            }

            if (string.IsNullOrEmpty(user.FirstName))
            {
                validateInfo += "Имя не должно быть пустым; ";
            }

            if (string.IsNullOrEmpty(user.LastName))
            {
                validateInfo += "Фамилия не должна быть пустой; ";
            }

            if (!string.IsNullOrEmpty(validateInfo))
            {
                _logger.LogError(validateInfo);
                throw new Exception("Неверно заполнены поля; ");
            }
            return true;
        }
        #endregion
    }
}