namespace Blog;
public static class Configuration
{
    // Token - JWT - Json Web Token
    public static string JwtKey = "ZmVkYWY3ZDg4NjNiNDhlMTk3YjkyODdkNDkyYjcwOGU=";
    // Sempre que passar este parâmetro na requisição ele será autenticado
    public static string ApiKeyName = "api_key";
    public static string ApiKey = "haligdauigfuweluieaeggdlslgeiulggf";
    public static SmtpConfiguration Smtp = new();

    public class SmtpConfiguration
    {
        public string Host { get; set; }
        public int Port { get; set; } = 25;
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
