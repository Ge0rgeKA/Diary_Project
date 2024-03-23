using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary_Project.COMMON.Entities.User
{
    //Модель, которая поступает именно от пользователя - то что вводит пользователь при регистрации
    public class UserInputModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
