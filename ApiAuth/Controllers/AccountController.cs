using ApiAuth.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ApiAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private List<Person> people = new List<Person>
        {
            new Person {Login="admin@gmail.com", Password="12345", Role = "admin" },
            new Person { Login="qwerty@gmail.com", Password="55555", Role = "user" }
        };


        /*9. Для обработки запроса в контроллере создан метод Token, 
         * который сопоставлен с маршрутом "/token". 
         * Этот метод обрабатывает запросы POST 
         * и через параметры принимает логин и пароль пользователя.*/
        [HttpPost("/token")]
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
    }
}
