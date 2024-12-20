
namespace GMS.Api.Models;
public class Notification
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public string Message { get; set; }
    public bool IsRead { get; set; }
    public DateTime DateCreated { get; set; }
}
