namespace WebAppTemplate.ViewModels
{
    public class MasterCategoryFullViewModel
    {
        public int Id { get; set; }
        public int DeleteId { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public List<MasterCategoryViewModel> List { get; set; } = new();
        public MasterCategoryViewModel FormModel { get; set; } = new();
    }
}
