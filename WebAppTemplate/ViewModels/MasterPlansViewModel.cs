namespace WebAppTemplate.ViewModels
{
    public class MasterPlansViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string PricePeriod { get; set; }
        public bool IsSuggested { get; set; }
        public bool IsActive { get; set; }
    }
}
