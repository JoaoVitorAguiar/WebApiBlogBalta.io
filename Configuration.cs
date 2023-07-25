namespace Blog;
public static class Configuration
{
    // Token - JWT - Json Web Token
    public static string JwtKey = "7Ls3qs9OXp0psOSuff2w528bp4qKpC20";
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
