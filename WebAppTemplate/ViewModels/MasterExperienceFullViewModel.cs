namespace WebAppTemplate.ViewModels
{
    public class MasterExperienceFullViewModel
    {
        public int Id { get; set; }
        public int DeleteId { get; set; }
        public string StartYear { get; set; }
        public string EndYear { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public bool IsActive { get; set; }
        public string CompanyName { get; set; }
        public List<MasterExperienceViewModel> List { get; set; }
    }
}
