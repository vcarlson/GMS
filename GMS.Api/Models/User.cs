public class User
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Role { get; set; } // Applicant, Reviewer, Admin, Finance
    public string PasswordHash { get; set; }

    // Relationships
    public List<Review> Reviews { get; set; }
    public List<Notification> Notifications { get; set; }
}
