namespace WebAppTemplate.Models
{
    public class MasterExperience : BaseEntity
    {
        public string StartYear { get; set; }
        public string EndYear { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string CompanyName { get; set; }
    }
}
