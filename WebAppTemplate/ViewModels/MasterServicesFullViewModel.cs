namespace WebAppTemplate.ViewModels
{
    public class MasterServicesFullViewModel
    {
        public int Id { get; set; }
        public int DeleteId { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public bool IsActive { get; set; }
        public List <MasterServicesViewModel> List { get; set; }
    }
}
