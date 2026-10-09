namespace WebAppTemplate.Models
{
    public class MasterCategory : BaseEntity
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public ICollection<MasterPortfolio> MasterPortfolio { get; set; } = new List<MasterPortfolio>();
    }
}
