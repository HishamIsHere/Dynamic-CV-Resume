namespace WebAppTemplate.ViewModels
{
    public class MasterFactsFullViewModel
    {
        public int Id { get; set; }
        public int DeleteId { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public int Number { get; set; }
        public bool IsActive { get; set; }
        public List<MasterFactsViewModel> List { get; set; } 
    }
}
