namespace WebAppTemplate.Models
{
    public class MasterCertificates : BaseEntity
    {
        public string ImageURL {  get; set; }
        public string Title { get; set; }
        public int MembershipId { get; set; }
        public DateTime Date {  get; set; }
    }
}
