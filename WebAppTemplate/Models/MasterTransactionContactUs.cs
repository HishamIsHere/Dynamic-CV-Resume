namespace WebAppTemplate.Models
{
    public class MasterTransactionContactUs : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime SendingDate { get; set; } = DateTime.UtcNow;
        public bool IsReplied { get; set; }
    }
}
