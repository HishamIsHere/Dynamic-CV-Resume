namespace WebAppTemplate.ViewModels
{
    public class MasterContactUsFullViewModel
    {
        public int Id { get; set; }
        public int DeleteId { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public bool IsActive { get; set; }
        public List<MasterContactUsViewModel> List { get; set; }
    }
}
