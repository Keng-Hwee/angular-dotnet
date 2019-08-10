namespace App.API.models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        // password salt acts like a key to recreate hash
        public byte[] PasswordSalt { get; set; }
    }
}