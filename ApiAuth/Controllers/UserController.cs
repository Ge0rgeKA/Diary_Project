using ApiAuth.Models;
using Diary_Project.BLL.Contracts.User;
using Diary_Project.COMMON.Entities.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ApiAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserLogic _userLogic;

        public UserController(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await _userLogic.GetAllAsync());
        }

        [HttpGet("{id}")]

        public async Task<IAtionResult> Get(int id)
        {
            return Ok(await _userLogic.GetByIdAsync(id));
        }

        [HttpPost]

        public async Task Post([FromBody] UserInputModel user)
        {
            await _userLogic.CreateAsync(user);
        }

        [HttpPut("{id}")]

        public void Put(int id, [FromBody] string value)
        {

        }




        private List<User> people = new List<User>
        {
            new User {Login="admin@gmail.com", Password="12345", Role = "admin" },
            new User { Login="qwerty@gmail.com", Password="55555", Role = "user" }
        };


        /*9. Для обработки запроса в контроллере создан метод Token, 
         * который сопоставлен с маршрутом "/token". 
         * Этот метод обрабатывает запросы POST 
         * и через параметры принимает логин и пароль пользователя.*/
        [HttpPost("/token")] //[HttpPost("/token")] - это маршрут к методу, написанному ниже
        public IActionResult Token(string username, string password)
        {
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, username) };
            // создаем JWT-токен
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    claims: claims,
                    expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(2)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

            return Ok(new JwtSecurityTokenHandler().WriteToken(jwt)); //10.3 В конце он сериализуется и отправляет клиенту с помощью метода Json().
        }

        //23.03 - 1 создание метода по введению юзера в систему
        [HttpPost("/CreateUser")] 
        public void CreateUser(User user)
        {

            
        }
    }
}
