namespace WebAppTemplate.ViewModels
{
    public class MasterPlanItemsFullViewModel
    {
        public int Id { get; set; }
        public int DeleteId { get; set; } 
        public string Desc { get; set; }
        public int PlanId { get; set; }
        public bool IsActive { get; set; }
        public List<MasterPlanItemsViewModel> List { get; set; }
    }
}
