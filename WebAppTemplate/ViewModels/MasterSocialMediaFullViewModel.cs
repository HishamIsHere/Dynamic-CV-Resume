namespace WebAppTemplate.ViewModels
{
    public class MasterSocialMediaFullViewModel
    {
        public int Id { get; set; }
        public int DeleteId { get; set; }
        public string Icon { get; set; }
        public string Link { get; set; }
        public bool IsActive { get; set; }
        public List<MasterSocialMediaViewModel> List { get; set; }
    }
}
