namespace GMS.Api.Models;

public class Milestone
{
    public int Id { get; set; }
    public int GrantId { get; set; }
    public Grant Grant { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }
}
