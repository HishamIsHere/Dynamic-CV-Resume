namespace WebAppTemplate.ViewModels
{
    public class MasterClientsFullViewModel
    {
        public int Id { get; set; }
        public int DeleteId { get; set; }
        public bool IsActive { get; set; }
        public string? Alt { get; set; }
        public IFormFile Imagefile { get; set; }
        public string ImageURL { get; set; }
        public List<MasterClientsViewModel> List {  get; set; }
    }
}
