public class Transaction
{
    public int Id { get; set; }
    public int GrantId { get; set; }
    public Grant Grant { get; set; }
    public decimal Amount { get; set; }
    public DateTime TransactionDate { get; set; }
    public string Type { get; set; } // Disbursement, Expense
    public string Description { get; set; }
}
