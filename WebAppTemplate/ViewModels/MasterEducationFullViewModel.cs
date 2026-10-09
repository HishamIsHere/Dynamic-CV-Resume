namespace WebAppTemplate.ViewModels
{
    public class MasterEducationFullViewModel
    {
        public int Id { get; set; }
        public int DeleteId { get; set; }
        public string Year { get; set; }
        public string University { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public bool IsActive { get; set; }
        public List<MasterEducationViewModel> List { get; set; }
    }
}
