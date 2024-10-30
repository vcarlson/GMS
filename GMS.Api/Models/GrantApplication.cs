public class GrantApplication
{
	public int Id { get; set; }
	public string Title { get; set; }
	public string ApplicantName { get; set; }
	public string Organization { get; set; }
	public decimal FundingRequested { get; set; }
	public string ProjectDescription { get; set; }
	public DateTime DateSubmitted { get; set; }
	public string Status { get; set; } // Pending, Under Review, Approved, Rejected

	// Foreign keys and navigation properties
	public List<Review> Reviews { get; set; }
	public List<Document> Documents { get; set; }
}
