using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary_Project.COMMON.Entities.User
{
    //Модель, которая будет записываться в базе данных - это форма для БАЗЫ ДАННЫХ
    public class UserDb
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
