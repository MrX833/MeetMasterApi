namespace MeetMasterApi.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public required string FirstName { get; set; } 
        public required string LastName { get; set; } 
        public string Email { get; set; } = string.Empty;
        public required string Username { get; set; } 
        public required string PasswordHashed { get; set; } 
        public string Role { get; set; } = "User";
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool RememberMe { get; set; }
    }
}
