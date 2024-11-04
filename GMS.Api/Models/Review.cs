namespace GMS.Api.Models;

public class Review
{
    public int Id { get; set; }
    public int GrantApplicationId { get; set; }
    public Application GrantApplication { get; set; }
    public int ReviewerId { get; set; }
    public User Reviewer { get; set; }
    public string Notes { get; set; }
    public int FeasibilityScore { get; set; }
    public int ImpactScore { get; set; }
    public int BudgetScore { get; set; }
    public DateTime ReviewDate { get; set; }
}
