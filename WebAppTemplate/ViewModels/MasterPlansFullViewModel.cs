namespace WebAppTemplate.ViewModels
{
    public class MasterPlansFullViewModel
    {
        public int Id { get; set; }
        public int DeleteId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string PricePeriod { get; set; }
        public bool IsSuggested { get; set; }
        public bool IsActive { get; set; }
        public List<MasterPlansViewModel> List { get; set; }
    }
}
