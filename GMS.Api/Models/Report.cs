public class Report
{
    public int Id { get; set; }
    public int GrantId { get; set; }
    public Grant Grant { get; set; }
    public string ReportType { get; set; } // Financial, Performance
    public DateTime DateCreated { get; set; }
    public string FilePath { get; set; }
}
