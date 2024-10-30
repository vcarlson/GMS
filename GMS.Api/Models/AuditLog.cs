public class AuditLog
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public DateTime Timestamp { get; set; }
    public string Action { get; set; }
    public string Details { get; set; }
}
