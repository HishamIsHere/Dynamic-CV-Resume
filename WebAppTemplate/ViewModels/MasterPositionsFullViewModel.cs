namespace WebAppTemplate.ViewModels
{
    public class MasterPositionsFullViewModel
    {
        public int Id { get; set; }
        public int DeleteId { get; set; }
        public string Name { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsActive { get; set; }
        public List<MasterPositionsViewModel> List { get; set; }
    }
}
