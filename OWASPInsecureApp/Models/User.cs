namespace OWASPInsecureApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        // ❌ Insecure storage
        public string Password { get; set; } = string.Empty;
    }

}
