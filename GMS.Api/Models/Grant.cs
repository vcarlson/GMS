public class Grant
{
    public int Id { get; set; }
    public int GrantApplicationId { get; set; }
    public GrantApplication GrantApplication { get; set; }
    public decimal TotalFundsAllocated { get; set; }
    public decimal FundsSpent { get; set; }
    public string Status { get; set; } // On Track, Delayed, Completed
    public DateTime AwardedDate { get; set; }
    public DateTime CompletionDate { get; set; }

    // Milestones
    public List<Milestone> Milestones { get; set; }
}
