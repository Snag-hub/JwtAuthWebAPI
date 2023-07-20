namespace JwtAuthWebAPI.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string? EmpName { get; set; }
        public string? JobTitle { get; set; }
        public DateOnly? DOB { get; set; }
        public string? Gender { get; set; }
        public char? IsActive { get; set; }
    }
}
