using WebAppTemplate.Models;

namespace WebAppTemplate.ViewModels
{
    public class MasterCategoryViewModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public ICollection<MasterPortfolio> MasterPortfolio { get; set; } = new List<MasterPortfolio>();
    }
}
