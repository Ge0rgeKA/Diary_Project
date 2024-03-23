/*7. Т.к. в прокте пока не предусмотрена генерация токенов
 мы можем либо воспользоваться сторонними решениями 
(например, IdentityServer или OpenIdDict), 
либо же создать свой механизм - что мы и сделаем далее...*/

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Diary_Project.PL.API.Models; // класс Person

namespace Diary_Project.PL.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        // тестовые данные вместо использования базы данных
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
        //10.4 Таким образом генерируется токен.

        /*8. Для поиска пользователя в этом списке по логину и паролю 
         * определен метод GetIdentity(), который возвращает объект ClaimsIdentity.
         *Принцип создания ClaimsIdentity здесь тот же, что и при аутентификации 
         * с помощью кук: создается набор объектов Claim, которые включают 
         * различные данные о пользователе, например, логин, роль и т.д.*/
        private ClaimsIdentity GetIdentity(string username, string password)
        {
            Person person = people.FirstOrDefault(x => x.Login == username && x.Password == password);
            if (person != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, person.Login),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType, person.Role)
                };
                ClaimsIdentity claimsIdentity =
                new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType);
                return claimsIdentity;
            }

            // если пользователя не найдено
            return null;
        }
        
    }
}
