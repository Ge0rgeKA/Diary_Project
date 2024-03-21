namespace Diary_Project.PL.API.Models
{
    // 1. Этот класс будет описывать учетные записи пользователей в приложении.
    public class Person
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
