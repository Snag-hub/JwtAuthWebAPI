namespace JwtAuthWebAPI.Models
{
    public class UserInfo
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public char? IsActive { get; set; }
    }
}
