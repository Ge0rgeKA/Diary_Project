using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ApiAuth.Models
{

    //2. AuthOptions будет описывать ряд свойств, нужных для генерации токена:
    public class AuthOptions
    {
        public const string ISSUER = "MyAuthServer"; // издатель токена
        public const string AUDIENCE = "MyAuthClient"; // потребитель токен
        public const int LIFETIME = 1; // время жизни токена - 1 минута
        const string KEY = "mysupersecret_secretsecretsecretkey!123";   // ключ для шифрации
        public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
    }
    /*Константа ISSUER представляет издателя токена. Здесь можно определить любое название. 
     * AUDIENCE представляет потребителя токена - опять же может быть любая строка, 
     * но в данном случае указан адрес текущего приложения.
     * Константа KEY хранит ключ, который будет применяться для создания токена*/
}
