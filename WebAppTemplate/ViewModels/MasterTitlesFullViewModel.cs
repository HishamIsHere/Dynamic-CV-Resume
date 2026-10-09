namespace WebAppTemplate.ViewModels
{
    public class MasterTitlesFullViewModel
    {
        public int Id { get; set; }
        public int DeleteId { get; set; }
        public string Title { get; set; }
        public string Keyword { get; set; }
        public bool IsActive { get; set; }
        public List <MasterTitlesViewModel> List { get; set; }
    }
}
