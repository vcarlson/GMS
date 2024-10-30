public class Document
{
    public int Id { get; set; }
    public int GrantApplicationId { get; set; }
    public GrantApplication GrantApplication { get; set; }
    public string FileName { get; set; }
    public string FilePath { get; set; }
    public DateTime UploadDate { get; set; }
}
