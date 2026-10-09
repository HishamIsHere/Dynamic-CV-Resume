namespace WebAppTemplate.Models
{
    public class MasterPlans : BaseEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string PricePeriod { get; set; }
        public bool IsSuggested { get; set; }

    }
}
